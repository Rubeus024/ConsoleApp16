using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static Vector vector1;
        static void Main(string[] args)
        {
            vector1.x = 30;
            Vector.y = 40;
                Console.WriteLine($"vector1 {vector1.x}");
       
        }
    }
}


class Vector
{
    public  int x = 3;
    public static int y = 4;
}