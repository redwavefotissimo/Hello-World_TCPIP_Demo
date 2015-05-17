using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Configuration;

namespace TCPManager
{
    public class TCPIPController
    {
        private static TcpListener listener;
        private static int PortNumber;
        private static IPAddress IPAddress;
        
        
        public static void StartListening(int Portnumber)
        {
            PortNumber = Portnumber;
            listener = new TcpListener(IPAddress, PortNumber);
            listener.Start();
        }

        public static void Service()
        {
            // Use add existing item, select the app config from dll project. Before clicking add, 
            // use the little down arrow on the right hand side of the add button to "add as link"
            while (true)
            {
                Socket Soc = listener.AcceptSocket();
                try
                {
                    Stream Stream = new NetworkStream(Soc);
                    StreamReader StreamReader = new StreamReader(Stream);
                    StreamWriter StreamWriter = new StreamWriter(Stream);
                    StreamWriter.AutoFlush = true;
                    while (!StreamReader.EndOfStream)
                    {
                        string Name = StreamReader.ReadLine();
                        if (string.IsNullOrWhiteSpace(Name)) break;
                        
                        string Job = ConfigurationManager.AppSettings[Name];
                        if (Job == null)
                            Job = "No such Employee";
                        StreamWriter.WriteLine(Job);
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
                finally
                {
                    Soc.Close();
                }
            }
        }

        public static string Client(string Name, int PortNumber)
        {
            string Job = string.Empty;
            TcpClient TCPClient = new TcpClient(Dns.GetHostName(), PortNumber);
            try
            {
                Stream Stream = TCPClient.GetStream();
                StreamReader StreamReader = new StreamReader(Stream);
                StreamWriter StreamWriter = new StreamWriter(Stream);
                StreamWriter.AutoFlush = true;

               
                StreamWriter.WriteLine(Name);
                if (String.IsNullOrWhiteSpace(Name))
                {
                    Stream.Close();
                    throw new Exception("---End---");
                }
                Job = StreamReader.ReadLine();
                
            }
            finally
            {
                TCPClient.Close();
            }

            return Job;
        }

        public static IPAddress GetServerMachineIPAddress()
        {
            IPAddress = Dns.GetHostAddresses(Dns.GetHostName()).Last();
            return IPAddress;
        }

        public static List<int> GetAvailablePorts()
        {
            return null;
        }
    }
}
