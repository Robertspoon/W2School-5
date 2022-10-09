using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace W2School_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays

            string[] peopleIDontReallyLike = { "YOU", "MYSELF", "SIMON COWELL"};
            //peopleIDontReallyLike[2] = "I really dont like Simon Cowell";
            Console.WriteLine("People I dont reallyt like");
            //for (int i = 0; i < peopleIDontReallyLike.Length; i++)
            // {
            // Console.WriteLine(peopleIDontReallyLike[i]);
            // }
            Array.Sort(peopleIDontReallyLike);
           foreach (string i in peopleIDontReallyLike)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            int[] numbersMate = { 9, 727, 54, 102 };
            Array.Sort(numbersMate);
            Console.WriteLine("I AM SORTING NUMBERS YAY");
            foreach (int i in numbersMate)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            RichMinion();

            Console.ReadKey(true);


        }

        static void RichMinion()
        {
            Console.WriteLine("I will steal the moon just like Gru");
            Console.WriteLine("I count money!");
            Console.WriteLine("I LOVE YEAT");
        }

    }
}
