namespace DemoLibrary;

public interface IDvd
{
    string LibraryId { get; set; }
    string Title { get; set; }
    int CheckOutDurationInDays { get; set; }
    string Borrower { get; set; }
    DateTime BorrowDate { get; set; }
    int RuntimeInMinutes { get; set; }
    void CheckOut(string borrower);
    void CheckIn();
    DateTime GetDueDate();
}