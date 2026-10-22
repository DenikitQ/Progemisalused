namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number");
            float arv1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta teine number");
            float arv2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Kasuta tingmärki *, /, +, -");
            //nüüd tuleb teha switchi valik, kas *, /, +, -
            //tuleb teha neli case,kus toimub soovitud tehe
            //peab näitama tehte tulemust
            //kasutage floati Parsimisel

            string tehe = Console.ReadLine();

            switch (tehe)
            {
                case "+":
                    Console.WriteLine("Vastus: " + (arv1 + arv2));
                    break;

                case "-":
                    Console.WriteLine("Vastus: " + (arv1 - arv2));
                    break;

                case "*":
                    Console.WriteLine("Vastus: " + (arv1 * arv2));
                    break;

                case "/":
                    if (arv2 != 0)
                    {
                        Console.WriteLine("Vastus: " + (arv1 / arv2));
                    }
                    else
                    {
                        Console.WriteLine("Nulliga jagada ei saa!");
                    }
                    break;

                default:
                    Console.WriteLine("Tundmatu tehe");
                    break;
            }
        }
    }
}
