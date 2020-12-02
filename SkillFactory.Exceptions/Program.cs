using System;
using System.Linq;

namespace SkillFactory.Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //var firstParam = args.FirstOrDefault();

            //if (firstParam == null)
            //{
            //    throw new ArgumentNullException("Укажите обязательно первый аргумент для процесса расчета");
            //}

            try
            {
                Console.WriteLine("Введите первое число ");
                var number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите второе число ");
                var number2 = int.Parse(Console.ReadLine());

                var total = number1 / number2;

                //throw new MyException("Выбросим свое исключение");
                throw new StackOverflowException();
            }
            catch (DivideByZeroException dividEx)
            {
                Console.WriteLine($"Блок DivideByZeroException messsage { dividEx.Message }");
                Console.WriteLine($"Блок DivideByZeroException stack { dividEx }");
            }
            catch (MyException myException)
            {
                Console.WriteLine($"Блок MyException messsage { myException.Message }");
                Console.WriteLine($"Блок MyException stack { myException }");

                throw new Exception("Выбросим опять исключение т.к программа не должна уже работать!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Блок общий Exception messsage { ex.Message }");
                Console.WriteLine($"Блок общий Exception stack { ex }");
            }
            finally
            {
                Console.WriteLine("Блок finally освободим ресурсы которые использовали");
            }

            Console.ReadLine();
        }
    }
}
