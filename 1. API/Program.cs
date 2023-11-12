using System.Reflection;
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
using _3._Data.Posts;
using _2._Domain.Posts;
using Microsoft.OpenApi.Models;
using _1._API.Hubs;
using Microsoft.AspNetCore.Authentication.Cookies;
using _3._Data.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "ChambeaPe API",
        Description = "API to manage data for ChambeaPe",
        TermsOfService = new Uri("https://web-applications-sw53-group-3.github.io/Landing-Page/"),
        Contact = new OpenApiContact
        {
            Name = "Example Contact",
            Url = new Uri("https://web-applications-sw53-group-3.github.io/Landing-Page/")
        },
        License = new OpenApiLicense
        {
            Name = "Example License",
            Url = new Uri("https://web-applications-sw53-group-3.github.io/Landing-Page/")
        }
    });

    // using System.Reflection;
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

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

builder.Services.AddScoped<IPostData, PostMySQLData>();
builder.Services.AddScoped<IPostDomain, PostDomain>();

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

builder.Services.AddSignalR();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/account/login";
        options.LogoutPath = "/account/logout";
    });

builder.Services.AddAuthorization();

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
    builder
        .WithOrigins("http://localhost:5173", "https://chambeapeweb.web.app")
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials();
});

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.MapHub<ChatHub>("/chatHub");

app.Run();
