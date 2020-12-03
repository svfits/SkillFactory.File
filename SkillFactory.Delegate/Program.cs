using System;

namespace SkillFactory.Delegate
{
    class Program
    {
        static Random Random = new Random();
        delegate void GetRequest();

        static void Main(string[] args)
        {
            var isSend = Random.Next(0, 2);
            var pause = Random.Next(0, 10000);

            Console.WriteLine("Отправим сообщение");
            Console.WriteLine($"Ожидаем пока ответит сервер { pause } мсек") ;

            System.Threading.Thread.Sleep(pause);

            if (isSend > 0)
            {
                DoWork(CancelRequest);
            }
            else
            {
                DoWork(ExceptionRequest);
            }

            Console.ReadLine();
        }

        static void DoWork(GetRequest getRequest)
        {
            getRequest?.Invoke();
        }

        static void CancelRequest()
        {
            Console.WriteLine($"Запрос удачно завершился в { DateTime.Now }");
        }

        static void ExceptionRequest()
        {
            Console.WriteLine($"Запрос завершился с ошибкой в { DateTime.Now }");
        }
    }
}
