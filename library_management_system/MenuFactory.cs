///<summary>
///this class manages what type of menu the user should see
///</summary>
class MenuFactory
{
    
    ///<summary>
    ///Returns the right menu based on the session
    ///</summary>
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