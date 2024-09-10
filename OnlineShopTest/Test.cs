using OnlineShopTest.DataBase;
using OnlineShopTest.Models;


namespace OnlineShopTest
{
    public class Test
    {
        public static void TestDB()
        {
            var Context = new DBContext();

            Context.Database.EnsureDeleted();
            Context.Database.EnsureCreated();

            List<Item> item = new List<Item>() {

            new Item { Name = " V2ray-OneMonth" , Price = "1$"},
            new Item { Name = " V2ray-2Months" , Price = "2$"},
            new Item { Name = " V2ray-3Months" , Price = "3$"},
            new Item { Name = " V2ray-6Months" , Price = "5$"},
            new Item { Name = " V2ray-OneYear" , Price = "10$"},
            new Item { Name = " V2ray-2Year" , Price = "15$"},
            new Item { Name = " V2ray-3Year" , Price = "20$"}

         };

            Context.Items.AddRange(item);

            Context.SaveChanges();

        }
    }
}
