using System;

namespace SkillFactory.Event
{
    internal class Client3
    {
        public void ShowMessage(string message)
        {
            Console.WriteLine($"Дошло сообщение до третьего клиента { message } в { DateTime.Now }");
        }
    }
}