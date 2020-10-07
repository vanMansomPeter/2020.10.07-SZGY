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

        static void Main(string[] args)
        {
            feltolt();
            kiir();
            Console.ReadLine();
            
        }
        static void feltolt()
        {
            
            Random rmd = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rmd.Next(10,100);
                Console.WriteLine(tomb[i]);
            }
        }
        static void kiir()
        {

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);

            }
        }
        
        }
        
    }
}
