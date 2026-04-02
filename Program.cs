using FinanceSee.Data;
using Microsoft.EntityFrameworkCore;
using PjtFinanceSee.Profiles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddAutoMapper(typeof(FinancialGoalProfile));
builder.Services.AddAutoMapper(typeof(BudgetProfile));
builder.Services.AddAutoMapper(typeof(UserProfile));
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer("DefaultConnection"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
