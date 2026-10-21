using System;
namespace uppgift4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en sträng:");
            string text = Console.ReadLine();

            Console.WriteLine("Skriv in exakt två tecken:");
            string tecken = Console.ReadLine();

            bool finns1 = false;
            bool finns2 = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == tecken[0])
                {
                    finns1 = true;
                }

                if (text[i] == tecken[1])
                {
                    finns2 = true;
                }
            }

            if (finns1 && finns2)
            {
                Console.WriteLine("Båda tecknen finns i strängen.");
            }
            else
            {
                Console.WriteLine("Båda tecknen finns inte i strängen.");
            }
        }
    }
}

