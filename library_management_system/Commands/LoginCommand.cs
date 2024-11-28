class LoginCommand : ICommand {
    private UserManagement Management { get; set; }
    public LoginCommand(UserManagement userManagement) {
        Management = userManagement ?? throw new ArgumentNullException(nameof(userManagement));
    }
public void Execute() {
Management.LoginUser();
}
}