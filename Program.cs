using Microsoft.EntityFrameworkCore;
using Store.Data;

var builder = WebApplication.CreateBuilder(args);

// Получаем строку подключения из конфигурации
var connectionString = builder.Configuration.GetSection("Database:ConnectionStrings:DefaultConnection").Value;

// Добавляем DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

var app = builder.Build();

app.Run();