// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var someValue = new DerivedRecord("a", "b");

Console.WriteLine(someValue);

public record class DerivedRecord(string Value, string BaseValue) : BaseRecord(BaseValue);
public record class BaseRecord(string BaseValue)
{
    public sealed override string ToString()
    {
        return "Base implmentation";
    }
}