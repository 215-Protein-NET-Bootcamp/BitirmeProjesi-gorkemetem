namespace Base
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
