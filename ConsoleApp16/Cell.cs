using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Cell
    {
        public static Random generator = new Random();
        public int xCoordinate { get; private set; }
        public int yCoordinate { get; private set; }
        public bool IsAlive { get; private set; }

        public Cell(int xcoordinate,int ycoordinate)
        {
            this.xCoordinate = xcoordinate;
            this.yCoordinate = ycoordinate;
            this.IsAlive = ToRevive();
        }

        private bool ToRevive()
        {
            int isAlive = generator.Next(0, 2);
            //Console.WriteLine(isAlive);
            return isAlive==1 ? true : false;
        }
    }
}
