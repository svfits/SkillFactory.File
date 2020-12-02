using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace SkillFactory.GetDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            //string dirName = @"/";
            //if (Directory.Exists(dirName)) // Проверим, что директория существует
            //{
            //    Console.WriteLine("Папки:");
            //    // Получим все директории корневого каталога
            //    string[] dirs = Directory.GetDirectories(dirName);

            //    // Выведем их все
            //    foreach (string d in dirs)
            //    {
            //        Console.WriteLine(d);
            //    }

            //    Console.WriteLine();
            //    Console.WriteLine("Файлы:");
            //    string[] files = Directory.GetFiles(dirName); // Получим все файлы корневого каталога

            //    // Выведем их все
            //    foreach (string s in files)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}

            //List<User> listUser = new List<User>();
            var fileName = "Список пользователей.txt";

            //for (int i = 0; i < 100; i++)
            //{
            //    listUser.Add(new User()
            //    {
            //        Age = i,
            //        NumberPass = i,
            //        Salary = i
            //    });
            //}

            //listUser.SaveXMLFile(fileName: fileName);
            
            var listUserLoadFromFile = LoadXMLFile<List<User>>(fileName: fileName);

            foreach (var item in listUserLoadFromFile)
            {
                Console.WriteLine($"Возвраст пользователя из файла { item.Age } ");
                Console.WriteLine($"Номер пропуска { item.NumberPass } ");
                Console.WriteLine($"Зарплата { item.Salary } ");
                Console.WriteLine("----------------------------------------");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Загрузка из файла
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static T LoadXMLFile<T>(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            // Declare an object variable of the type to be deserialized.
            T i;

            using (Stream reader = new FileStream(fileName, FileMode.Open))
            {
                // Call the Deserialize method to restore the object's state.
                i = (T)serializer.Deserialize(reader);
                //Dispose
            }

            return i;
        }
    }
}
