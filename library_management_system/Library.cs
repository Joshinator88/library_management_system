class Library {
    private List<Book> Stock { get; set; }

    public Library() {
        Stock = new List<Book>();
    }

    public void AddBook(Book book) {
        Stock.Add(book);
    }

    public void ShowInventory() {
        foreach (Book book in Stock) {
            Console.WriteLine(book.Title);
        }
    }
}