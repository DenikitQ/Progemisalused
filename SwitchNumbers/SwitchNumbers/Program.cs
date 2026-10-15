namespace SwitchNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta arv 10, 20 või 30");
            //tuleb tea siis switch, kus esimene case on 10, teine on 20 
            //ja kolmas on 30

            int arv = Convert.ToInt32(Console.ReadLine());

            switch (arv)
            {
                case 10:
                    Console.WriteLine("Sisestasid arvu 10");
                    break;

                case 20:
                    Console.WriteLine("Sisestasid arvu 20");
                    break;

                case 30:
                    Console.WriteLine("Sisestasid arvu 30");
                    break;

                default:
                    Console.WriteLine("Tundmatu number");
                    break;

            }
        }
    }
}
