using System;//Default APIs
using Entities;//For the Entity class
using Repository;//Repo class
using SampleConApp; //Utilities

namespace Entities
{
    class Book
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public string Publisher { get; set; }
        public int BookStock { get; set; } = 10;

        public void ShallowCopy(Book copy)
        {
            this.BookId = copy.BookId;
            this.BookStock = copy.BookStock;
            this.BookTitle = copy.BookTitle;
            this.Price = copy.Price;
            this.Publisher = copy.Publisher;
            this.Author = copy.Author;
        }

        public Book DeepCopy(Book copy)
        {
            Book book = new Book();
            book.ShallowCopy(copy);
            return book;
        }
    }
}
//datatype [] identifier = new datatype[size]
namespace Repository
{
    class BookRepository
    {
        private Book[] _books = null;
        private readonly int _size = 0;
        public BookRepository(int size)
        {
            _size = size;
            _books = new Book[_size];
        }

        public int AddNewBook(Book book)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_books[i] == null)
                {
                    _books[i] = book.DeepCopy(book);
                    return 1;//To exit
                }
            }
            return _size;
        }

        public void UpdateBook(Book book)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_books[i] != null && _books[i].BookId == book.BookId)
                {
                    _books[i].ShallowCopy(book);
                    return;//To exit
                }
            }
            throw new Exception("No book found to update");
        }

        public void RemoveBook(int id)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_books[i] != null && _books[i].BookId == id)
                {
                    _books[i] = null;
                    return;//To exit
                }
            }
            throw new Exception("No book found to remove");
        }

        public Book[] FindByAuthor(string author)
        {
            int count = 0;
            foreach (Book book in _books)
            {
                if (book != null && book.Author.Contains(author))
                {
                    count += 1;
                }
            }
            Book[] books = new Book[count];
            count = 0;
            foreach (Book book in _books)
            {
                if (book != null && book.Author.Contains(author))
                {
                    books[count] = book.DeepCopy(book);
                    count += 1;
                }
            }
            return books;
        }

        public Book[] FindByTitle(string title)
        {
            int count = 0;
            foreach (Book book in _books)
            {
                if (book != null && book.BookTitle.Contains(title))
                {
                    count += 1;
                }
            }
            Book[] books = new Book[count];
            count = 0;
            foreach (Book book in _books)
            {
                if (book != null && book.BookTitle.Contains(title))
                {
                    books[count] = book.DeepCopy(book);
                    count += 1;
                }
            }
            return books;
        }
    }
}

namespace UILayer
{

    
    enum Options
    {
        Add = 1, Remove, Author, Title, Update
    }
    class UIComponent
    {
        
        public const string menu = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~BOOK STORE MANAGER SOFTWARE~~~~~~~~~~~~~~~~~~~\nTO ADD NEW BOOK------------------------>PRESS 1\nTO DELETE EXISTING BOOK---------------->PRESS 2\nTO FIND BOOK BY AUTHOR----------------->PRESS 3\nTO FIND BOOK BY TITLE------------------>PRESS 4\nTO UPDATE BOOK------------------------->PRESS 5\nPS: ANY OTHER KEY IS CONSIDERED AS EXIT.....................................";

        private static BookRepository repo;

        public static void Run()
        {
            int size = Utilities.GetNumber("Enter the Number of Books you want for the Store");
            repo = new BookRepository(size);
            bool processing = true;
            do
            {
                Options option = (Options)Utilities.GetNumber(menu);
                processing = processMenu(option);
            } while (processing);
            Console.WriteLine("Thanks for Using our Application!!!");
        }

        private static bool processMenu(Options option)
        {
            switch (option)
            {
                case Options.Add:
                    addingNewBook();
                    break;
                case Options.Remove:
                    removingNewBook();
                    break;
                case Options.Author:
                    findingBookByAuthor();
                    break;
                case Options.Title:
                    findingBookByTitle();
                    break;
                case Options.Update:
                    updatingNewBook();
                    break;
                default:
                    return false;
            }
            return true;
        }

        private static void addingNewBook()
        {
            int id = Utilities.GetNumber("Enter the Book ID:");
            string title = Utilities.Prompt("Enter the Book Title:");
            string author = Utilities.Prompt("Enter the Book Author:");
            double price = Utilities.GetNumber("Enter the Book Price:");
            Book book = new Book { BookId = id, BookTitle = title, Author = author, Price = price };
            repo.AddNewBook(book);
            Utilities.Prompt("Press Enter to clear the Screen");
            Console.Clear();
        }

         private static void updatingNewBook()
        {
            int id = Utilities.GetNumber("Enter the Updated Book ID:");
            string title = Utilities.Prompt("Enter the Updated Book Title:");
            string author = Utilities.Prompt("Enter the Updated Book Author:");
            double price = Utilities.GetNumber("Enter the Updated Book Price:");
            Book book = new Book { BookId = id, BookTitle = title, Author = author, Price = price };
            repo.UpdateBook(book);
            Utilities.Prompt("Press Enter to clear the Screen");
            Console.Clear();
        }

        private static void removingNewBook()
        {
            int id = Utilities.GetNumber("Enter the Book ID you want to Delete:");
            repo.RemoveBook(id);
            Console.WriteLine("Your book is deleted Successfully!!!");
            Utilities.Prompt("Press Enter to clear the Screen");
            Console.Clear();

        }

        private static void findingBookByAuthor()
        {
            string author = Utilities.Prompt("Enter the Author of the Book to Find:");
            try
            {
                Book[] details = repo.FindByAuthor(author);
                Console.WriteLine("The Details of the Books are as follows:");
                foreach (var item in details)
                {
                    string content = $"The Author: {item.Author}\nThe Book No: {item.BookId}\nThe Book Title: {item.BookTitle}\nThe Book Price: {item.Price}\n";
                    Console.WriteLine(content);
                }
                
                Utilities.Prompt("Press Enter to clear the Screen");
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
            private static void findingBookByTitle()
                    {
            string title = Utilities.Prompt("Enter the Title of the Book to Find:");
            try
            {
                Book[] details = repo.FindByTitle(title);
                Console.WriteLine("The Details of the Books are as follows:");
                foreach (var item in details)
                {
                    string content = $"The Title: {item.BookTitle}\nThe Book No: {item.BookId}\nThe Book Author: {item.Author}\nThe Book Price: {item.Price}\n";
                    Console.WriteLine(content);
                }
                Utilities.Prompt("Press Enter to clear the Screen");
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

namespace TestingApp
{
    using Repository;
    using SampleConApp;
    using System;

    class App
    {
        static void Main(string[] args)
        {
            UILayer.UIComponent.Run();
        }
    }
}
