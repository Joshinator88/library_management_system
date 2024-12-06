class RegisterCommand : ICommand {
    public UserManagement Management { get; set; }
    private Session Session { get; set; }
    public RegisterCommand(UserManagement userManagement, Session session) {
        Management = userManagement ?? throw new ArgumentNullException(nameof(userManagement));
        Session = session ?? throw new ArgumentNullException(nameof(session));
    }
    public void Execute(){
            Session.SetUser(Management.RegisterUser());
            Console.WriteLine("User is registered!");
    }
}