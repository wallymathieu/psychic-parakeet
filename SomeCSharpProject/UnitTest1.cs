namespace SomeCSharpProject;
public interface IGetNext<T> where T : IGetNext<T>
{
    static abstract T operator ++(T other);
}
public class UnitTest1
{
    [Fact]
    public void Test1()
    {

    }
}