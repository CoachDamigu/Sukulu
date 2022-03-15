using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net.Mail;
using System.Text;

namespace Sukulu.DataAccessLibrary.Repositories
{
    public class EmailingFactory
    {
        public void SendEmailWithScreenShot(Bitmap memoryImage, string Msg, string Subject)
        {
            //string STMPClient = Properties.Settings.Default.AppSTMPClient;
            //MailMessage mail = new MailMessage();
            //SmtpClient SmtpServer = new SmtpClient(STMPClient); //"smtp.gmail.com"
            //string SupporGenericEmail = Properties.Settings.Default.SupportGenericEmail;
            //mail.From = new MailAddress(SupporGenericEmail);
            //mail.To.Add("damigu@djagbare.com");
            //mail.Subject = Subject;
            //mail.Body = Msg;
            //memoryImage.Save("c:\\screenshot1.jpeg", ImageFormat.Jpeg);
            //Attachment ImageAttach = new Attachment("c:\\screenshot1.jpeg");
            //mail.Attachments.Add(ImageAttach);
            //SmtpServer.Port = 587;
            //string Email = Properties.Settings.Default.SupportEmail;
            //string Pwd = Properties.Settings.Default.SupportEmailPassword;
            //SmtpServer.Credentials = new System.Net.NetworkCredential(Email, Pwd);
            //SmtpServer.EnableSsl = false;
            //SmtpServer.Send(mail);
        }

        public void SendEmail(string Message, string Subject)
        {
            //string STMPClient = Properties.Settings.Default.AppSTMPClient;
            //MailMessage mail = new MailMessage();
            //SmtpClient SmtpServer = new SmtpClient(STMPClient);
            //string SupporGenericEmail = Properties.Settings.Default.SupportGenericEmail;
            //mail.From = new MailAddress(SupporGenericEmail);
            //mail.To.Add("damigu.djagbare@edmonton.ca");
            //mail.Subject = Subject;
            //mail.Body = Message;
            //SmtpServer.Port = 587;
            //string Email = Properties.Settings.Default.SupportEmail;
            //string Pwd = Properties.Settings.Default.SupportEmailPassword;
            //SmtpServer.Credentials = new System.Net.NetworkCredential(Email, Pwd);
            //SmtpServer.EnableSsl = false;
            //SmtpServer.Send(mail);
        }
    }
}
