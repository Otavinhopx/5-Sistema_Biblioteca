using System;

namespace SistemaBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.LoadFromFile();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n===== Sistema da biblioteca =====");
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("1 - Adicionar livro");
                Console.WriteLine("2 - Ver livros");
                Console.WriteLine("3 - Emprestar livro");
                Console.WriteLine("4 - Devolver livro");
                Console.WriteLine("5 - Remover livro");
                Console.WriteLine("6 - Fechar sistema");

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
                        library.SaveToFile();
                        break;

                    case "2":
                        library.ListBooks();
                        break;

                    case "3":
                        Console.Write("Qual livro deseja emprestar? ");
                        string borrowTitle = Console.ReadLine()!;
                        Book? bookToBorrow = library.FindBookByTitle(borrowTitle);
                        bookToBorrow?.Borrow();
                        library.SaveToFile();
                        break;

                    case "4":
                        Console.Write("Qual livro deseja devolver? ");
                        string returnTitle = Console.ReadLine()!;
                        Book? bookToReturn = library.FindBookByTitle(returnTitle);
                        bookToReturn?.Return();
                        library.SaveToFile();
                        break;

                    case "5":
                        Console.WriteLine("Qual livro deseja remover? ");
                        string removeTitle = Console.ReadLine()!;
                        library.RemoveBookByTitle(removeTitle);
                        library.SaveToFile();
                        break;

                    case "6":
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
}
