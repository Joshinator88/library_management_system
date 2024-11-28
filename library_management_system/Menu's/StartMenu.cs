
class StartMenu : Menu {
    public StartMenu() {
        OptionCount = 2;
    }
    public override void DisplayMenu() {
        Console.WriteLine("Welcome to the library,");
        Console.WriteLine("choose the action you want to perform:");
        Console.WriteLine("[1] Log in");
        Console.WriteLine("[2] Register");
    }

}