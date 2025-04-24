using System;

namespace SistemaBiblioteca
{
    class Program
    {
        static void Main(strings[] args)
        {
            Library library = new Library();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n===== Sistema da biblioteca =====");
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("1 - Adicionar livro");
                Console.WriteLine("2 - Ver livros");
                Console.WriteLine("3 - Emprestar livro");
                Console.WriteLine("4 - Devolver livro");
                Console.WriteLine("5 - Fechar");

                string? option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Titulo: ");
                        string title = Console.ReadLine()!;
                        Console.Write("Autor: ");
                        string author = Console.ReadLine()!;
                        Console.Write("Ano de publicação: ");
                        int year = int.Parse(Console.ReadLine()!);
                        Book newBook = new Book(title, author, year);
                        library.AddBook(newBook);
                        break;

                    case "2":
                        library.ListBooks();
                        break;

                    case "3":
                        Console.Write("Qual livro deseja emprestar? ");
                        string borrowTitle = Console.ReadLine()!;
                        Book? bookToBorrow = library.FindBookByTitle(borrowTitle);
                        bookToBorrow?.Borrow();
                        break;

                    case "4":
                        Console.Write("Qual livro deseja devolver? ");
                        string returnTitle = Console.ReadLine()!;
                        Book? bookToReturn = library.FindBookByTitle(returnTitle);
                        bookToReturn?.Return();
                        break;

                    case "5":
                        running = false;
                        Console.WriteLine("Fechando sistema, até logo...");
                        break;

                    default:
                        Console.WriteLine("Opcão inválida.");
                        break;
            }
        }
    }
}
