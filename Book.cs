using System;

namespace SistemaBiblioteca
{
    public class Book
    {
        public string Title {get;set;}
        public string Author {get;set;}
        public int PublicationYear {get;set;}
        public bool IsAvailable {get; private set;}

        public Book(string title, string author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            IsAvailable = true;
        }

        public void Borrow()
        {
            if(IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"Livro:{Title} emprestado com sucesso!");
            }
            else{
                Console.WriteLine($"Erro! O livro:{Title} já está emprestado");
            }
        }

        public void Return()
        {
            if(!IsAvailable)
            {
                IsAvailable = true;
                Console.WriteLine($"Livro:{Title} devolvido com sucesso!");
            }else
            {
                Console.WriteLine($"Erro! O livro:{Title} não foi emprestado");
            }
        }

        public void DisplayInfo()
        {
            string status = IsAvailable ? "Available" : "Borrowed";
            Console.WriteLine($"Titulo: {Title} | Autor: {Author} | Ano de publicação: {PublicationYear} | Status: {status}");

        }
    }
}