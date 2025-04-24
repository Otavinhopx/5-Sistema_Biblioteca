using System;
using System.Collections.Generic;

namespace SistemaBiblioteca
{
    public class Library
    {
        private List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.Writeline($"Livro: {book.Title} adicionado a biblioteca.");
        }

        public void ListBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("Não há livros na biblioteca");
                return;
            }

            Console.WriteLine("Books in the library");
            foreach(var book in books)
            {
                book.DisplayInfo();
            }
        }

        public Book? FindBookByTitle(string title)
        {
            foreach(var book in books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    return book;
                }
            }

            Console.WriteLine($"Livro "{title}" não encontrado");
            return null;
        }
    }
}