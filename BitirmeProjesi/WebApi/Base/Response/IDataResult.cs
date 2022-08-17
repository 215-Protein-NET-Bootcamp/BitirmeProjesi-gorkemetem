namespace Base
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
