using System;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
           LOTR.SetTitle("Mato sa uci");
           LOTR.SetPages(2000);
           LOTR.SetCathegory("roman");
           LOTR.SetAutor("J.G.T");
           LOTR.SetRlsDate(2020);


            Console.WriteLine(LOTR.ToString());
           


        }
    }
}
