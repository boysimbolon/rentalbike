using Microsoft.EntityFrameworkCore;
using RentalMotorAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Tambahkan koneksi database MySQL
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<RentalContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// Tambahkan controller dan Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ✅ Tambahkan CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// Gunakan Swagger di semua environment
app.UseSwagger();
app.UseSwaggerUI();

// ✅ Aktifkan CORS
app.UseCors("AllowAll");

// Middleware lainnya
// app.UseHttpsRedirection(); // aktifkan jika kamu menggunakan HTTPS
app.UseAuthorization();

// Routing ke controller
app.MapControllers();

// Tes endpoint root
app.MapGet("/", () => "API Rental Motor Aktif 🚀");

app.Run();
