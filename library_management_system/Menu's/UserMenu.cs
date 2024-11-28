class UserMenu : Menu
{
    public UserMenu() {
        OptionCount = 2;
    }
    public override void DisplayMenu() {
        Console.WriteLine($"Welcome, it is great to see you back!");
        Console.WriteLine("Are you going to return a book or rent one?");
        Console.WriteLine("[1] Rent");
        Console.WriteLine("[2] Return");
    }
}