
namespace HomeWork3
{
    public static class Menu
    {
        public static void LoginMenu()
        {
            using (var db = new ApplicationContext())
            {
                var bookManagement = new BookRepository(db);
                bookManagement.EnsurePopulated();

                while (true)
                {
                    Console.WriteLine("1. SHOW ALL BOOKS\n2. SHOW BOOK BY ID\n3. EXIT");

                    string option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            {
                                ShowBooks(bookManagement);
                                break;
                            }
                        case "2":
                            {
                                Console.WriteLine("Enter book ID: ");
                                if (int.TryParse(Console.ReadLine(), out int bookId))
                                {
                                    var currentBook = bookManagement.GetBook(bookId);
                                    Console.WriteLine(currentBook);
                                }
                                break;
                            }
                        case "3":
                            {
                                return;
                            }
                    }
                }
            }
        }
        private static void ShowBooks(BookRepository bookManagement, int pageNumber = 1)
        {
            Console.WriteLine($"Paige number {pageNumber}");
            var allBooks = bookManagement.GetBooks(pageNumber);

            foreach (var book in allBooks)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("1. TO NEXT PAGE");
            if (pageNumber > 1)
            {
                Console.WriteLine("2. TO PREVIOUS PAGE");
            }
            Console.Write("3. BACK");

            int input = int.Parse(Console.ReadLine());

            if (input >= 3)
            {
                return;
            }
            else
            {
                ShowBooks(bookManagement, pageNumber += input == 1 ? 1 : -1);
            }
        }
    }
}