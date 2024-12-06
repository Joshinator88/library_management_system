class AdminMenu : Menu 
{

    public AdminMenu(Session session) {
        Commands = new Dictionary<int, ICommand>
        {
            {1, new CreateBookCommand()},
            {2, new DeleteBookCommand()},
            {3, new CreateAdminCommand()},
            {4, new RentBookCommand()},
            {5, new ReturnBookCommand()},
            {6, new LogOutCommand(session)}
        };
    }

    public override void DisplayMenu()
    {
        Console.WriteLine("Welcome back, what action do you want to perform?");
        Console.WriteLine("[1] Create a book");
        Console.WriteLine("[2] Delete a Book");
        Console.WriteLine("[3] Create an Admin User");
        Console.WriteLine("[4] Rent a Book");
        Console.WriteLine("[5] Return a book");
        Console.WriteLine("[6] Log Out");
    }
}