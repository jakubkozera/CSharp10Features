namespace StructImprovements
{
    public struct Money
    {
        public Money()
        {
            Currency = "";
            Value = 0;
        }

        public string Currency { get; set; }
        public decimal Value { get; set; }
    }
}