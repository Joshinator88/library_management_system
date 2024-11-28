
class StartMenu : IUserMenu {
    public void DisplayMenu() {
        Console.WriteLine("Welcome to the library, \nchoose the action you want to perform:\n[1] Log in\n[2] Register");
    }

    public int UserChoice() {
        Console.WriteLine("Enter the number of the operation you want to perform");
        int choice;
        while(!int.TryParse(Console.ReadLine(), out choice) && choice <= 0 && choice > 2) {
            Console.WriteLine("The number you typed is not valid, please enter a valid number...");
        }

        return choice;

    }
}