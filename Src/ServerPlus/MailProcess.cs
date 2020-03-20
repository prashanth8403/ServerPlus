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
    class MailProcess
    {
        const int PORT_NO = 5030;
        const string SERVER_IP = "192.168.43.25";
        static string MailReceived;
        public static void MessageServer()
        {
            //Performance _performance = new Performance();
           
            do
            {
                IPAddress localAdd = IPAddress.Parse(SERVER_IP);
                TcpListener listener = new TcpListener(localAdd, PORT_NO);
                Console.WriteLine("Atlas Running>>>");
                listener.Start();
                TcpClient client = listener.AcceptTcpClient();
                NetworkStream nwStream = client.GetStream();
                byte[] buffer = new byte[client.ReceiveBufferSize];
                int bytesRead = nwStream.Read(buffer, 0, client.ReceiveBufferSize);
                MailReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Request $ " + MailReceived);
                Thread _emailthread = new Thread(Mail);
                _emailthread.Start();
                byte[] bytesToSend = ASCIIEncoding.ASCII.GetBytes("1000");
                nwStream.Write(bytesToSend, 0, bytesToSend.Length);
                Utility.mailqueue++;
                //_performance.Cur_MailReq++;
                client.Close();
                listener.Stop();
            } while (true);
        }

        static void Mail()
        {
            try
            {
                string[] EmailContent = MailReceived.Split('`');
                MailMessage mail = new MailMessage();
                mail.To.Add(EmailContent[0]);
                mail.From = new MailAddress("<--addyourmailhere-->");
                mail.Subject = EmailContent[1];
                string Body = EmailContent[2];
                mail.Body = Body;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "<add host>";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                string u = "<add auth. username>", v = "<add password>";
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
