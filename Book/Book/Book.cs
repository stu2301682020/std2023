namespace Excercise
{
    class Book
    {
        private readonly int id;
        private readonly string title;
        private readonly string author;
        private readonly int numberOfPages;
        private readonly double price;

        Book() { }

        Book(int id, string title, string author, int numberOfPages, double price) {
            this.id = id;
            this.title = title;
            this.author = author;
            this.numberOfPages = numberOfPages;
            this.price = price;
        }

        public string getBookInfo()
        {
            return $"Заглавие: {title}, Автор: {author}, Цена: {price}";
        }

        public static void Main()
        {
            Book book = new(1, "Под игото", "Иван Вазов", 567, 20.50);
            Console.WriteLine(book.getBookInfo());
        }
    }
}