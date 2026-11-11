using System.ComponentModel.Design;

namespace ForKillKoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //eelnevaid teadmisi kasutades kirjuta programm, mis väljastaks:
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
          
            //for loopi sees peab olema for loop
            //peab saama sisestada arvu, mitu korda soovib väljundit korrata

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Kill - koll");
                    {
                        Console.WriteLine("Killadi - koll");
                    }

                    }
                }
            }
        }
    }
