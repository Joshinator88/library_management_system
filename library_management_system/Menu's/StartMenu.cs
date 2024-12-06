
class StartMenu : Menu {
    public StartMenu(Session session, UserManagement management) {
        Commands = new Dictionary<int, ICommand> {
            { 1, new LoginCommand(management, session) },
            { 2, new RegisterCommand(management, session) }
        };
       
    }
    public override void DisplayMenu() {
        Console.WriteLine("Welcome to the library,");
        Console.WriteLine("choose the action you want to perform:");
        Console.WriteLine("[1] Log in");
        Console.WriteLine("[2] Register");
    }

}