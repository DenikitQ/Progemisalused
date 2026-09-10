namespace IfAndElse
{
    //Projekt nimetusega IfAndElse, mille sees asub class nimega programm.
    //See klass sisaldab Main meetodit
    //mis on programmi sisenemispunkt
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta enda nimi");

            //muutuja nimega name, kuhu salvestatakse kasutaja sisestatud tekst

            string name = Console.ReadLine();

            //! tähendab "ei ole" ja == tähendab "on võrdne"
            if (name != "")

                //Kui kasutaja sisestab midagi, siis muudetakse taustavärvi
                Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Sisestasid enda nime");
            Console.WriteLine(name);          

           Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("ERROR. Nime ei sisestanud");
            //Kui kasutaja ei sisesta midagi, siis kostub 2 piiksu      
            Console.Beep();
            // ja oodetakse 1 sekund enne programmi lõppu
            Thread.Sleep(1000);
            Console.Beep();
        }
        }
    }

