using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RMS.BL;
using RMS.DL;

namespace BusinessAppConsole.UI
{
    public class ConsoleUtility
    {
        private static char[,] Header = new char[,]
        {
           { ' ','_','_','_','_',' ','_','_','_','_',' ',' ',' ','_','_','_','_',' ',' ' },
           { '/',' ','_','_','_','/',' ','_','_','_','|',' ','/',' ','_','_','_','|',' ' },
           { '\\','_','_','_',' ','\\','_','_','_',' ','\\','|',' ','|',' ',' ',' ',' ',' '},
           { ' ','_','_','_',')',' ','|','_','_',')',' ','|',' ','|','_','_','_',' ',' '},
           { '|','_','_','_','_','/','_','_','_','_','/',' ','\\','_','_','_','_','|',' '}
        };

        public static int Homepage()
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Blue ;
            Console.WriteLine("\n\t\t\t\t\t\t\tSign In");
            Console.WriteLine("\t\t\t\t\t\t\tSign Up");
            Console.WriteLine("\t\t\t\t\t\t\tExit");
            Console.ResetColor();
            return MovementOfArrow(53, 7, 1, 3);
        }

        public static int MovementOfArrow(int x, int y, int minOption, int maxOption)
        {
            ConsoleKeyInfo key;
            Console.ForegroundColor = ConsoleColor.Magenta;
            do
            {
                Console.SetCursorPosition(x, y);
                Console.Write("->");

                key = Console.ReadKey(true);

                Console.SetCursorPosition(x, y);
                Console.Write("  ");

                if (key.Key == ConsoleKey.UpArrow && minOption > 1)
                {
                    minOption--;
                    y--;
                }
                else if (key.Key == ConsoleKey.DownArrow && minOption < maxOption)
                {
                    minOption++;
                    y++;
                }
                Console.SetCursorPosition(x, y);
                Console.Write("->");
            } while (key.Key != ConsoleKey.Enter);
            Console.ResetColor();
            return minOption;
        }

        public static void PrintHeader()
        {
            int x = 55, y = 1;
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < Header.GetLength(0); i++)
            {
                Console.SetCursorPosition(x,y); 
                for (int j = 0; j < Header.GetLength(1); j++)
                {
                    Console.Write(Header[i, j]);
                }
                y++;
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        public static void ClearScreen()
        {
            Console.Clear();
            PrintHeader();
        }

        public static void LoadingFunction()
        {
            int x = 18, y = 3;
            char box = '\u2588';

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(x + 22, y + 18);
            Console.Write( "Loading...");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(x+1, y + 20);
            Console.Write(box);

            for (int i = 0; i < 70; i++)
            {
                Thread.Sleep(20);
                x++;
                Console.SetCursorPosition(x+1, y + 20);
                Console.Write(box);
            }
            Console.ResetColor();
        }
    }
}
