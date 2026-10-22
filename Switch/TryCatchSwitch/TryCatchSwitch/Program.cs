namespace TryCatchSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try catch Switch");

            try
            {
                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        Console.WriteLine("Valisid 1");
                        break;

                    case 2:
                        Console.WriteLine("Valisid 2");
                        break;
                }
            }
            //vormi viga
            catch (FormatException)
            {
                Console.WriteLine("Palun siseta number");
                
            }
            //Kui number on suurem, kui int 32 biti
            catch (OverflowException)
            {
                Console.WriteLine("Number on liiga suur");

            }
        }
    }
}
