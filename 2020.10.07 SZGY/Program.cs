using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020._10._07_SZGY
{
    class Program
    {
        static int[] tomb = new int[100];
        static Random rmd = new Random();
        static void Main(string[] args)
        {
            feltolt();
            kiir();            

            for (int i = 0; i < 200; i++)
            {
                Randomszin();
                RandomHelyreIr();
            }
            Console.ReadKey();
            
        }
        static void feltolt()
        {
            
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rmd.Next(10,100);
                
            }
        }
        static void kiir()
        {

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(" " + tomb[i]);
                if ((i+1)%10==0)
                {
                    Console.WriteLine("");
                }
                

            }
        }
        static void RandomHelyreIr()
        {
            Console.SetCursorPosition(
                rmd.Next(Console.WindowWidth),
                rmd.Next(Console.WindowHeight));
            Console.Write("*");

        }
        static void Randomszin()
        {
            ConsoleColor[] szinek =
                {
            ConsoleColor.Red,
            ConsoleColor.Green,
            ConsoleColor.Yellow,
            ConsoleColor.Magenta,
            ConsoleColor.Cyan

            };
            Console.ForegroundColor = szinek[rmd.Next(szinek.Length)];
                
                
        }
        
        }
        
    }


