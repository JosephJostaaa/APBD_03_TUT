namespace APBD_03_TUT_TASK;

public class OverfillException : Exception
{
    public OverfillException(string? message) : base(message)
    {
    }
}