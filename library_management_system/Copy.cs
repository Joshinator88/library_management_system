/// <summary>
/// class to keep track of each individual copy a certain book
/// </summary>
class Copy {
    private bool IsAvailable { get; set; }
    private DateTime? ReturnDate { get; set; }
    private double? FineHeight { get; set; }
    private User? Borrower { get; set; }

    public Copy() {
        IsAvailable = true;
        ReturnDate = null;
        FineHeight = null;
        Borrower = null;
    }

}