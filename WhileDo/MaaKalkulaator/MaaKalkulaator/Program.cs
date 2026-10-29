namespace MaaKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Meil on münt, mille diameeter on 25.75 mm
            //Arvutada välja Maa ümbermõõt ja mitu münti
            //Mahub järjestikku ümber Maa
            //Arvutuses tohib kasutada ainult mündi diameetrit ja Maa raadiust

            double coinDiameter = 25.75; //mm
            double earthRadius = 6378000000;

            double earthCircumference = 2 * Math.PI * earthRadius;
            double coinDiameterMeters = coinDiameter / 25.75;

            double coins = earthCircumference / coinDiameterMeters;

            Console.WriteLine("Münte mahtub ümber Maa:" + Math.Round(coins));
        }
    }
}
