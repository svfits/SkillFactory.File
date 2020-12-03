using System;
using System.Collections.Generic;
using System.Text;

namespace SkillFactory.Event
{
    internal class Client1
    {
        public Client1()
        {

        }

        public void ShowMessage(string message)
        {
            Console.WriteLine($"Дошло сообщение до первого клиента { message } в { DateTime.Now }");
        }
    }
}
