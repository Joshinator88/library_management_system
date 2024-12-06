class RentBookCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("rent a book...");
        Console.ReadKey();
    }
}