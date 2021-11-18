namespace GlobalUsings.Address;

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    private string PostalCode { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}