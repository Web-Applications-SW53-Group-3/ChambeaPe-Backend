using _1._API.Mapper;
using _2._Domain.Employers;
using _2._Domain.Advertisements;
using _2._Domain.Certificates;
using _2._Domain.Portfolios;
using _2._Domain.Skills;
using _2._Domain.Users;
using _2._Domain.Workers;
using _3._Data.Advertisements;
using _3._Data.Certificates;
using _3._Data.Context;
using _3._Data.Employers;
using _3._Data.Portfolios;
using _3._Data.Skills;
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


builder.Services.AddScoped<IEmployerData, EmployerMySQLData>();
builder.Services.AddScoped<IEmployerDomain, EmployerDomain>();

builder.Services.AddScoped<IAdvertisementData, AdvertisementMySQLData>();
builder.Services.AddScoped<IAdvertisementDomain, AdvertisementDomain>();

builder.Services.AddScoped<IPortfolioData, PortfolioMySQLData>();
builder.Services.AddScoped<IPortfolioDomain, PortfolioDomain>();

builder.Services.AddScoped<ISkillData, SkillMySQLData>();
builder.Services.AddScoped<ISkillDomain, SkillDomain>();

builder.Services.AddScoped<ICertificateData, CertificateMySQLData>();
builder.Services.AddScoped<ICertificateDomain, CertificateDomain>();


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

app.UseCors(builder =>
{
    builder.AllowAnyOrigin();
    builder.AllowAnyMethod();
    builder.AllowAnyHeader();
});

app.UseAuthorization();

app.MapControllers();

app.Run();
