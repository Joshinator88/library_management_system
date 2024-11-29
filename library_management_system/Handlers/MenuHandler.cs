class MenuHandler 
{
    private Dictionary<string, Menu> MenuDictionary { get; set; }
    private string UserType { get; set; }
    public MenuHandler() {
        MenuDictionary = new Dictionary<string, Menu>() 
        {
            { "AdminMenu", new AdminMenu() },
            { "None", new StartMenu() },
            { "UserMenu", new UserMenu() }
        };
        UserType = "None";
    }

    // public void ShowMenu(User user = null) {
    //     if (user != null) {
    //         if (user.IsAdmin) MenuDictionary["AdminMenu"].DisplayMenu();
    //         else if (!user.IsAdmin) MenuDictionary["StartMenu"].DisplayMenu();
    //         else Console.WriteLine("An error has occured, please restart application");
    //     }
    //     else {
    //         MenuDictionary["StartMenu"].DisplayMenu();
    //     }
    // }
    public void DisplayMenu(User user = null) {
        if (user != null) {
            if (user.IsAdmin) UserType = "AdminMenu";
            else if (!user.IsAdmin) UserType = "UserMenu";
            else UserType = "None";
        }
        else {
            UserType = "None";
        }
        MenuDictionary[UserType].DisplayMenu();

    }

    public int UserChoice() {
        return MenuDictionary[UserType].UserChoice();
    }
}