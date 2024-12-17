/// <summary>
/// class to manage individual book objects and its copies
/// </summary>
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
    }

    /// <summary>
    /// method to add a copy to a certain book, kept inside the book method to keep the list of copies private
    /// </summary>
    public void AddCopy() {
        Copies.Add(new Copy()); 
    }
}