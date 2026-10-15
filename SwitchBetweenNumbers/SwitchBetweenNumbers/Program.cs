namespace SwitchBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta arv");
            //esimese koondtulemuse puhul on number vahemikus
            //0 kuni 100
            //Teise puhul 101 kuni 200 ja
            //kolmanda puhul 201 kuni 300
            //kasuta switchi

            int arv = int.Parse(Console.ReadLine());

            switch (arv)
            {
                case >= 0 and <= 100:
                    Console.WriteLine("Arv on vahemikus 0 kuni 100");
                    break;

                case >= 101 and <= 200:
                    Console.WriteLine("Arv on vahemikus 101 kuni 200");
                    break;

                case >= 201 and <= 300:
                    Console.WriteLine("Arv on vahemikus 201 kuni 300");
                    break;

                default:
                    Console.WriteLine("Arv ei kuulu vahemikku 0 kuni 300");
                    break;
            }
        }
    }
}
