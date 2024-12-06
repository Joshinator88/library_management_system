using System.Globalization;

class BookInputHandler() {
    public static Book GetBookFromUser() {
        string title;
        string author;
        string unparsedDate;
        DateTime publicationDate;
        System.Console.WriteLine("Allright, lets add a book");
        System.Console.WriteLine("Please enter the title of the book");
        title = Console.ReadLine();
        System.Console.WriteLine("Now enter the Author of the Book");
        author = Console.ReadLine();
        System.Console.WriteLine("At last, enter the publication date");
        while (true)
        {
            unparsedDate = Console.ReadLine();
            try 
            {
                publicationDate = DateTime.Parse(unparsedDate, new CultureInfo("nl-NL"));
                break;
            }
            catch 
            {
                System.Console.WriteLine("I did not recognize that as a date please try again");
                continue;
            }
        }
        return new Book(title, author, publicationDate);
    }
}