using NLog.Extensions.Logging;
using NLog.Web;
using Admin_Data.DataContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Host.UseNLog();

// Add services to the container.
builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
 builder.Services.AddEndpointsApiExplorer();
 builder.Services.AddSwaggerGen();
 builder.Services.AddDbContext<AdminDBContext>(options => options.UseSqlServer(
     builder.Configuration.GetConnectionString("SQL")
     ));

   

    var app = builder.Build();

    app.UseCors(options => 
    options.WithOrigins("http://localhost:3000")
    .AllowAnyMethod()
    .AllowAnyHeader());

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

