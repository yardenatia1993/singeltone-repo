using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    sealed class Library
    {
        private static Library instance;
        private Stack<Book> books;
        public string name { get; set; }
        public string address { get; set; }

        private Library(string name, string address)
        {
            this.name = name;
            this.address = address;
            books = new Stack<Book>();
        }

        public static Library GetInstance()
        {
            if (instance == null)
            {
                instance = new Library("tzomet-sfarim","Netania");
            }
            return instance;
        }
        public Stack<Book> GetBooks()
        {
            return books;
        }
        public void AddBook(Book newBook)
        {
            books.Push(newBook);
        }
        public void RemoveBook(string serialNum)
        {
            while (books!=null)
            {
                if (books.Pop().serialKey == serialNum)
                {
                    
                }
            }
        }
        public override string ToString()
        {
            return $@"TODO 
print all the books";
        }
    }
}
