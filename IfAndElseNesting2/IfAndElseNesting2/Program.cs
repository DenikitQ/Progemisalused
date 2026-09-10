namespace IfAndElseNesting2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teha üks if ja else nestimine iseseisvalt");
            Console.WriteLine("Teise else If-i sisse panna if ja esle nestimine");

            int number = 18;
            if (number >= 21)
            {
                Console.WriteLine("Oled täisealine.");

                if (number >= 21)
                {
                    Console.WriteLine("Oled vähemalt 21 aastat vana.");
                }
                else
                {
                    Console.WriteLine("Oled alla 21 aasta vana.");
                }
            }
            else
            {
                Console.WriteLine("Oled alaealine.");
            }


            Console.WriteLine("Teise else If-i sisse panna if ja else nestimine");

            int hinne = 4;

            if (hinne == 5)
            {
                Console.WriteLine("Väga hea!");
            }
            else if (hinne == 4)
            {
                Console.WriteLine("Hea hinne.");

                if (hinne >= 4)
                {
                    Console.WriteLine("Õpilane sai vähemalt 4.");
                }
                else
                {
                    Console.WriteLine("Õpilane sai alla 4.");
                }
            }
            else
            {
                Console.WriteLine("Võiks paremini.");
            }
        }
    }
}






