class Seeder {
    public Library Stock { get; set; }
    public Seeder(Library library){
        Stock = library;
    }


    public void SeedBooks() {
        for (int i = 0; i < 10; i++) {
            Stock.AddBook(new Book($"{i}", $"author{i}", new DateTime(2010, 10, 12)));
            System.Console.WriteLine($"seeded book {i}");
        }
    }
}