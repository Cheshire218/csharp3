using System;
using System.Net;
using System.Net.Mail;

namespace MailSenderLib
{
    public class EmailSender
    {
		/// <summary>
		/// Метод отправляет письма
		/// </summary>
		/// <param name="strUser"></param>
		/// <param name="strPass"></param>
		/// <exception cref="SmtpException"></exception>
		public void SendMail(string strUser, string strPass)
	    {
		    try
		    {
			    using (var message = new MailMessage(MailSenderSettings.from, MailSenderSettings.to, MailSenderSettings.subject, MailSenderSettings.body))
			    using (var client = new SmtpClient(MailSenderSettings.server, MailSenderSettings.port) { EnableSsl = true, Credentials = new NetworkCredential(strUser, strPass) })
			    {
				    client.Send(message);
			    }
		    }
		    catch (SmtpException error)
		    {
			   throw new SmtpException(error.Message);
		    }
		}
    }
}
