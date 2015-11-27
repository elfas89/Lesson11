using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 <- 7.3 - разные Program для вариантов
            //Animal[] arrAnimal = new Animal[6];

            //2
            string someText = "some text Nikolay some text Nikolay some text Nikolay some text Nikolay some text Nikolay";
            Console.WriteLine(someText);
            someText = someText.Replace("Nikolay", "Oleg");     //заменяем
            Console.WriteLine(someText);

            //3
            string testText = "Сегодня мы с вами рассмотрели, как работать со строками в Си-шарп. Были описаны основные операторы и методы, которые используются для работы со строками";
            //заменяем конкретные куски на пусто
            //testText = testText.Replace("Сегодня мы с вами рассмотрели, как работать со строками в Си-шарп. ", "");
            //testText = testText.Replace(", которые используются для работы со строками", "");
            Console.WriteLine(testText);

            //находим в строке точку, убираем до нее включительно
            int ind1 = testText.IndexOf('.');
            Console.WriteLine(ind1);
            testText = testText.Remove(0, ind1 + 1);
            Console.WriteLine(testText);

            //находим запятую, берем только часть строки до нее
            int ind2 = testText.IndexOf(',');
            Console.WriteLine(ind2);
            testText = testText.Substring(0, ind2);
            Console.WriteLine(testText);

            //убираем лишние пробелы
            testText = testText.Trim();
            Console.WriteLine(testText);

            //4
            string logins = "Login1,LOgin2,login3,loGin4";
            logins = logins.ToLower();
            string[] users = logins.Split(',');
            foreach (string s in users)
            {
                Console.WriteLine(s);
            }

            //5

            List<string> enteredList = new List<string>();

            while (true)
            {
                Console.WriteLine("Please type text or numbers (type 'end' to stop): ");
                
                string entered = Console.ReadLine();

                enteredList.Add(entered);

                if (entered == "end")
                {
                    foreach (string s in enteredList)
                    {
                            Console.WriteLine(s);   
                    }

                    return;
                }
            }


        }
    }
}
