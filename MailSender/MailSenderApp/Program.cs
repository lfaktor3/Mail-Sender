using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender;

namespace MailSenderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MailClient mail = new MailClient();
            mail.SendEmail("luka.faktor@vsmti.hr", "mail", "pozzzzzzzzzz");
            Console.ReadKey();
        }
    }
}
