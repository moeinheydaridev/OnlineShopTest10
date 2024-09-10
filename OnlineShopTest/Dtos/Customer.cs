namespace OnlineShopTest.Dtos
{
    public record Customer
    {
        public required string Name { get; init; }

        public required string Email { get; init; }

        public required string Password { get; init; }
    }
}
