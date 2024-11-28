// See https://aka.ms/new-console-template for more information
Library stock = new Library();
Seeder seeder = new Seeder(stock);
seeder.SeedBooks();
StartMenu startMenu = new StartMenu();
UserManagement management = new UserManagement();
CommandHandler commandHandler = new CommandHandler();


commandHandler.AddCommand(1, new LoginCommand(management));
commandHandler.AddCommand(2, new RegisterCommand(management));

while(true) {
    startMenu.DisplayMenu();
    commandHandler.ExecuteCommand(startMenu.UserChoice());

}