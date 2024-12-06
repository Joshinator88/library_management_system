class LoginCommand : ICommand {
    private UserManagement Management { get; set; }
    private Session Session { get; set; }
    public LoginCommand(UserManagement userManagement, Session session) {
        Management = userManagement ?? throw new ArgumentNullException(nameof(userManagement));
        Session = session ?? throw new ArgumentNullException(nameof(userManagement));
    }
public void Execute() {
    Session.SetUser(Management.LoginUser());
}
}