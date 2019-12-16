namespace SimpleIndexer
{
    public interface IPersonContainer
    {
        Person this[int index] { get;set; }
    }
}