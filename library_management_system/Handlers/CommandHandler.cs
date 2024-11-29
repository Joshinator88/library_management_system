class CommandHandler {
    private Dictionary<int, ICommand> CommandDictionary { get; set; }


    public CommandHandler() {
        CommandDictionary = new Dictionary<int, ICommand>();
    }

    public void AddCommand(int key, ICommand value) {
        CommandDictionary.Add(key, value);
    }

    public void ExecuteCommand(int choice) {
        CommandDictionary[choice].Execute();
    }

}