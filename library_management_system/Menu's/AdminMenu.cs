class AdminMenu : Menu 
{
    public AdminMenu() {
        OptionCount = 5;
    }

    public override void DisplayMenu()
    {
        System.Console.WriteLine("Welcome back, what action do you want to perform?");
        System.Console.WriteLine("[1] Create a book");
        System.Console.WriteLine("[2] Delete a Book");
        System.Console.WriteLine("[3] Create an Admin User");
        System.Console.WriteLine("[4] Rent a Book");
        System.Console.WriteLine("[5] Return a book");
    }
}