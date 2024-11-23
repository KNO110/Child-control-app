using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Exam_act_control_0._1
{
    public partial class form_Main : Form
    {
        private static TcpListener listener; //// Остаётся статическим
        private static List<TcpClient> clients = new List<TcpClient>(); //// Делаем статическим
        private static List<string> processes = new List<string>(); /// Делаем статическим
        private static object lockObj = new object(); /// Делаем статическим

        private static object logLock = new object();
        private string logFilePath = "server_log.txt"; ///// Путь к файлу логов

        public static event Action<string> OnLogMessage; ///// Событие для передачи логов

        private System.Windows.Forms.Timer clearTimer; //// Таймер для очистки данных

        public form_Main()
        {
            InitializeComponent();
            this.Activated += Form_Main_Activated; //// Добавляем обработчик события Activated

            skyTextBox1.TextChanged += skyTextBox1_TextChanged; //// Связываем событие TextChanged с методом

            //// Инициализируем таймер
            clearTimer = new System.Windows.Forms.Timer();
            clearTimer.Interval = 10000;
            clearTimer.Tick += ClearTimer_Tick;
            clearTimer.Start();

            //// Проверяем, был ли уже создан TcpListener
            if (listener == null)
            {
                //// Если нет, то создаем новый экземпляр TcpListener и запускаем его
                listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 20042);
                listener.Start();
                Task.Run(() => AcceptClients());
            }
        }

        private void ClearTimer_Tick(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            lock (lockObj)
            {
                processes.Clear();
            }
            ClearProcessListBox();
        }

        private void Log(string message)
        {
            lock (logLock)
            {
                try
                {
                    string logMessage = $"{DateTime.Now}: {message}";
                    using (StreamWriter sw = new StreamWriter(logFilePath, true))
                    {
                        sw.WriteLine(logMessage);
                    }
                    OnLogMessage?.Invoke(logMessage);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Ошибка записи в лог файл: {ex.Message}");
                }
            }
        }

        private async Task AcceptClients()
        {
            try
            {
                while (true)
                {
                    TcpClient client = await listener.AcceptTcpClientAsync();
                    clients.Add(client);
                    Log("Клиент подключился: " + client.Client.RemoteEndPoint.ToString());
                    Task.Run(() => HandleClient(client));
                }
            }
            catch (Exception ex)
            {
                Log($"Ошибка при принятии клиента: {ex.Message}");
            }
        }

        private async Task HandleClient(TcpClient client)
        {
            try
            {
                using (NetworkStream stream = client.GetStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    // При подключении нового клиента очищаем список процессов и listBox
                    lock (lockObj)
                    {
                        processes.Clear();
                    }
                    ClearProcessListBox();

                    while (true)
                    {
                        string message = await reader.ReadLineAsync();
                        if (message == null)
                        {
                            // Клиент отключился
                            Log("Клиент отключился: " + client.Client.RemoteEndPoint.ToString());
                            break;
                        }
                        if (!string.IsNullOrEmpty(message))
                        {
                            AddProcessToList(message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log($"Ошибка при обработке клиента: {ex.Message}");
            }
            finally
            {
                client.Close();
            }
        }

        private void ClearProcessListBox()
        {
            if (listBox1.InvokeRequired)
            {
                listBox1.Invoke((MethodInvoker)(() =>
                {
                    listBox1.Items.Clear();
                }));
            }
            else
            {
                listBox1.Items.Clear();
            }
        }

        private void AddProcessToList(string processInfo)
        {
            lock (lockObj)
            {
                processes.Add(processInfo);

                if (processes.Count > 1000)
                {
                    processes.RemoveRange(0, processes.Count - 1000);
                }
            }
            // Обновляем listBox
            if (listBox1.InvokeRequired)
            {
                listBox1.Invoke((MethodInvoker)(() =>
                {
                    AddProcessToListBox(processInfo);
                }));
            }
            else
            {
                AddProcessToListBox(processInfo);
            }
        }

        private void AddProcessToListBox(string processInfo)
        {
            // Получение PID и названия процесса из информации о процессе
            string[] parts = processInfo.Split(':');
            int pid;
            string processName;
            if (parts.Length == 2 && int.TryParse(parts[0], out pid))
            {
                processName = parts[1];
                // Добавление PID и названия процесса в ListBox
                listBox1.Items.Add($"PID: {pid} - {processName}");
            }
        }

        private void Form_Main_Activated(object sender, EventArgs e)
        {
            // Обновляем список процессов при активации формы
            lock (lockObj)
            {
                UpdateProcessListBox();
            }
        }

        private void UpdateProcessListBox()
        {
            if (listBox1.InvokeRequired)
            {
                listBox1.Invoke((MethodInvoker)(() =>
                {
                    listBox1.Items.Clear();
                    foreach (string processInfo in processes)
                    {
                        AddProcessToListBox(processInfo);
                    }
                }));
            }
            else
            {
                listBox1.Items.Clear();
                foreach (string processInfo in processes)
                {
                    AddProcessToListBox(processInfo);
                }
            }
        }

        private void skyTextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = skyTextBox1.Text.ToLower();

            List<string> filteredProcesses;
            lock (lockObj)
            {
                if (string.IsNullOrEmpty(searchText) || searchText == "Search")
                {
                    filteredProcesses = new List<string>(processes);
                }
                else
                {
                    filteredProcesses = processes
                        .Where(p => p.ToLower().Contains(searchText))
                        .ToList();
                }
            }

            // Обновляем listBox1
            if (listBox1.InvokeRequired)
            {
                listBox1.Invoke((MethodInvoker)(() =>
                {
                    listBox1.Items.Clear();
                    foreach (var processInfo in filteredProcesses)
                    {
                        AddProcessToListBox(processInfo);
                    }
                }));
            }
            else
            {
                listBox1.Items.Clear();
                foreach (var processInfo in filteredProcesses)
                {
                    AddProcessToListBox(processInfo);
                }
            }
        }
        private void KillProcessByPID(int pid)
        {
            try
            {
                Process process = Process.GetProcessById(pid);
                string processName = process.ProcessName;
                process.Kill();
                Log($"Процесс '{processName}' с PID {pid} был успешно завершён.");
                // Уведомление пользователя
                Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show($"Процесс '{processName}' с PID {pid} успешно завершён.");
                }));
            }
            catch (Exception ex)
            {
                Log($"Ошибка при завершении процесса с PID {pid}: {ex.Message}");
                Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show($"Ошибка при завершении процесса с PID {pid}: {ex.Message}");
                }));
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            // Получаем PID из текстового поля
            if (int.TryParse(nightTextBox1.Text, out int pid))
            {
                // Отправляем команду завершения процесса клиентам
                foreach (var client in clients)
                {
                    try
                    {
                        StreamWriter writer = new StreamWriter(client.GetStream());
                        writer.WriteLine($"KillPID:{pid}");
                        writer.Flush();

                        // Логирование отправки команды Kill PID
                        Log($"Отправлена команда KillPID для PID {pid} клиенту {client.Client.RemoteEndPoint}");
                    }
                    catch (Exception ex)
                    {
                        Log($"Ошибка при отправке команды завершения процесса клиенту: {ex.Message}");
                        MessageBox.Show($"Error sending kill process command to client: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid PID entered");
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            string filePath = nightTextBox2.Text.Trim(); // Получаем путь к файлу из nightTextBox2

            if (!string.IsNullOrEmpty(filePath)) // Проверяем, что путь не пустой
            {
                try
                {
                    System.Diagnostics.Process.Start(filePath); // Запускаем файл по указанному пути
                    Log($"Запущен файл: {filePath}");
                }
                catch (Exception ex)
                {
                    Log($"Ошибка при запуске файла {filePath}: {ex.Message}");
                    MessageBox.Show("Ошибка при запуске файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите путь к файлу.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nightPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nightPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nightTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void skyLabel3_Click(object sender, EventArgs e)
        {

        }

        private void skyTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnl_Main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
