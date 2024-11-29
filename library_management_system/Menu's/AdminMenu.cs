class AdminMenu : Menu 
{
    public AdminMenu() {
        OptionCount = 5;
    }

    public override void DisplayMenu()
    {
        Console.WriteLine("Welcome back, what action do you want to perform?");
        Console.WriteLine("[1] Create a book");
        Console.WriteLine("[2] Delete a Book");
        Console.WriteLine("[3] Create an Admin User");
        Console.WriteLine("[4] Rent a Book");
        Console.WriteLine("[5] Return a book");
    }
}