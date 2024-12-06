class UserMenu : Menu
{
    public UserMenu(Session session) {
        Commands = new Dictionary<int, ICommand>
        {
            {1, new RentBookCommand()},
            {2, new ReturnBookCommand()},
            {3, new LogOutCommand(session)}
        };
    }
    public override void DisplayMenu() {
        Console.WriteLine($"Welcome, it is great to see you back!");
        Console.WriteLine("Are you going to return a book or rent one?");
        Console.WriteLine("[1] Rent");
        Console.WriteLine("[2] Return");
        Console.WriteLine("[3] Log Out");
    }
}