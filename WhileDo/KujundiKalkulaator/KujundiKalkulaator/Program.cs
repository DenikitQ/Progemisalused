using System.Threading.Channels;

namespace KujundiKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Ruudu sees asub ring. Ringi raadius on 3 ühikut.
            //Leia ja väljasta kraanile ruudu pindala ja ümbermõõt

            int roundRadius = 3;
            int diameter = roundRadius * 2;
            //ruudu pindala on a*a

            int pindala = diameter * diameter;
            int ümbermõõt = 4 * diameter;

            Console.WriteLine("Ruudu pindala on:" + pindala);
            Console.WriteLine("Ruudu ümbermõõt on:" + ümbermõõt);

            //arvuta siis ringi pindala ja ümbermõõt

            double roundarea = Math.PI  * (roundRadius * roundRadius);
            double roundPerimeter = 2 * Math.PI * roundRadius;

            Console.WriteLine("Ringi pindala on:" + roundarea);
            Console.WriteLine("Ringi ümbermõõt on:" + roundPerimeter);
        }   
    }
}