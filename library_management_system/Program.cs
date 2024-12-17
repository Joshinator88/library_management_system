Library stock = new Library();
Seeder seeder = new Seeder();
UserManagement management = new UserManagement();
Session session = new Session();

seeder.SeedBooks(stock);
seeder.SeedUsers(management);

// infinite loop to let the user be able to choose what operation it want to perform
while(true) {
    Menu menu = MenuFactory.ReturnMenu(session, management, stock);
    // the user gets the right menu displayed
    menu.DisplayMenu();
    // the user makes a choice so that command gets executed
    menu.Commands[menu.UserChoice()].Execute();
}