using OnlineShopTest.DataBase;
using OnlineShopTest.Models;
using Microsoft.EntityFrameworkCore;

namespace OnlineShopTest.repo
{
    public class Repository(DBContext dbcontext)
    {
        public async Task<CustomerModel[]> GetCustomers()
        {
            var customers = await dbcontext.Customers
                .OrderBy(u => u.Name)
                .ToArrayAsync();
            return customers;
        }
    }
}
