using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Services
{
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            
            // Plug in your email service here to send an email.
            return Task.FromResult(0);
        }
        private async Task<bool> SendEmail(string emailTo, string emailFrom, string emailSubject, string emailBody, bool isBodyHtml)
        {
            SmtpClient smtp = new SmtpClient(SMTPSettings.SmtpServer, SMTPSettings.PortNumber);
            smtp.Credentials = new NetworkCredential(emailFrom, SMTPSettings.Password);
            smtp.EnableSsl = true;
            var message = new System.Net.Mail.MailMessage();
            message.From = new MailAddress(emailFrom);
            message.To.Add(new MailAddress(emailTo));
            message.IsBodyHtml = isBodyHtml;
            message.Subject = emailSubject;
            message.Body = emailBody;

            try
            {
                smtp.SendCompleted += (s, e) => {
                    smtp.Dispose();
                    message.Dispose();
                };
                await smtp.SendMailAsync(message);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
    public static class SMTPSettings
    {
        public static string MailFrom = "admin@juntoapp.io";
        public static string Password = "ZohoMailPass11@!";
        public static int PortNumber = 587;
        public static string SmtpServer = "smtp.zoho.com";
    }
}
