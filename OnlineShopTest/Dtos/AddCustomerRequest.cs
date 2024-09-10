namespace OnlineShopTest.Dtos
{
    public record AddCustomerRequest
    {
        public required string Name { get; init; }
        public required string Password { get; init; }

        public required string Email { get; init; } 
    }
}
