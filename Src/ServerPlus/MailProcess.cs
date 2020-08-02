using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Net.Mail;
using System.Threading;

namespace ServerPlus
{
    class MailProcess
    {
        const int PORT_NO = 5030;
        const string SERVER_IP = "192.168.43.25";
        static string MailReceived;

        public static void MailServer()
        {
            do
            {
                IPAddress ServerAccess = IPAddress.Parse(SERVER_IP);
                TcpListener ServerListner = new TcpListener(ServerAccess, PORT_NO);
                Console.WriteLine("MAIL SERVER RUNNING @ " + SERVER_IP + ":" + PORT_NO.ToString() + "/>");
                ServerListner.Start();
                TcpClient client = ServerListner.AcceptTcpClient();
                NetworkStream nwStream = client.GetStream();
                byte[] buffer = new byte[client.ReceiveBufferSize];
                int bytesRead = nwStream.Read(buffer, 0, client.ReceiveBufferSize);
                MailReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Request $ " + MailReceived);
                Thread _emailthread = new Thread(SendMail);
                _emailthread.Start();
                byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes("1000");
                nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                Utility.mailqueue++;
                client.Close();
                ServerListner.Stop();
            } while (true);
        }

        static void SendMail()
        {
            try
            {
                string[] EmailContent = MailReceived.Split('`');
                MailMessage mail = new MailMessage();
                mail.To.Add(EmailContent[0]);
                mail.From = new MailAddress("prashanth7514@gmail.com");
                mail.Subject = EmailContent[1];
                string Body = EmailContent[2];
                mail.Body = Body;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                string u = "prashanth7514@gmail.com", v = "Hunter21#";
                smtp.Credentials = new System.Net.NetworkCredential(u, v);
                smtp.EnableSsl = true;
                smtp.Send(mail);
                Utility.mail++;
                Utility.mailqueue--;
                Console.WriteLine("Mail Sent to :" + EmailContent[0]);
            }
            catch (Exception ex)
            {
                Utility.mailfailed++;
                Utility.mailqueue--;
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
