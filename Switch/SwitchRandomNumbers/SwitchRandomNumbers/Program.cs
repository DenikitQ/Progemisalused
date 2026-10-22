namespace SwitchRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Täringu viskamise mäng");

            //Random genereerib iga kord suvalise nr 1-6-ni
            int cube = new Random().Next(1, 6);

            //kasuta switchi ja iga juhtum tuleb ära printida,
            //mis number tuli
            switch (cube)
            {
                case 1:
                    Console.WriteLine("Viskasid 1");
                    break;

                case 2:
                    Console.WriteLine("Viskasid 2");
                    break;

                case 3:
                    Console.WriteLine("Viskasid 3");
                    break;

                case 4:
                    Console.WriteLine("Viskasid 4");
                    break;

                case 5:
                    Console.WriteLine("Viskasid 5");
                    break;

                case 6:
                    Console.WriteLine("Viskasid 6");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}
