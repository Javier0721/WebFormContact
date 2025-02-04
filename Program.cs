using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.Models;

var builder = WebApplication1.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configurar Entity Framework Core
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();