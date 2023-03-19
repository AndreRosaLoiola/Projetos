using Mapeamento.Data;
using Microsoft.EntityFrameworkCore;
using ProejtoApiAndre.Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddEntityFrameworkSqlServer().AddDbContext<DB_ESTUDO>(Options => Options.UseSqlServer("Data Source=NOTEANDRE\\SQLEXPRESS;Initial Catalog=DB_ESTUDO;Integrated Security=True"));
builder.Services.AddScoped<IRepositorio, Repositorio>();


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
