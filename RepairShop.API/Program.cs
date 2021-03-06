using RepairShop.Application.Interfaces;
using RepairShop.Application.Services;
using RepairShop.Infrastructure.Repositories;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors(opt => opt.AddPolicy("CorsPolicy", c =>
{
    c.AllowAnyOrigin()
       .AllowAnyHeader()
       .AllowAnyMethod();
}));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IGenerateIdService, GenerateIdService>();

builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IGoodsReceiveService, GoodsReceiveService>();
builder.Services.AddScoped <IGoodsReceiveLineService, GoodsReceiveLineService>();
builder.Services.AddScoped<IInvenTranService, InvenTranService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IPurchaseOrderService, PurchaseOrderService>();
builder.Services.AddScoped<IPurchaseOrderLineService, PurchaseOrderLineService>();
builder.Services.AddScoped<ISalesOrderService, SalesOrderService>();
builder.Services.AddScoped<ISalesOrderLineService, SalesOrderLineService>();
builder.Services.AddScoped<IVendorService, VendorService>();


builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IGoodsReceiveRepository, GoodsReceiveRepository>();
builder.Services.AddScoped<IGoodsReceiveLineRepository, GoodsReceiveLineRepository>();
builder.Services.AddScoped<IInvenTranRepository, InvenTranRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddScoped<IPurchaseOrderRepository, PurchaseOrderRepository>();
builder.Services.AddScoped<IPurchaseOrderLineRepository, PurchaseOrderLineRepository>();
builder.Services.AddScoped<ISalesOrderRepository, SalesOrderRepository>();
builder.Services.AddScoped<ISalesOrderLineRepository, SalesOrderLineRepository>();
builder.Services.AddScoped<IVendorRepository, VendorRepository>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("CorsPolicy");
app.UseAuthorization();

app.MapControllers();

app.Run();
