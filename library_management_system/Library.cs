/// <summary>
/// class to manage all books in the library
/// </summary>
class Library {
    private List<Book> Stock { get; set; }

    public Library() {
        Stock = new List<Book>();
    }

    /// <summary>
    /// method for adding books to the library
    /// </summary>
    public void AddBook(Book book) {
        if (Stock.Contains(book)) book.AddCopy();
        else Stock.Add(book);
    }

    /// <summary>
    /// shows all books currently in the library
    /// </summary>
    public void ShowInventory() {
        foreach (Book book in Stock) {
            Console.WriteLine(book.Title);
        }
    }
}