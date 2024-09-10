using OnlineShopTest.Dtos;
using OnlineShopTest.Models;

namespace OnlineShopTest.DtoConverters
{
    public static class UserConverter
    {
        public static Customer ToDto(this CustomerModel model)
        {
            return new Customer { Name = model.Name, Email = model.Email, Password = model.Password };
        }
    }
}
