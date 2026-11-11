using System.Reflection.Metadata;

namespace ForAsterisk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");

            //tuleb kasutada for loopi
            //sisestan konsooli ridade arvu ja prindib vastavalt ridade arvule tärne

            int rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= rows; i++)
            {
                Console.WriteLine("*");
                Thread.Sleep(1000);
            }
        }
    }
}
