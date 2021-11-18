namespace GlobalUsings.Person;

using GlobalUsings.Address;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Address> Adresses { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}