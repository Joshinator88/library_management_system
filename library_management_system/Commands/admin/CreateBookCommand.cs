using System.Globalization;

class CreateBookCommand : ICommand
{
    public BookService BookService { get; set; }

    public CreateBookCommand (Library library) {
        BookService = new BookService(library);
    }
    public void Execute()
    {
        BookService.AddBook();
    }
}