using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonType._23
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new
            {
                Name = "Milk",
                Energy = 20
            };
            Console.WriteLine(product);
            var eat = new Eat()
            {
                Name = "Meat"
            };
            var product2 = new
            {
                eat.Name,
                Energy = 250
            };
            Console.WriteLine(product2);
            Console.WriteLine();

            Tuple<int, string> tuple = new Tuple<int, string>(5, "Hello");

            Console.WriteLine(tuple.Item1);
            var tuple2 = (5, "Hello");
            var tuple3 = (Name: "Tomato", Energy: 20);
            Console.WriteLine(tuple3.Energy);
            tuple3.Energy = 60;

            var result = GetData();
            Console.WriteLine(result.Flag);

        }
        public static (int Number, string Name, bool Flag) GetData()
        {
            var number = 7821;
            var name = Guid.NewGuid().ToString();
            bool b = number<500;//checking

            return (number, name, b);
                
        }
    }
}
