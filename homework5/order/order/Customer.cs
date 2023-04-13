namespace OrderManagement
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public Customer(int customerId, string name)
        {
            CustomerId = customerId;
            Name = name;
        }

        public override string ToString()
        {
            return $"CustomerId:{CustomerId}, Name:{Name}";
        }
    }
}
