using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Halo Welt!");
            Square s1 = new Square(5);
            s1.Description();
            Console.WriteLine(s1.Dana);
            Console.ReadKey();
        }


    }

    class Rectangle
    {
        private int x;
        private int y;
        public int Dana { get; set; } = 2;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Rectangle(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public virtual void Description()
        {
            Console.WriteLine($"x length: {this.X}, y length: {this.Y}");
        }
    }

    class Square : Rectangle
    {
        public Square(int x) : base(x, x)
        {

        }
    }
}
