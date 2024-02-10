namespace HomeWork3
{
    public class BookRepository
    {
        private readonly ApplicationContext _context;
        private int _pageSize = 5;
        public BookRepository(ApplicationContext context)
        {
            _context = context;
        }
        public void EnsurePopulated()
        {
            if(!_context.Books.Any())
            {
                _context.Books.AddRange(Book.Seed());
                _context.SaveChanges();
            }
        }
        public IEnumerable<Book> GetBooks(int pageNumber = 1)
        {
           return _context.Books.Skip(_pageSize * (pageNumber - 1)).Take(_pageSize).ToList();
        }
        public Book GetBook(int id)
        {
            return _context.Books.FirstOrDefault(x => x.Id == id);
        }
    }
}
