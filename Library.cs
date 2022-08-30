using System;
using LibraryHomeWork;

namespace LibraryHomeWork
{
    internal class Library
    {
        public string LibraryName { get; }
        public List<Book> Books { get; }
        public Library(string libraryName)
        {
            LibraryName = libraryName;
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"Book {book.Title} added successfully ");
        }

        public void AddBook(Book[] books)
        {
            foreach (var book in books)
            {
                Books.Add(book);
            }
            Console.WriteLine($"Total added: {books.Length} books! ");
        }

        public void ShowBooks()
        {
            Console.WriteLine("Book info: ");
            foreach (Book book in Books)
            {
                Console.WriteLine($"\t\t Title: {book.Title}\n \t\t Author: {book.Author}\n \t\t Description: {book.Description}\n \t\t Publication Date: {book.PublicationDate}\n \t\t ISBN: {book.ISBN}");
                Console.WriteLine();
            }
        }
    }
}