class MenuFactory
{
    
    public static Menu ReturnMenu(Session session, UserManagement management) {
        Menu menu;
        if (session.LoggedinUser != null) {
            if (session.LoggedinUser.IsAdmin) menu = new AdminMenu(session);
            else menu = new UserMenu(session);
        }
        else menu = new StartMenu(session, management);
        return menu;
    }

}