class CreateAdminCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("creating admin...");
        Console.ReadKey();
    }
}