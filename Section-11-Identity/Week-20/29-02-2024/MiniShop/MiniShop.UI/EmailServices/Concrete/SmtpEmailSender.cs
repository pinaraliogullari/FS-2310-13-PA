﻿using MiniShop.UI.EmailServices.Abstract;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace MiniShop.UI.EmailServices.Concrete
{
    /* host: mail server adresi
        * port:serverdaki port numarası
        * enableSsl : ssl sertifikasına sahip olunum olunmadığı
        * username ve password
        * bu bilgileri appsettinjson dosyasında tutup , dı yöntemiyle buraya alıyoruzç
        */
    public class SmtpEmailSender : IEmailSender
    {
        private readonly string _host;
        private readonly int _port;
        private readonly bool _enableSsl;
        private readonly string _userName;
        private readonly string _password;

        public SmtpEmailSender(string host, int port, bool enableSsl, string userName, string password)
        {
            _host = host;
            _port = port;
            _enableSsl = enableSsl;
            _userName = userName;
            _password = password;
        }

       
        public async Task SendEmailAsync(string emailTo, string subject, string htmlMessage)
        {
            var client = new SmtpClient(_host, _port)
            {
                Credentials = new NetworkCredential(_userName, _password),
                EnableSsl = _enableSsl,
            };
            await client.SendMailAsync(new MailMessage(_userName, emailTo,subject,htmlMessage)
            {
               IsBodyHtml = true
            });
           
       
        }
    }
}
