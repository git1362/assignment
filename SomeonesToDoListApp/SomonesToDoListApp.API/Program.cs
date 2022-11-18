using SomonesToDoListApp.API.Endpoints;
using SomonesToDoListApp.API.Middlewares;
using SomonesToDoListApp.Infrastrcuture.RegisterServices;
using SomonesToDoListApp.Services.RegisterServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.RegisterApplicationServices()
                .RegisterInfrastructureServices(builder.Configuration);

builder.Services.AddEndpoints<Program>(builder.Configuration);

builder.Services.AddCors(options =>
{
    options.AddPolicy("Open", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseCustomExceptionHandler();
app.UseEndpoints<Program>();
app.UseCors("Open");

app.Run();