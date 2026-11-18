namespace MultiplecationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Korrutustabel");
            Console.WriteLine("Sisesta tabelisse number, mis on viimane korrutis");

            int j, i, n;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Korrtustabel ühest kuni 0" , n);
            //kaks for loopi ja üks on teise sees

            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    Console.Write($"{j}x{i} = {j * i}, ");
                }
                Console.WriteLine();
            }
        }
    }
}
