using Microsoft.EntityFrameworkCore;
using OnlineShopTest.DataBase;


namespace OnlineShopTest.Models
{
    public class Sort
    {
        public async Task <Order[]> GetSortedOrders()
        {
            using (var context = new DBContext())
            {
                return await context.Orders
                    .OrderBy(u => u.Name)
                    .ToArrayAsync();
            }
        }


    }
}
