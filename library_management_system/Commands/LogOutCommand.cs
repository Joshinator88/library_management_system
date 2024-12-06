class LogOutCommand : ICommand 
{
    public Session Session { get; set; }
    public LogOutCommand (Session session) {
        Session = session;
    }
    public void Execute() {
        Session.ClearUser();
    }
}