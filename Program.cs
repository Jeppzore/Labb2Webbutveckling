using MongoDB.Driver;
using Microsoft.OpenApi.Models;
using Labb2Webbutveckling.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Configure MongoDB-connection
var mongoClient = new MongoClient("mongodb://localhost:27017");
var database = mongoClient.GetDatabase("ECommerceDb");

// Ensures each customer has an unique email.
var customerRepository = new CustomerRepository(database);
await customerRepository.EnsureIndexesAsync();

builder.Services.AddSingleton<IMongoDatabase>(database);
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddSingleton<IOrderRepository, OrderRepository>();

builder.Services.AddControllers();

// Swagger & OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "E-Commerce API", Version = "v1"});
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
