//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections;

//namespace Lesson11
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Dictionary<int, string> arrAnimal = new Dictionary <int, string>(6);

//            Animal s = new Dog { Name = "Шарик" };
//            Animal k = new Cat { Name = "Кусака" };
//            Animal l = new Cat { Name = "Ленивец" };
//            Animal d = new Dog { Name = "Джек" };
//            Animal c = new Cat { Name = "Черныш" };

//            arrAnimal.Add(1, s.Name);
//            arrAnimal.Add(28, k.Name);
//            arrAnimal.Add(56, l.Name);
//            arrAnimal.Add(88, d.Name);
//            arrAnimal.Add(22, c.Name);
//            Dog r = new Dog { Name = "Арчи" };
//            arrAnimal.Add(3, r.Name);

//            string someAnimal = arrAnimal[22];
//            Console.WriteLine(someAnimal);
//            //arrAnimal.Remove(88);

//            foreach (KeyValuePair<int, string> a in arrAnimal)
//            {
//                Console.WriteLine(a.Key + " - " + a.Value);
//            }
//            //перебор ключей
//            foreach (int i in arrAnimal.Keys)
//            {
//                Console.WriteLine(i);
//            }
//            //перебор значений
//            foreach (string str in arrAnimal.Values)
//            {
//                Console.WriteLine(str);
//            }



//        }
//    }
//}
