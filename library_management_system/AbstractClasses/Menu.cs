abstract class Menu {
    public Dictionary<int, ICommand> Commands { get; protected set; }
    public abstract void DisplayMenu() ;
    public int UserChoice() {
        // ask for the number of the operation the user wants to perform
        Console.WriteLine("Enter the number of the operation you want to perform");
        // check if the user entered a number and if they did then it gets stored in the variable called choice
        bool isNumber =  int.TryParse(Console.ReadLine(), out int choice);

// when the the user input is not a number or is not within the range of the commands dictionary then
// the user enters this loop where they are getting asked for the right input untill they give valid input
        while(!isNumber || choice > Commands.Count || choice <= 0) {
            Console.WriteLine("The number you typed is not valid, please enter a valid number...");
            Console.WriteLine("please enter a valid number");
            isNumber =  int.TryParse(Console.ReadLine(), out choice);
        }
        return choice;
    }
}