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
        public bool IsAlive { get; set; }
        public bool IsInvected { get; set; } = false;

        public Cell(int xcoordinate,int ycoordinate)
        {
            this.xCoordinate = xcoordinate;
            this.yCoordinate = ycoordinate;
            this.IsAlive = ToRevive();
        }

        private bool ToRevive()
        {
            //Initial population density
            int isAlive = generator.Next(0, 7);
            if (isAlive == 1)
            {
                Program.populationCounter = 1;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
