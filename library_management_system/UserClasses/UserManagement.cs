using System.Transactions;

class UserManagement {
    private Dictionary<string, User> Users { get; set; }

    public UserManagement()  {
        Users = new Dictionary<string, User>(StringComparer.OrdinalIgnoreCase);
    }


    private string FindValidName() {
        string name = string.Empty;
        while (String.IsNullOrEmpty(name)) {
            Console.WriteLine("Please enter a usename:\n");
            string input = Console.ReadLine();
            if (String.IsNullOrEmpty(input)) Console.WriteLine("Please enter a valid name");
            else if (input != input.Trim()) {Console.WriteLine("No leading or trailing whitespace allowed");}
            else if (Users.ContainsKey(input)) Console.WriteLine("This name is already taken...");
            else name = input;
        }
        return name;
    }

    public void RegisterUser () {
        string name = FindValidName();
        Users.Add(name, new User(name));
    }

    public void RegisterAdmin() {
        string name = FindValidName();
        Users.Add(name, new Admin(name));
    }

    public User LoginUser() {
        User currentUser = null;

        while(currentUser == null) {
            Console.WriteLine("Please enter your name to login");
            string name = Console.ReadLine();
            if (String.IsNullOrEmpty(name)){
                Console.WriteLine("this is not a valid name");
                continue;
            }
            if (Users.TryGetValue(name, out currentUser)) break;
            else Console.WriteLine("No user found, please try again\n\n");
        }
        Console.WriteLine("Successfully logged in!");
        return currentUser;
    }
}