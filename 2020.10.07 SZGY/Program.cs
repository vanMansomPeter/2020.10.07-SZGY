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
            Console.ReadKey();
            RandomHelyreIr();
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
            int x = rmd.Next(0,10);
            int y = rmd.Next(0,10);
            Console.SetCursorPosition(x,y);
            Console.Write("*");

        }
        
        }
        
    }


