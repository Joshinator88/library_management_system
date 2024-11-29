class User {
    public string Name { get; set; }
    public bool IsAdmin { get; protected set; }

    private double Fine { get; set; }

    public User(string name){
        Name = name;
        Fine = 0;
        IsAdmin = false;
    }
}