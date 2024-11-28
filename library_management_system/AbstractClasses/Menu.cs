abstract class Menu {
    protected int OptionCount { get; set; }

    public abstract void DisplayMenu() ;
    public int UserChoice() {
        Console.WriteLine("Enter the number of the operation you want to perform");
        bool isNumber =  int.TryParse(Console.ReadLine(), out int choice);

        while(!isNumber || choice > OptionCount || choice <= 0) {
            Console.WriteLine("The number you typed is not valid, please enter a valid number...");
            System.Console.WriteLine("please enter a valid number");
            isNumber =  int.TryParse(Console.ReadLine(), out choice);
        }
        Console.WriteLine(choice >= OptionCount && choice <= 0);
        return choice;
    }
}