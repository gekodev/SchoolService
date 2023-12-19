using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SchoolService.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
options.UseNpgsql( "Host=localhost;Username=postgres;Password=Global.2011;Database=school"));
//options.UseNpgsql("Host = school.postgres.database.azure.com;Username=mrgeko;Password=Global.2011;Database=school"));



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
