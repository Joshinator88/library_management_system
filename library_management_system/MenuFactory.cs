class MenuFactory
{
    
    public static Menu ReturnMenu(Session session, UserManagement management, Library stock) {
        Menu menu;
        if (session.LoggedinUser != null) {
            if (session.LoggedinUser.IsAdmin) menu = new AdminMenu(session, stock);
            else menu = new UserMenu(session);
        }
        else menu = new StartMenu(session, management);
        return menu;
    }

}