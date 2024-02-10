namespace HomeWork3
{
    public class UserRepository
    {
        private readonly ApplicationContext _context;
        public UserRepository(ApplicationContext context) => _context = context;

        public bool UserRegistration(string accountName, string password)
        {
            if (_context.Users.Any(e => e.AccountName == accountName))
            {
                Console.WriteLine("This account name is already exists!");
                return false;
            }
            else
            {
                string salt = SecurityHelper.GenerateSalt(10101);
                string passwordHash = SecurityHelper.HashPassword(password, salt, 10101, 70);

                _context.Users.Add(new User
                {
                    AccountName = accountName,
                    PasswordHash = passwordHash,
                    Salt = salt
                });
                _context.SaveChanges();

                return true;
            }
        }
        public bool UserAuthorization(string accountName, string password)
        {
            var currentUser = _context.Users.FirstOrDefault(e => e.AccountName == accountName);

            if (currentUser is not null)
            {
                string passwordHash = SecurityHelper.HashPassword(password, currentUser.Salt, 10101, 70);
                return passwordHash == currentUser.PasswordHash;
            }
            else
            {
                return false;
            }
        }
    }
}