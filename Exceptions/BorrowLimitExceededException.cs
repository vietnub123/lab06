using Lab06.Models;

namespace Lab06.Exceptions;

public class BorrowLimitExceededException : BorrowingException
{
    public string BorrowerId { get; }
    public int MaximumDevices { get; }

    public BorrowLimitExceededException(
        string borrowerId,
        int maximumDevices)
        : base(
            $"The borrower {borrowerId} exceeds " +
            $"the borrowing limit {maximumDevices}."
        )
    {
        BorrowerId = borrowerId;
        MaximumDevices = maximumDevices;
    }
}