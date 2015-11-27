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
//            List<Animal> arrAnimal = new List<Animal>() { 
//                                                        new Dog { Name = "Шарик" },
//                                                        new Cat { Name = "Кусака" },
//                                                        new Cat { Name = "Ленивец" },
//                                                        new Dog { Name = "Джек" },
//                                                        new Cat { Name = "Черныш" }
//                                                        };
//            Dog d = new Dog { Name = "Арчи" };
//            arrAnimal.Add(d);

            //Console.WriteLine(arrAnimal.Capacity);
            //Console.WriteLine(arrAnimal.Count);
            //arrAnimal.Capacity = 6;
            //Console.WriteLine(arrAnimal.Capacity);

//            foreach (Animal a in arrAnimal)
//            {
////Вызывает метод Bite у всех объектов в массиве arrAnimal
//                a.Bite();


////Вызывает метод Purr только у тех объектов, которые являются экземплярами класса Cat (данный пункт необходимо реализовать 3 способами).

//                //one
//                Animal cat = a as Cat;
//                if (cat != null)
//                {
//                    ((Cat)a).Purr();
//                }

//                //two
//                if (a is Cat)
//                {
//                    ((Cat)a).Purr();
//                }

//                //three
//                try
//                {
//                    ((Cat)a).Purr();
//                }
//                catch (InvalidCastException ex)
//                {
//                    Console.WriteLine(ex.Message);
//                }

//            }



//        }
//    }
//}
