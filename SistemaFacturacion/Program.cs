using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SistemaFacturacionWebApiREST;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var services = builder.Services;
services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnection")));

builder.Services.AddControllers();


var app = builder.Build();

// Configure the HTTP request pipeline.


//services.AddScoped<ConductorServicios>();
//services.AddScoped<BusServicios>();
//services.AddScoped<RutaServicios>();
//services.AddScoped<ParadaServicios>();
//services.AddScoped<EstadoServicios>();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();
