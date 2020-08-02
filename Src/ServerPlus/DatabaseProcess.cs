using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Threading;

namespace ServerPlus
{
    class DatabaseProcess
    {
        const int PORT_NO = 5035;
        const string SERVER_IP = "192.168.43.25";
        static string RequestReceived;
        public static void DataServer()
        {
            do
            {
                IPAddress localAdd = IPAddress.Parse(SERVER_IP);
                TcpListener listener = new TcpListener(localAdd, PORT_NO);
                Console.WriteLine("Juno Running>>>");
                listener.Start();
                TcpClient client = listener.AcceptTcpClient();
                NetworkStream nwStream = client.GetStream();
                byte[] buffer = new byte[client.ReceiveBufferSize];
                int bytesRead = nwStream.Read(buffer, 0, client.ReceiveBufferSize);
                RequestReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Request $ " + RequestReceived);
                byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes("1000");
                nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                client.Close();
                listener.Stop();
                Utility.database++;
            } while (true);
        }
    }
    
}
