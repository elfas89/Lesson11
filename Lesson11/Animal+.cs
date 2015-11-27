using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public abstract void Bite();
    }

    public class Dog : Animal
    {
        public override void Bite()
        {
            Console.WriteLine("Собака {0} кусает", Name);
        }
    }

    public class Cat : Animal
    {
        public override void Bite()
        {
            Console.WriteLine("Кошка {0} кусает", Name);
        }
        public void Purr()
        {
            Console.WriteLine("Кошка {0} мурчит", Name);
        }
    }

}
