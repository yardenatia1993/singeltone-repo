using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    internal class Book
    {
        public string serialKey { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string genre { get; set; }
        public int chapters { get; set; }
        public int pages { get; set; }
        public Book(string serialKey, string title, string author, string genre, int chapters, int pages)
        {
            this.serialKey = serialKey;
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.chapters = chapters;
            this.pages = pages;
        }
        public override string ToString()
        {
            return @$"book details:
{serialKey}: serialKey
{title}: title
{author}: author 
{genre}: genre
{chapters}: chapters 
{pages}: pages";
        }
    }
}
