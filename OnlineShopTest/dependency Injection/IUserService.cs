using OnlineShopTest.Dtos;
using OnlineShopTest.middleware;
using OnlineShopTest.Models;

namespace OnlineShopTest.dependency_Injection
{
    public interface IUserService
    {
        public Task<string> LoginUser();
        public Task<Customer> AddCustomer(AddCustomerRequest request);
        public Task<Customer[]> GetCustomers();

        public Task<NewMiddleware> GetNewMiddleware(HttpContext context , RequestDelegate request);
        
        public Task<Order[]> Order();
    }
}
