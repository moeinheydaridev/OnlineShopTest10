using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using OnlineShopTest.dependency_Injection;
using OnlineShopTest.Dtos;
using OnlineShopTest.middleware;


namespace OnlineShopTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController(IUserService service) : ControllerBase
    {
        [HttpGet("customers")]
        public async Task<Customer[]> GetCustomers()
        {
            return await service.GetCustomers();
        }
        public async Task<NewMiddleware> GetNewMiddleware(HttpContext context, RequestDelegate request)
        {
            return await service.   (context, request);
        }
  


        [HttpPost("add-customer")]
        public async Task<Customer> AddCustomer(AddCustomerRequest request)
        {
            return await service.AddCustomer(request);
        }
    }
}
