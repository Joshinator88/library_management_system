///<summary>
/// class for seeding the library and the users
///</summary>
class Seeder {
    private string[] UserNames { get; set; }
    public Seeder(){
        UserNames = ["Joshua", "dribble", "cheese"];
    }

    ///<summary>
    /// Method for seeding the books to the library
    ///</summary>
    public void SeedBooks(Library stock) {
        for (int i = 0; i < 10; i++) {
            stock.AddBook(new Book($"{i}", $"author{i}", new DateTime(2010, 10, 12)));
        }
    }
    ///<summary>
    /// Method for seeding users
    ///</summary>
    public void SeedUsers(UserManagement userManagement) {
        foreach (string name in UserNames) {
            if (name == "Joshua") userManagement.RegisterAdmin(name);
            else userManagement.RegisterUser(name);

        }
    }
}