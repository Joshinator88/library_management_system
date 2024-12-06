// See https://aka.ms/new-console-template for more information
Library stock = new Library();
Seeder seeder = new Seeder(stock);
// StartMenu startMenu = new StartMenu();
UserManagement management = new UserManagement();
seeder.SeedBooks();
seeder.SeedUsers(management);
Session session = new Session();

while(true) {
    Menu menu = MenuFactory.ReturnMenu(session, management);
    menu.DisplayMenu();
    menu.Commands[menu.UserChoice()].Execute();
}