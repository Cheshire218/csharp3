using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSenderLib
{
    public static class MailSenderSettings
    {
        public static string from = "user@yandex.ru";
        public static string to = "user@gmail.com";
        public static string server = "smtp.yandex.ru";
        public static int port = 25;

        public static string subject = "Test message";
        public static string body = "Test message body";
    }
}
