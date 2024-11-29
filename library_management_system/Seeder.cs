class Seeder {
    public Library Stock { get; set; }
    private string[] UserNames { get; set; }
    public Seeder(Library library){
        Stock = library;
        UserNames = ["Joshua", "dribble", "cheese"];
    }


    public void SeedBooks() {
        for (int i = 0; i < 10; i++) {
            Stock.AddBook(new Book($"{i}", $"author{i}", new DateTime(2010, 10, 12)));
        }
    }
    public void SeedUsers(UserManagement userManagement) {
        foreach (string name in UserNames) {
            if (name == "Joshua") userManagement.RegisterAdmin(name);
            else userManagement.RegisterUser(name);

        }
    }
}