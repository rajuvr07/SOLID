using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PrincipleLS.WothOutLS;

namespace PrincipleLS
{
    class Program
    {
        //https://dotnettutorials.net/lesson/dependency-inversion-principle/
        static void Main(string[] args)
        {
            AppleWithoutLS apple = new OrangeWithoutLS();
            Console.WriteLine(apple.GetColor());

            Fruit fruit = new Orange();
            Console.WriteLine(fruit.GetColor());
            fruit = new Apple();
            Console.WriteLine(fruit.GetColor());
        }
    }
}
