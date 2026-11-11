namespace ForLoopEndless
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //teha siis for loopiga lõputu tsükkel, 
            //mis prindib konsooli: i väärtus on: number
            //kui i väärtus on 10, siis tsükkel lõpeb
            short i = 1;

            for (; ; )
            {
                Console.WriteLine("i väärtus on:"+ i);
                i++;

                if (i > 2)
                    break;
            }
        }
    }
}
