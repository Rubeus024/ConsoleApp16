using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Cell
    {

        private bool _isalive;
        public static Random generator = new Random();
        public int xCoordinate { get; private set; }
        public int yCoordinate { get; private set; }
        public bool IsAlive { get => _isalive; set =>_isalive=value; }
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
            return isAlive==1 ? true : false;
        }
    }

    class HealthyCell : Cell, IDrawCell
    {


        public HealthyCell(int xcoordinate, int ycoordinate) : base(xcoordinate,ycoordinate)
        {
            
        }

        public void Draw()
        {
            Console.Write("X");
        }
    }

    class InvectedCell : Cell, IDrawCell
    {


        public InvectedCell(int xcoordinate, int ycoordinate) : base(xcoordinate, ycoordinate)
        {

        }

        public void Draw()
        {
            Console.Write("O");
        }
    }
}
