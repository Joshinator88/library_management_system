class Session 
{
    public User? LoggedinUser { get; private set; }
    public Session() {
        LoggedinUser = null;
    }

    public void SetUser(User user) {
        LoggedinUser = user;
    }
    public void ClearUser() {
        LoggedinUser = null;
    }
}