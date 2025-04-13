using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {

        static void Main(string[] args)
        {
            sadman border = new sadman(60,20);
            sadman position = new sadman(20, 5);
            Random r = new Random();
            sadman snackforsnake = new sadman(r.Next(1, border.X-1), r.Next(1, border.Y-1));
            int delayPerMilli = 1;
            lessgo moveDir = lessgo.down;

            List<sadman> poshis = new List<sadman>();
            int TailLength = 1;


            while (true)
            {
                Console.Clear();
                position.Applydir(moveDir);




                for (int y = 0; y<border.Y; y++)
                {
                    for (int x = 0; x<border.X; x++)
                    {
                        sadman Csadman = new sadman(x, y);

                        if (position.Equals(Csadman))
                        {
                            Console.Write("DDDD");
                        }
                        else if (snackforsnake.Equals(Csadman)||poshis.Contains(Csadman))
                        {
                            Console.Write("a");
                        }
                        else if (x==0||y==0||x==border.X-1||y==border.Y-1)
                        {
                            Console.Write("|");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }

                if (poshis.Equals(snackforsnake))
                {
                    TailLength++;
                    snackforsnake = new sadman(r.Next(1, border.X-1), r.Next(1, border.Y-1));
                }

                poshis.Add(new sadman(position.X, position.Y));

                if (poshis.Count>TailLength)
                    poshis.RemoveAt(0);





                DateTime time = DateTime.Now;
                while((DateTime.Now - time).Milliseconds < delayPerMilli)
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKey key = Console.ReadKey().Key;

                        switch (key)
                        {
                            case ConsoleKey.LeftArrow:
                                moveDir = lessgo.left;
                                break;
                            case ConsoleKey.RightArrow:
                                moveDir = lessgo.right;
                                break;
                            case ConsoleKey.UpArrow:
                                moveDir = lessgo.up;
                                break;
                            case ConsoleKey.DownArrow:
                                moveDir = lessgo.down;
                                break;
                        }
                    }
                }
            }
        }
    }
}
