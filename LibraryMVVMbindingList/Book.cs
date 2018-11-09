using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVVMbindingList
{
    class Book
    {
        private string _isbn;
        private string _author;
        private string _title;

        public Book(String isbn, string author, string title)
        {
            _author = author;
            _isbn = isbn;
            _title = title;
        }

        public string Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
    }
}
