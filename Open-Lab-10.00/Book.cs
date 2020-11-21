using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Open_Lab_10._00
{
    class Book
    {
        public override string ToString()
        {
            return $"{this.Title}, {this.Pages}, {this.Cathegory}, {this.Author},{this.ReleaseDate}";
        }

        public Book(string title, int pages, string cathegory, string author, int releaseDate)
        {
            Title = title;
            Pages = pages;   
            Cathegory = cathegory;
            Author = author;
            ReleaseDate = releaseDate;
                        
        }


        private string Title;
        private int Pages;       
        private string Cathegory;
        private string Author;
        public int ReleaseDate;

        

    






    }
}
