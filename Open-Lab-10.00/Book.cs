using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Open_Lab_10._00
{
    class Book
    {

        private string title;
        private int pages;
        private string cathegory;
        private string author;
        private int releaseDate;

        public Book()
        {
            title = "-1";
            pages = -1;
            cathegory = "-1";
            author = "-1";
            releaseDate = -1;
        }

        public Book(string title, int pages)
        {
            this.title = title;
            this.pages = pages;
            cathegory = "-1";
            author = "-1";
            releaseDate = -1;
        }

        public Book(string title, int pages, string cathegory, string author, int releaseDate)
        {
            this.title = title;
            this.pages = pages;
            this.cathegory = cathegory;
            this.author = author;
            this.releaseDate = releaseDate;

        }



        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public int Pages
        {
            get { return pages; }
            set
            {
                if (value > 0)
                {
                    pages = value;
                }
                else
                {
                    pages = 1;
                }
            }

        }
        public string Cathegory
        {
            get { return cathegory; }
            set { cathegory = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public int ReleaseDate
        {
            get { return releaseDate; }
            set
            {
                if (value >= 1450 && value <= 2021)
                {
                    releaseDate = value;
                }
                else
                {
                    releaseDate = -1;
                }
            }

        }
       





        public override string ToString()
        {
            return $"{this.title}, {this.pages}, {this.cathegory}, {this.author},{this.releaseDate}";
        }








    }
}
