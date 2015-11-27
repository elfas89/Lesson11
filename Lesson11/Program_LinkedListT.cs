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
//            LinkedList<object> arrAnimal = new LinkedList<object>();
//            arrAnimal.AddLast(new Dog { Name = "Шарик" });
//            arrAnimal.AddAfter(arrAnimal.Last, new Cat { Name = "Кусака" });
//            arrAnimal.AddLast(new Cat { Name = "Ленивец" });
//            arrAnimal.AddLast(new Dog { Name = "Джек" });
//            arrAnimal.AddLast(new Cat { Name = "Черныш" });
//            Dog d = new Dog { Name = "Арчи" };
//            arrAnimal.AddFirst(d);

//            LinkedListNode<object> jack = arrAnimal.AddLast(new Cat { Name = "Джек" });
//            Console.WriteLine(jack.Previous.Value);

//            foreach (Animal a in arrAnimal)
//            {
//                //Вызывает метод Bite у всех объектов в массиве arrAnimal
//                a.Bite();


//                //Вызывает метод Purr только у тех объектов, которые являются экземплярами класса Cat (данный пункт необходимо реализовать 3 способами).

//                ////one
//                //Animal cat = a as Cat;
//                //if (cat != null)
//                //{
//                //    ((Cat)a).Purr();
//                //}

//                ////two
//                //if (a is Cat)
//                //{
//                //    ((Cat)a).Purr();
//                //}

//                ////three
//                //try
//                //{
//                //    ((Cat)a).Purr();
//                //}
//                //catch (InvalidCastException ex)
//                //{
//                //    Console.WriteLine(ex.Message);
//                //}

//            }



//        }
//    }
//}
