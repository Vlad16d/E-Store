using Microsoft.EntityFrameworkCore;
using Store.Data;

var builder = WebApplication.CreateBuilder(args);

// Connection string
var connectionString = builder.Configuration.GetSection("Database:ConnectionStrings:DefaultConnection").Value;

// Adding DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

// Adding Controller
builder.Services.AddControllers();
var app = builder.Build();
app.MapControllers();

app.Run();