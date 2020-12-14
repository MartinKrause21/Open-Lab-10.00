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
            Console.WriteLine(LOTR.ToString());

            Console.WriteLine();

            Book LOTR2 = new Book();
            Console.WriteLine(LOTR2.ToString());

            Console.WriteLine();

            Book LOTR3 = new Book("Programovanie v HTML", 310 );
            Console.WriteLine(LOTR3.ToString());

            Console.WriteLine();

            Book HOBIT = new Book("scifi", 2010, "J.G.T", "Dobra kniha", 120 );
            Console.WriteLine(HOBIT.ToString());

            Console.WriteLine();
                       

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(Book.categoryList[i]);
            }
            


        }
    }
}
