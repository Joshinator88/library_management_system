class BookService 
{
    private Library Library { get; set; }
    public BookService (Library library) {
        Library = library;
    }

    public void AddBook() {
        Book book = BookInputHandler.GetBookFromUser();
        Library.AddBook(book);
        Console.WriteLine($"{book.Title} is added to the collection!");
    }
}