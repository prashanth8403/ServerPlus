/*
        non-function code.
        To be used in later versions.
 */

using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Net.Mail;
using System.Threading;

namespace ServerPlus.ServerModule
{
    class ServerSocket
    {
        const int PORT_NO = 5035;
        const string SERVER_IP = "192.168.43.25";
        string SERVER_REQUEST_STRING;

        static void CreateSocket()
        {
            IPAddress ServerAccess = IPAddress.Parse(SERVER_IP);
            TcpListener ServerListner = new TcpListener(ServerAccess, PORT_NO);
            Console.WriteLine("MAIL SERVER RUNNING @ " + SERVER_IP + ":" + PORT_NO.ToString() + "/>");
            ServerListner.Start();
            TcpClient client = ServerListner.AcceptTcpClient();
            NetworkStream nwStream = client.GetStream();
            byte[] buffer = new byte[client.ReceiveBufferSize];
            int bytesRead = nwStream.Read(buffer, 0, client.ReceiveBufferSize);
            //MailReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            //Console.WriteLine("Request $ " + SERVER_REQUEST_STRING);
            //Thread _emailthread = new Thread(SendMail);
            //_emailthread.Start();
            byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes("1000");
            nwStream.Write(bytesToSend, 0, bytesToSend.Length);
            Utility.mailqueue++;
            client.Close();
            ServerListner.Stop();
        }
    }
}
