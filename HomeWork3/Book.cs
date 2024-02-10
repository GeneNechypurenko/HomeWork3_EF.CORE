namespace HomeWork3
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public override string ToString() => $"{Title}, {Author}, {Price}";
        public static Book[] Seed() => new Book[]
        {
            new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Price = 10.99m },
            new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Price = 12.50m },
            new Book { Title = "1984", Author = "George Orwell", Price = 8.99m },
            new Book { Title = "Pride and Prejudice", Author = "Jane Austen", Price = 9.95m },
            new Book { Title = "The Catcher in the Rye", Author = "J.D. Salinger", Price = 11.25m },
            new Book { Title = "The Hobbit", Author = "J.R.R. Tolkien", Price = 14.99m },
            new Book { Title = "Harry Potter and the Sorcerer's Stone", Author = "J.K. Rowling", Price = 15.75m },
            new Book { Title = "The Lord of the Rings", Author = "J.R.R. Tolkien", Price = 18.50m },
            new Book { Title = "Animal Farm", Author = "George Orwell", Price = 7.99m },
            new Book { Title = "The Chronicles of Narnia", Author = "C.S. Lewis", Price = 16.20m },
            new Book { Title = "Brave New World", Author = "Aldous Huxley", Price = 10.50m },
            new Book { Title = "Moby-Dick", Author = "Herman Melville", Price = 13.45m },
            new Book { Title = "The Grapes of Wrath", Author = "John Steinbeck", Price = 11.99m },
            new Book { Title = "Jane Eyre", Author = "Charlotte Brontë", Price = 9.85m },
            new Book { Title = "The Odyssey", Author = "Homer", Price = 12.75m }
        };
    }
}