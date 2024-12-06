class DeleteBookCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("deleting book...");
        Console.ReadKey();
    }
}