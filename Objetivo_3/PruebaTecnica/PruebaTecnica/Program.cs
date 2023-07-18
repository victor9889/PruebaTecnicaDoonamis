using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Interfaces;
using PruebaTecnica.Models;
using PruebaTecnica.Services;

var builder = WebApplication.CreateBuilder(args);
const string connectionString = "Server=DESKTOP-RBSLFG0\\SQLEXPRESS; Database=PruebaTecnica_DB; Trusted_Connection=True; TrustServerCertificate=True;";


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
//Inyección de los servicios necesarios

//Para probar el registro sin base de datos.
//builder.Services.AddScoped<IUserService, UserServiceFake >();

//Para probar el registro con base de datos
//builder.Services.AddScoped<IUserService, UserService>();
//builder.Services.AddDbContext<PruebaTecnicaDbContext>(options =>
//    options.UseSqlServer(connectionString));

var app = builder.Build();

app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
app.UseAuthorization();

app.MapControllers();

app.Run();

