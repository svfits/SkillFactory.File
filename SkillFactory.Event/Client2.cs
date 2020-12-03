using System;

namespace SkillFactory.Event
{
    internal class Client2
    {
        public void ShowMessage(string message)
        {
            Console.WriteLine($"Дошло сообщение до второго клиента { message } в { DateTime.Now }");
        }
    }
}