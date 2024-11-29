class User {
    public string Name { get; set; }
    protected bool IsAdmin { get; set; }

    private double Fine { get; set; }

    public User(string name){
        Name = name;
        Fine = 0;
        IsAdmin = false;
    }
    
    
}