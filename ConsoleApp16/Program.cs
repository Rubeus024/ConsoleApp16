using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        public static bool gameFlag = true;
        public static Board gameBoard = new Board(20, 10);
        public static string keyboardInput;
        public static Cell[,] allCells = GenerateCells();

        static void Main(string[] args)
        {
            //Cell[,] allCells = GenerateCells();

            while (gameFlag)
            {
                Draw(allCells);
                Update(allCells);

                Console.WriteLine("Do you want a next iteration?");
                keyboardInput = Console.ReadLine();
                Console.Clear();


                if(keyboardInput == "n")
                {
                    gameFlag = false;
                }
            }
        }

        public static void Update(Cell[,] allCells)
        {
            for (int i = 0; i < gameBoard.Height; i++)
            {
                for (int j = 0; j < gameBoard.Width; j++)
                {
                    CheckCellNeighbourhood(i,j,allCells[i,j]);
                }
                //Console.WriteLine();
            }

        }

        private static void CheckCellNeighbourhood(int i, int j, Cell cell)
        {
            if(i==0 && j==0)
            {
                //allCells
            }
        }

        public static void Draw(Cell[,] allCells)
        {
            for(int i = 0;i<gameBoard.Height;i++)
            {
                for(int j = 0;j<gameBoard.Width;j++)
                {

                    if (allCells[i, j].IsAlive)
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static Cell[,]  GenerateCells()
        {

            Cell[,] cells = new Cell[gameBoard.Height, gameBoard.Width];

            for (int i = 0; i < gameBoard.Height; i++)
            {
                for (int j = 0; j < gameBoard.Width; j++)
                {
                    cells[i,j] = new Cell(i,j);
                } 
            }
            return cells;
        }

        public struct Board
        {

                public int Height { get; private set; }
                public int Width { get; private set; }

                public Board(int width, int height)
                {
                    Height = width;
                    Width = height;
                }
        }

        public static void CheckCellProperties(Cell[,] allCells)
        {
            for (int x = 0; x < gameBoard.Height; x++)
            {
                for (int y = 0; y < gameBoard.Width; y++)
                {
                    Console.WriteLine("Is alive?? " + allCells[x, y].IsAlive + " Coordinates  x: " + allCells[x, y].xCoordinate + " y: " + allCells[x, y].yCoordinate);
                }
            }
        }
    }
}



