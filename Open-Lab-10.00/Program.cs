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
           


        }
    }
}
