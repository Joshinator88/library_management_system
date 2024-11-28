class RegisterCommand : ICommand {
    public UserManagement Management { get; set; }
    public RegisterCommand(UserManagement management) {
        Management = management ?? throw new ArgumentNullException(nameof(management));
    }
    public void Execute(){
            Management.RegisterUser();
            Console.WriteLine("User is registered!");
    }
}