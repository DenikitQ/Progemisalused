namespace WhileDoTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While Do Triangle");

            //otsida internetist While koodiga kolmnurga
            //kujundeid e tegemise viise
            //2.kui kood on leitud, siis kirjutada see siia
            //3. teha vooskeem

            int rida = 1;

            while (rida <= 5)
            {
                int tyhik = 5;

                while (tyhik > rida)
                {
                    Console.Write(" ");
                    tyhik--;
                }

                int tulp = 1;

                while (tulp <= rida)
                {
                    Console.Write("*");
                    tulp++;
                }

                Console.WriteLine();
                rida++;
            }
        }
    }
}
