using System;
using System.Collections.Generic;
using System.Text;

namespace SkillFactory.Event
{
    class Sender
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler Notify;

        public void SenderMailing()
        {
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(5000);
                Notify?.Invoke($"Сообщение всем кто подписался на это письмо { DateTime.Now }"); ;
            }
        }
    }
}
