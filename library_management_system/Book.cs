class Book {
    public string Title { get; private set; }
    public string Author { get; private set; }
    public DateTime PublicationDate { get; private set; }
    public List<Copy> Copies { get; private set; }

    public Book(string title, string author, DateTime publicationDate) {
        Title = title;
        Author = author;
        PublicationDate = publicationDate;
        Copies = new List<Copy>();
        AddCopy();
    }

    public void AddCopy() {
        Copies.Add(new Copy()); 
    }
}