using System;
using System.Dynamic;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.Title = "Mato sa uci";
            LOTR.Pages = 200;
            LOTR.Cathegory = "roman";
            LOTR.Author = "mirko";
            LOTR.ReleaseDate = 2021;

            Book LOTR2 = new Book();
            Console.WriteLine(LOTR2.Cathegory);
            Console.WriteLine(LOTR2.Author);
            Console.WriteLine(LOTR2.ReleaseDate);
            Console.WriteLine(LOTR2.Title);
            Console.WriteLine(LOTR2.Pages);

            Console.WriteLine();

            Book LOTR3 = new Book("Programovanie v HTML", 310 );
            Console.WriteLine(LOTR3.Cathegory);
            Console.WriteLine(LOTR3.Author);
            Console.WriteLine(LOTR3.ReleaseDate);
            Console.WriteLine(LOTR3.Title);
            Console.WriteLine(LOTR3.Pages);

            Console.WriteLine();

            Book HOBIT = new Book("scifi", 2010, "J.G.T", "Dobra kniha", 120 );
            Console.WriteLine(HOBIT.Cathegory);
            Console.WriteLine(HOBIT.Author);
            Console.WriteLine(HOBIT.ReleaseDate);
            Console.WriteLine(HOBIT.Title);
            Console.WriteLine(HOBIT.Pages);

            Console.WriteLine();

            Console.WriteLine(LOTR.ToString());



        }
    }
}
