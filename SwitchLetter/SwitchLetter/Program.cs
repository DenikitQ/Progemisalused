namespace SwitchLetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meetodi valimine");
            //Tee kolm meetodit, mis teevad järgi
            //esimene ütleb "auh"
            //teine ütleb, et tahan magada
            //kolmas ütleb, et tahab õppida
            //Need tuleb esile kutsuda numbri valikuga
            //Tuleb kasutada Switchi
            //Tuleb teha menüü, kus kasutaja saab valida, millist
            //meetodit ta tahab esile kutsuda
            Console.WriteLine("1 - Auh");
            Console.WriteLine("2 - Tahan magada");
            Console.WriteLine("3 - Tahan õppida");

            Console.Write("Sisesta valik: ");
            int valik = int.Parse(Console.ReadLine());

            switch (valik)
            {
                case 1:
                    Auh(); 
                    break;

                case 2:
                    Sleep(); 
                    break;

                case 3:
                    Study(); 
                    break;

                default:
                    Console.WriteLine("Sellist valikut ei ole!");
                    break;
           
        }
        static void Auh()
        {
            Console.WriteLine("Auh!");
        }
        static void Sleep()
        {
            Console.WriteLine("Ma tahan magada.");
        }
        static void Study()
        {
            Console.WriteLine("Ma tahan õppida.");
        }
        }
    }
}


