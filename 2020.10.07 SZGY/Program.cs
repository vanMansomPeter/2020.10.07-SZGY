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
        static char[] inf = "INFORMATIKA".ToCharArray();
        static void Main(string[] args)
        {


            //feltolt();
            //kiir();

            //for (int i = 0; i < 200; i++)
            //{
            //    Randomszin();
            //    RandomHelyreIr();
            //}
           
            Console.WriteLine(RandomJelszo());
            Kever();
            Console.WriteLine(new String(inf));

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

            Console.ForegroundColor =(ConsoleColor) rmd.Next(10,16);
                
                
        }
        
        static char RandomChar() => (char)rmd.Next(65, 91);
       
        static string RandomJelszo()
        {
            string pw = "";
            for (int i = 0; i < 6; i++)
            {
                pw += RandomChar();               
            }
            return pw;
        }

        static void Kever()
        {
            for (int i = 0; i < inf.Length/2; i++)
            {
                int x = rmd.Next(inf.Length);
                int y = rmd.Next(inf.Length);
                char s = inf[x];
                inf[x] = inf[y];
                inf[y]=s;
            }
        }

    }
        
    }


