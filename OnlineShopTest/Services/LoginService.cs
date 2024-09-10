using OnlineShopTest.DataBase;
using OnlineShopTest.dependency_Injection;
using OnlineShopTest.DtoConverters;
using OnlineShopTest.Dtos;
using OnlineShopTest.middleware;
using OnlineShopTest.Models;
using OnlineShopTest.repo;

namespace OnlineShopTest.Services
{
    public class LoginService(DBContext dbcontext, Repository repository ,Sort sorts) : IUserService
    {
        public async Task<Customer> AddCustomer(AddCustomerRequest request)
        {
            var customerModel = new CustomerModel
            {
                Email = request.Email,
                Name = request.Name,
                Password = request.Password
            };

            await dbcontext.Customers.AddAsync(customerModel);
            await dbcontext.SaveChangesAsync();

            return customerModel.ToDto();
        }

        public async Task <Customer[]> GetCustomers()
        {
           var customerModels = await repository.GetCustomers();

            var customerDtos = customerModels.Select(c => c.ToDto()).ToArray();

            return customerDtos;

        }

        public async Task<NewMiddleware> GetNewMiddleware(HttpContext context, RequestDelegate request)
        {
            return await GetNewMiddleware(context, request);
        }

        public async Task<string> LoginUser()
        {
            throw new NotImplementedException();
        }

        public async Task<Order[]> Order()
        {
            return await sorts.GetSortedOrders();
        }
    }
}
