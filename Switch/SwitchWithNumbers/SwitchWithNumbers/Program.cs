namespace SwitchWithNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");

            int number = int.Parse(Console.ReadLine());
            //Teie töö on teha switch rakendus,
            //kus on kolm case

            switch (number)
            {
                case 1:
                    Console.WriteLine("Sisestasid numbri 1");
                    break;
                case 2:
                    Console.WriteLine("Sisestasid numbri 2");
                    break;
                default:
                    Console.WriteLine("Sisestasid mõnda muud numbri");
                    break;
            }
        }
    }
} 
