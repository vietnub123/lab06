using Lab06.Exceptions;

string borrowerId = "ABC";
int borrowedDevices = 2;
int maximumDevices = 2;

try
{
    if (borrowedDevices >= maximumDevices)
    {
        throw new BorrowLimitExceededException(
            borrowerId,
            maximumDevices
        );
    }

    Console.WriteLine("Borrowing allowed.");
}
catch (BorrowLimitExceededException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
    Console.WriteLine($"Borrower ID: {ex.BorrowerId}");
    Console.WriteLine($"Maximum devices: {ex.MaximumDevices}");
}
catch (BorrowingException ex)
{
    Console.WriteLine($"Borrowing error: {ex.Message}");
}
finally
{
    Console.WriteLine("Operation finished.");
}