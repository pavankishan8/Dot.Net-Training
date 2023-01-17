using System;
using System.IO;

namespace BookApp
{
  
        class LibraryBooksAccount
        {
            public int AccountId { get; set; }
            public string Name { get; set; }
            public double Balance { get; private set; } = 10;

            public void Credit(int amount) => Balance += amount;

            public void Debit(int amount)
            {
                if (amount > Balance)
                    throw new Exception("Insufficient Books");
                Balance -= amount;
            }
        }

        class LibraryAccountManager
        {
            private LibraryBooksAccount[] _accounts = null;
            private int _size = 0;
            public LibraryAccountManager(int size)
            {
                _size = size;
                _accounts = new LibraryBooksAccount[_size];
            }

            public void AddNewAccount(LibraryBooksAccount acc)
            {
                for (int i = 0; i < _size; i++)
                {
                    if (_accounts[i] == null)
                    {
                        _accounts[i] = new LibraryBooksAccount { AccountId = acc.AccountId, Name = acc.Name };
                        _accounts[i].Credit((int)acc.Balance);
                        return;
                    }
                }
            }

            public void UpdateLibraryAccountDetails(LibraryBooksAccount acc)
            {
                for (int i = 0; i < _size; i++)
                {
                    if (_accounts[i] != null && _accounts[i].AccountId == acc.AccountId)
                    {
                        _accounts[i].Name = acc.Name;
                        return;
                    }
                }
                throw new Exception("Library Account not found to update");
            }

            public void DeleteLibraryAccount(int id)
            {
                for (int i = 0; i < _size; i++)
                {
                    if (_accounts[i] != null && _accounts[i].AccountId == id)
                    {
                       _accounts[i] = null; 
                        return;
                    }
                }
                throw new Exception("No Library Account found to delete");

            }

            public LibraryBooksAccount FindAccount(int id)
            {
                foreach (LibraryBooksAccount acc in _accounts)
                {
                    if (acc != null && acc.AccountId == id)
                        return acc;
                }
                throw new Exception("No Account found");
            }

        }

    class LibBook
    {
        int id;
        string name, author;
        double price;

        public int BookID
        {
            get { return id; }
            set { id = value; }
        }

        public string BookName
        {
            get => name;
            set => name = value;
        }

        public string BookAuthor
        {
            get => author;
            set => author = value;
        }

        public double BookPrice
        {
            get => price;
            set => price = value;
        }

    }

    class UIManager
    {
        public static LibraryAccountManager mgr = null;

        internal static void DisplayMenu(string file)
        {
            int size = Utilities1.GetNumber("Enter the Size");
            mgr = new LibraryAccountManager(size);
            bool processing = true;
            string menu = File.ReadAllText(file);
            do
            {
                int choice = Utilities1.GetNumber(menu);
                processing = processMenu(choice);
            } while (processing);
            Console.WriteLine("Thanks for using our application");
        }

        private static bool processMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                    addingAccountHelper();
                    break;
                case 2:
                    updatingAccountHelper();
                    break;
                case 3:
                    findingAccountHelper();
                    break;
                case 4:
                    throw new Exception("Do it URSELF!!");
                default:
                    return false;
            }
            return true;
        }

        private static void findingAccountHelper()
        {
            int id = Utilities1.GetNumber("Enter the ID of the Account to Find");
            try
            {
                LibraryBooksAccount acc = mgr.FindAccount(id);
                Console.WriteLine("The Details of the Account are as follows:");
                string content = $"The Name: {acc.Name}\nThe Balance : {acc.Balance}\nThe Account No: {acc.AccountId}\n";
                Console.WriteLine(content);
                Utilities1.Prompt("Press Enter to clear the Screen");
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private static void updatingAccountHelper()
        {
            int id = Utilities1.GetNumber("Enter the ID of the Account to Update");
            string name = Utilities1.Prompt("Enter the  New Name of the Customer");
            LibraryBooksAccount acc = new LibraryBooksAccount { AccountId = id, Name = name };
            mgr.UpdateLibraryAccountDetails(acc);
            Utilities1.Prompt("Press Enter to clear the Screen");
            Console.Clear();
        }

        private static void addingAccountHelper()
        {
            int id = Utilities1.GetNumber("Enter the ID of the Account");
            string name = Utilities1.Prompt("Enter the Name of the Customer");
            LibraryBooksAccount acc = new LibraryBooksAccount { AccountId = id, Name = name };
            mgr.AddNewAccount(acc);
            Utilities1.Prompt("Press Enter to clear the Screen");
            Console.Clear();
        }
    
    class LibraryBooks
        {
            static void bookCreation()
            {
                LibBook bookObj = new LibBook { BookAuthor = "Ramesh", BookID = 8555, BookName = "Test Book", BookPrice = 560 };
                Console.WriteLine("The name is " + bookObj.BookName);
            }
        }
        static void Main(string[] args)
        {
            UIManager.DisplayMenu(args[0]);
        }

        private static void libManagerCreation()
        {
            int count = Utilities1.GetNumber("Enter the Account Count you want to create");
            LibraryAccountManager mgr = new LibraryAccountManager(count);
            try
            {
                mgr.FindAccount(123);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void accountCreation()
        {
            LibraryBooksAccount acc = new LibraryBooksAccount { AccountId = 121, Name = "Pavan R" };
            Console.WriteLine("The Balance: " + acc.Balance);
            acc.Credit(5);
            Console.WriteLine("The Balance: " + acc.Balance);
            try
            {
                acc.Debit(8);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
     }
 }
