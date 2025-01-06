using ArquitecturaEnCapas.Data;
using ArquitecturaEnCapas.Repositories;
using ArquitecturaEnCapas.Repositories.IRepositories;
using ArquitecturaEnCapas.Services;
using ArquitecturaEnCapas.Services.IServices;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


//1. configurar dbContext
builder.Services.AddDbContext<BitacoraContexto>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//2. configurar la inyeccion de dependencias
builder.Services.AddScoped<IBitacoraRepository,BitacoraRepository>();
builder.Services.AddScoped<IBitacoraService, BitacoraService>();

//configurar Autommaper
builder.Services.AddAutoMapper(typeof(Program));


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
