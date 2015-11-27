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
//            ArrayList arrAnimal = new ArrayList();

//            Animal dog = new Dog { Name = "Шарик" };
//            arrAnimal.Add(dog);
//            arrAnimal.Add(new Cat {Name = "Кусака"});
//            arrAnimal.Add(new Cat { Name = "Ленивец" });
//            arrAnimal.Add(new Dog { Name = "Джек" });
//            arrAnimal.Add(new Cat { Name = "Черныш" });
//            arrAnimal.Add(new Dog { Name = "Арчи" });

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
