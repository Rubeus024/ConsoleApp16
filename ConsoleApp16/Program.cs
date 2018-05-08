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
        public static Board gameBoard = new Board(30, 30);   // Board Settings
        public static string keyboardInput;
        public static Cell[,] allCells = GenerateCells();
        public static int populationCounter = 0;

        static void Main(string[] args)
        {
            Invect();
            while (gameFlag)
            {
                Draw(allCells);
                Console.WriteLine(CountPopulation());
                Console.WriteLine("Do you want a next iteration?");
                keyboardInput = Console.ReadLine();
                Console.Clear();
                Update(allCells);



                if (keyboardInput == "n")
                {
                    gameFlag = false;
                }
            }
        }

        private static void Invect()
        {
            Random gen = new Random();
            int x = gen.Next(0, gameBoard.Height - 1);
            int y = gen.Next(0, gameBoard.Width - 1);
            allCells[x, y].IsInvected = true;


        }

        public static void Update(Cell[,] allCells)
        {
            for (int i = 0; i < gameBoard.Height; i++)
            {
                for (int j = 0; j < gameBoard.Width; j++)
                {
                    CheckCellNeighbourhood(i,j,allCells[i,j]);
                }
            }

        }

        private static void CheckCellNeighbourhood(int i, int j, Cell cell)
        {

            int counter = 0;
            //Upper left corner
            if (i == 0 && j == 0)
            {
                if (allCells[i, j + 1].IsAlive)
                { counter++; }
                if (allCells[i + 1, j + 1].IsAlive)
                { counter++; }
                if (allCells[i + 1, j].IsAlive)
                { counter++; }
                isAlive(counter, cell);
            }
            //Upper boundary
            else if (i == 0 && j < gameBoard.Width - 1)
            {
                if (allCells[i, j - 1].IsAlive)
                { counter++; }
                if (allCells[i, j + 1].IsAlive)
                { counter++; }
                if (allCells[i + 1, j - 1].IsAlive)
                { counter++; }
                if (allCells[i + 1, j].IsAlive)
                { counter++; }
                if (allCells[i + 1, j + 1].IsAlive)
                { counter++; }
                isAlive(counter, cell);

            }

            //Upper right corner
            else if (i == 0 && j == gameBoard.Width - 1)
            {
                if (allCells[i, j - 1].IsAlive)
                { counter++; }
                if (allCells[i + 1, j - 1].IsAlive)
                { counter++; }
                if (allCells[i + 1, j].IsAlive)
                { counter++; }
                isAlive(counter, cell);
            }

            //Left boundary
            else if (i < gameBoard.Height - 1 && j == 0)
            {
                if (allCells[i - 1, j].IsAlive)
                { counter++; }
                if (allCells[i - 1, j + 1].IsAlive)
                { counter++; }
                if (allCells[i, j + 1].IsAlive)
                { counter++; }
                if (allCells[i + 1, j + 1].IsAlive)
                { counter++; }
                if (allCells[i + 1, j].IsAlive)
                { counter++; }
                isAlive(counter, cell);

            }

            //Right boundary
            else if (i < gameBoard.Height - 1 && j == gameBoard.Width - 1)
            {
                if (allCells[i - 1, j - 1].IsAlive)
                { counter++; }
                if (allCells[i - 1, j].IsAlive)
                { counter++; }
                if (allCells[i, j - 1].IsAlive)
                { counter++; }
                if (allCells[i + 1, j - 1].IsAlive)
                { counter++; }
                if (allCells[i + 1, j].IsAlive)
                { counter++; }
                isAlive(counter, cell);

            }

            //Lower left corner
            else if (i == gameBoard.Height - 1 && j == 0)
            {
                if (allCells[i - 1, j].IsAlive)
                { counter++; }
                if (allCells[i - 1, j + 1].IsAlive)
                { counter++; }
                if (allCells[i, j + 1].IsAlive)
                { counter++; }
                isAlive(counter, cell);
            }

            //Lower boundary
            else if (i == gameBoard.Height - 1 && j < gameBoard.Width - 1)
            {
                if (allCells[i, j - 1].IsAlive)
                { counter++; }
                if (allCells[i - 1, j - 1].IsAlive)
                { counter++; }
                if (allCells[i - 1, j].IsAlive)
                { counter++; }
                if (allCells[i - 1, j + 1].IsAlive)
                { counter++; }
                if (allCells[i, j + 1].IsAlive)
                { counter++; }
                isAlive(counter, cell);

            }

            //Lower right corner
            else if (i == gameBoard.Height - 1 && j == gameBoard.Width - 1)
            {
                if (allCells[i - 1, j].IsAlive)
                { counter++; }
                if (allCells[i - 1, j - 1].IsAlive)
                { counter++; }
                if (allCells[i, j - 1].IsAlive)
                { counter++; }
                isAlive(counter, cell);
            }

            //Center
            else
            {
                if (allCells[i - 1, j - 1].IsAlive)
                { counter++; }
                if (allCells[i - 1, j].IsAlive)
                { counter++; }
                if (allCells[i - 1, j + 1].IsAlive)
                { counter++; }
                if (allCells[i, j - 1].IsAlive)
                { counter++; }
                if (allCells[i, j + 1].IsAlive)
                { counter++; }
                if (allCells[i + 1, j - 1].IsAlive)
                { counter++; }
                if (allCells[i + 1, j].IsAlive)
                { counter++; }
                if (allCells[i + 1, j + 1].IsAlive)
                { counter++; }
                isAlive(counter, cell);

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
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("-");
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

        public static void isAlive(int counter, Cell cell)
        {
            if((counter == 2 || counter == 3) && cell.IsAlive==true )
            {
                cell.IsAlive = true;
            }
            else
            {
                cell.IsAlive = false;
            }
            if(counter==3 && cell.IsAlive==false)
            {
                cell.IsAlive = true;
            }
            if(counter!=3 && cell.IsAlive == false)
            {
                cell.IsAlive = false;
            }


        }

        private static int CountPopulation()
        {
            populationCounter = 0;
            for (int i = 0; i < gameBoard.Height; i++)
            {
                for (int j = 0; j < gameBoard.Width; j++)
                {

                    if (allCells[i, j].IsAlive)
                    {
                        populationCounter++;
                    }
                }
            }
            return populationCounter;
        }
    }
}



