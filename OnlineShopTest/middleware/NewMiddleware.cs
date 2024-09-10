
namespace OnlineShopTest.middleware
{
    public class NewMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate request)
        {
            await context.Response.WriteAsync("This is first test");
            await request(context);
            await context.Response.WriteAsync("finished");
        }
    }
    public static class Middleware
    { 
        public static IApplicationBuilder Extension(this IApplicationBuilder app)
        {
            return app.UseMiddleware<NewMiddleware>();
        }
    }
}


