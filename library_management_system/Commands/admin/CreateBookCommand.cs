class CreateBookCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("creating Book...");
        Console.ReadKey();
    }
}