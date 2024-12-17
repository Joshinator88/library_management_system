///<summary>
///class for checking what user is logged in
///</summary>
class Session 
{
    public User? LoggedinUser { get; private set; }
    public Session() {
        LoggedinUser = null;
    }

    ///<summary>
    /// Saving the currently logged in user into the session
    ///</summary>
    public void SetUser(User user) {
        LoggedinUser = user;
    }
    ///<summary>
    /// logging out the current user by deleting its data in the session
    ///</summary>
    public void ClearUser() {
        LoggedinUser = null;
    }
}