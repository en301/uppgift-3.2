using System;

namespace uppgift_3_2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet? Svara j för ja och n för nej...");
            string gymnasie = Console.ReadLine();
            Console.WriteLine("Hur gammal är du?");
            string siffra = Console.ReadLine();
            int ålder = int.Parse(siffra);

            if (ålder < 22 && gymnasie == "j")
            {
                Console.WriteLine("Vi vill gärna anställa dig");
            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter andra");
            }
            Console.ReadKey();
        }
    }
}
