/*Kymishbaeva sofia
 * 220 P 
 * Chess_figure
 */

using System;

namespace chess_figure
{
    class Program
    {
        static void Main(string[] args)
        {

            string pieceCode = Console.ReadLine();
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Figure fig; //= new Figure(1, 1);
            bool isRightMove = false;

            switch (pieceCode)
            {
                case "K":
                    fig = new King(x1, y1);
                    break;
                case "Q":
                    fig = new Queen(x1, y1);
                    break;
                case "B":
                    fig = new Bishop(x1, y1);
                    break;
                case "N":
                    fig = new Knight(x1, y1);
                    break;
                case "R":
                    fig = new Rook(x1, y1);
                    break;

                default:
                    Console.WriteLine("Unknown piece code. Try again.");
                    fig = null;
                    break;
            }

            isRightMove = fig.Move(x2, y2);
            Console.WriteLine(isRightMove ? "YES" : "NO");
        }
    }
    class Figure
    {
        protected int x1;
        protected int y1;

        public Figure(int newX, int newY)
        {
            x1 = newX;
            y1 = newY;
        }

        public virtual bool Move(int newX, int newY)
        {

            return false;
        }
    }

    class Rook : Figure
    {
        public Rook(int x1, int y1) : base(x1, y1)
        {
        }

        public override bool Move(int x2, int y2)
        {
            return (x1 == x2 || y1 == y2);
        }
    }
    class King : Figure
    {
        public King(int x1, int y1) : base(x1, y1)
        {
        }

        public override bool Move(int x2, int y2)
        {
            return (Math.Abs(x1 - x2) <= 1 && Math.Abs(y1 - y2) <= 1);
        }
    }
    class Queen : Figure
    {
        public Queen(int x1, int y1) : base(x1, y1)
        {
        }
        public override bool Move(int x2, int y2)
        {
            return (x1 == x2 || y1 == y2 ||
                 Math.Abs(x1 - x2) == Math.Abs(y1 - y2));
        }
    }
    class Bishop : Figure
    {
        public Bishop(int x1, int y1) : base(x1, y1)
        {
        }
        public override bool Move(int x2, int y2)
        {
            return (Math.Abs(x1 - x2) == Math.Abs(y1 - y2));
        }
    }
    class Knight : Figure
    {
        public Knight(int x1, int y1) : base(x1, y1)
        {
        }
        public override bool Move(int x2, int y2)
        {
            return ((Math.Abs(x1 - x2) == 2 && Math.Abs(y1 - y2) == 1) ||
            (Math.Abs(x1 - x2) == 1 && Math.Abs(y1 - y2) == 2));
        }
    }
}
