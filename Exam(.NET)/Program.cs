using ServerSpy;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Xml.Serialization;

namespace SpyClient
{
    class Program
    {
        static void Main(string[] args) 
        {
            Main:
            SpyClient spyClient = new SpyClient();
            if (spyClient.ConnectToServer()) 
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Reconecting");
                Console.ResetColor();
                goto Main;  
            }
        }
    }

    public class SpyClient 
    {
        private const string ipAdress = "127.0.0.1";
        private const int port = 45000;
        private TcpClient tcpClient = null;
        private bool startReconnecting = false;
        public bool ConnectToServer()
        {
            ConnectingProcess:
            tcpClient = new TcpClient();
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(ipAdress), port);
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Attempt connect to server...");
                Console.ResetColor();
                tcpClient.Connect(iPEndPoint);  
            }
            catch { Thread.Sleep(1000); goto ConnectingProcess; }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Connected to server");
            Console.ResetColor();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            List<ProcessDescription> machineName = new List<ProcessDescription> { new ProcessDescription(Dns.GetHostName()) };

            binaryFormatter.Serialize(tcpClient.GetStream(), machineName); 

            Thread connectThread = new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        BinaryFormatter deserializer = new BinaryFormatter();
                        string response = (string)deserializer.Deserialize(tcpClient.GetStream());
                        if (response == "kill") { break; }
                        if (response.Length > 0 && response != null)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Start process of responsing");
                            Console.ResetColor();
                            Thread responseThread = new(ResponseToServer);
                            responseThread.Start(new IDPair(iPEndPoint, response));
                            response = "";
                        }
                    }
                    catch (Exception ex) { startReconnecting = true; break; }
                }
            });
            connectThread.Start();
            connectThread.Join();
            return startReconnecting;
        }  
        public async void ResponseToServer(object obj)
        {
            IPEndPoint iPEndPoint = ((IDPair)obj).ipEndPoint;
            string machineID = ((IDPair)obj).machineID;
            await Task.Run(() =>
            {
                while (true)
                {
                    try
                    {
                        TcpClient responseClient = new TcpClient();
                        responseClient.Connect(iPEndPoint);
                        BinaryFormatter serializer = new BinaryFormatter();

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Responsing to server");
                        Console.ResetColor();

                        List<ProcessDescription> processes = new List<ProcessDescription>();
                        foreach (Process process in Process.GetProcesses())
                        {
                            if (process.MainWindowTitle != "" )
                            {
                                processes.Add(new ProcessDescription(process.MainModule.ToString().Substring(process.MainModule.ToString().IndexOf('(') + 1).Replace(')', ' '), process.MainWindowTitle, machineID));
                            }
                        }
                        serializer.Serialize(responseClient.GetStream(), processes);

                        Thread.Sleep(2000); //Time waited for next response
                        bool stopResponig = (bool)serializer.Deserialize(responseClient.GetStream());
                        if (stopResponig) 
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Stop Responsing");
                            Console.ResetColor();
                            break; 
                        }
                        
                    }
                    catch(SerializationException se) {  }
                    catch { break; }
                }
            });
        }
    }
}

