using OnlineShopTest;
using OnlineShopTest.DataBase;
using OnlineShopTest.dependency_Injection;
using OnlineShopTest.middleware;
using OnlineShopTest.Models;
using OnlineShopTest.repo;
using OnlineShopTest.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DBContext>();
builder.Services.AddScoped<IUserService, LoginService>();
builder.Services.AddScoped<Repository>();
builder.Services.AddScoped<Sort>();
builder.Services.AddScoped<NewMiddleware>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Extension();

app.UseAuthorization();

app.MapControllers();


Test.TestDB();

app.Run();
