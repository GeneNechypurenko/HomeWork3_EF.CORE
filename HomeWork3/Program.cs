
namespace HomeWork3
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ApplicationContext())
            {
                var userManagement = new UserRepository(db);

                while (true)
                {
                    Console.WriteLine("1. REGISTRATION\n2. LOG IN\n3. EXIT");

                    string option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            {
                                Console.Write("Enter account name: ");
                                string accountName = Console.ReadLine();
                                Console.Write("Enter password: ");
                                string password = Console.ReadLine();

                                if (userManagement.UserRegistration(accountName, password))
                                {
                                    Console.WriteLine("Registration complete");
                                }
                                else
                                {
                                    Console.WriteLine("The incorrect account name");
                                }

                                break;
                            }
                        case "2":
                            {
                                Console.Write("Enter account name: ");
                                string accountName = Console.ReadLine();
                                Console.Write("Enter password: ");
                                string password = Console.ReadLine();

                                if (userManagement.UserAuthorization(accountName, password))
                                {
                                    Menu.LoginMenu();
                                }
                                else
                                {
                                    Console.WriteLine("The incorrect account name or password");
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
    }
}
