class ReturnBookCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("returning a book...");
        Console.ReadKey();
    }
}