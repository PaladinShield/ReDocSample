using Microsoft.OpenApi.Models;
using Prometheus;
using ReDocSample;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

if (!builder.Environment.IsProduction())
{
    builder.Services.AddSwagger();
}

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint(
            "/swagger/v1/swagger.json",
            "Swagger Demo Documentation v1"
            );
    });

    app.UseReDoc(options =>
    {
        // default path is api-docs
        options.RoutePrefix = "redoc";
        options.DocumentTitle = "Swagger Demo Documentation";
        options.SpecUrl = "/swagger/v1/swagger.json";
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseHttpMetrics();
// Make sure these calls are made before the call to UseEndPoints.
app.UseMetricServer();

app.MapControllers();

await app.RunAsync();
