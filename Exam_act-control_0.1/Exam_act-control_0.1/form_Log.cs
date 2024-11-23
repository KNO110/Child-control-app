using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Exam_act_control_0._1
{
    public partial class form_Log : Form
    {
        private string logFilePath = "server_log.txt";

        public form_Log()
        {
            InitializeComponent();
            form_Main.OnLogMessage += Form_Main_OnLogMessage;

            // Загрузка существующих логов при запуске формы
            if (File.Exists(logFilePath))
            {
                string[] lines = File.ReadAllLines(logFilePath);
                listBox1.Items.AddRange(lines);
            }
        }

        private void Form_Main_OnLogMessage(string message)
        {
            if (listBox1.InvokeRequired)
            {
                listBox1.Invoke((MethodInvoker)(() =>
                {
                    listBox1.Items.Add(message);
                }));
            }
            else
            {
                listBox1.Items.Add(message);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            form_Main.OnLogMessage -= Form_Main_OnLogMessage;
        }

        private void pnl_Main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
