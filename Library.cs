using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace SistemaBiblioteca
{
    public class Library
    {
        private List<Book> books;
        public Library()
        {
            books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Livro: {book.Title} adicionado a biblioteca.");
        }

        public void RemoveBookByTitle(string title)
        {
            Book bookToRemove = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if(bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine($"Livro {bookToRemove.Title} removido.");
            }else
            {
                Console.WriteLine("Livro não encontrado.");
            }
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

            Console.WriteLine($"Livro {title} não encontrado");
            return null;
        }

        private const string FilePath = "libraryData.json";

        public void SaveToFile()
        {
            string data = JsonSerializer.Serialize(books, new JsonSerializerOptions { WriteIndented = true});
            File.WriteAllText(FilePath, data);
            Console.WriteLine("Dados da biblioteca salvos.");
        }

        public void LoadFromFile()
        {
            if (File.Exists(FilePath))
            {
                string data = File.ReadAllText(FilePath);
                List<Book>? loadedBooks = JsonSerializer.Deserialize<List<Book>>(data);
                books = loadedBooks ?? new List<Book>();
                Console.WriteLine("Dados da biblioteca carregados.");
            }
        }
    }
}