namespace PreviewFeatures;

public interface IExample<T> where T : IExample<T>
{
    static abstract void M();

    static abstract T P { get; set; }

    static abstract event Action E;

    static abstract T operator +(T l, T r);
}

public class Example : IExample<Example>
{
    public static Example P { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public static event Action E;

    public static void M()
    {
        throw new NotImplementedException();
    }

    public static Example operator +(Example l, Example r)
    {
        throw new NotImplementedException();
    }
}