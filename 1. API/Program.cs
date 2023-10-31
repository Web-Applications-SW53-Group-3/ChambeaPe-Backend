using _1._API.Mapper;
using _2._Domain.Users;
using _2._Domain.Workers;
using _3._Data.Context;
using _3._Data.Users;
using _3._Data.Workers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUserData, UserMySQLData>();
builder.Services.AddScoped<IUserDomain, UserDomain>();

builder.Services.AddScoped<IWorkerData, WorkerMySQLData>();
builder.Services.AddScoped<IWorkerDomain, WorkerDomain>();

var connectionString = builder.Configuration.GetConnectionString("ChambeaPeDB");
builder.Services.AddDbContext<ChambeaPeContext>(
    dbContextOptions =>
    {
        dbContextOptions.UseMySql(connectionString,
            ServerVersion.AutoDetect(connectionString),
            options => options.EnableRetryOnFailure(
                maxRetryCount: 5,
                maxRetryDelay: System.TimeSpan.FromSeconds(30),
                errorNumbersToAdd: null
                ));
    }
    );

builder.Services.AddAutoMapper(
        typeof(ModelToAPI),
        typeof(APIToModel)
);

builder.Logging.AddFile("Logs/chambeape-{Date}.txt", 
    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}");

var app = builder.Build();

using (var scope = app.Services.CreateScope())
using (var context = scope.ServiceProvider.GetService<ChambeaPeContext>())
{
    context.Database.EnsureCreated();
}

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
