using System.ComponentModel.Design;

namespace ForKillKoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta numbri, kui palju see kordab");
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
            //iga kord, kui hakkab väljundit kordama, siis näitab reanubrit
            int kordab = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kordab; i++)
            {
                Console.WriteLine("See on rida nr [0]", i);
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
                
               
            
        
    

