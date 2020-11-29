using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
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

      
        public void SetTitle(string titles)
        {
            title = titles;
        }

        public void SetPages( int page)
        {
            pages = page;
        }

        public void SetCathegory (string cathegor)
        {
            cathegory = cathegor;
        }

        public void SetAutor (string name)
        {
            author = name;
        }

        public void SetRlsDate (int rlsdate)
        {
            releaseDate = rlsdate;
        }


        public override string ToString()
        {
            return $"{this.title}, {this.pages}, {this.cathegory}, {this.author},{this.releaseDate}";
        }








    }
}
