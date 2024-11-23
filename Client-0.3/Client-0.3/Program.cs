using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace TcpConsoleApp
{
    class Program
    {
        static TcpClient client;
        static NetworkStream stream;
        static StreamReader reader;
        static StreamWriter writer;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TCP Console App");

            ConnectToServer("127.0.0.1", 20042);

            Thread receiveThread = new Thread(new ThreadStart(ReceiveMessages));
            receiveThread.Start();

            Thread sendThread = new Thread(new ThreadStart(SendProcesses));
            sendThread.Start();

            while (true)
            {
                string input = Console.ReadLine();

                writer.WriteLine(input);
                writer.Flush();
            }
        }

        static void ConnectToServer(string ipAddress, int port)
        {
            try
            {
                client = new TcpClient(ipAddress, port);
                stream = client.GetStream();
                reader = new StreamReader(stream);
                writer = new StreamWriter(stream);

                Console.WriteLine("Connected to server");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to server: " + ex.Message);
            }
        }

        static void ReceiveMessages()
        {
            try
            {
                while (true)
                {
                    string message = reader.ReadLine();
                    if (!string.IsNullOrEmpty(message))
                    {
                        if (File.Exists(message))
                        {
                            Console.WriteLine($"Opening file: {message}");
                            System.Diagnostics.Process.Start(message);
                        }
                        else
                        {
                            Console.WriteLine($"Received message from server: {message}");
                            if (int.TryParse(message, out int pid))
                            {
                                KillProcess(pid);
                            }
                            else if (message.StartsWith("KillPID:"))
                            {
                                int.TryParse(message.Substring(8), out int killPid);
                                KillProcess(killPid);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error receiving messages: " + ex.Message);
            }
        }

        static void SendProcesses()
        {
            try
            {
                while (true)
                {
                    List<string> processes = GetRunningProcesses();
                    foreach (string process in processes)
                    {
                        writer.WriteLine(process);
                        writer.Flush();
                    }
                    Thread.Sleep(500);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending processes: " + ex.Message);
            }
        }

        static List<string> GetRunningProcesses()
        {
            List<string> processes = new List<string>();
            foreach (var process in System.Diagnostics.Process.GetProcesses())
            {
                processes.Add($"{process.Id}:{process.ProcessName}");
            }
            return processes;
        }

        private static void KillProcess(int pid)
        {
            try
            {
                System.Diagnostics.Process.GetProcessById(pid).Kill();
                Console.WriteLine($"Process with PID {pid} killed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error killing process with PID {pid}: {ex.Message}");
            }
        }
    }
}
