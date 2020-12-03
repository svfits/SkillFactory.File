using System;

namespace SkillFactory.Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Client1 client1 = new Client1();
            Client2 client2 = new Client2();
            Client3 client3 = new Client3();

            Sender sender = new Sender();
            sender.Notify += ShowMessage;
            sender.Notify += client1.ShowMessage;
            sender.Notify += client2.ShowMessage;
            sender.Notify += client3.ShowMessage;

            sender.SenderMailing();

            Console.WriteLine($"Закончил работу основной метод MAIN в { DateTime.Now }");
            Console.ReadLine();
        }

        private static void ShowMessage(string message)
        {
            Console.WriteLine();
            Console.WriteLine($" Сообщение пришло в Main { message } в { DateTime.Now }");
        }
    }
}
