using Microsoft.OpenApi.Models;
using System.Reflection;

namespace ReDocSample;

public static class SwaggerServices
{
    /// <summary>
    /// Add Swagger services to the application.
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1",
                new OpenApiInfo
                {
                    Title = "Swagger Demo Documentation",
                    Version = "v1",
                    Description = "This is a demo to see how documentation can easily be generated for ASP.NET Core Web APIs using Swagger and ReDoc.",
                    Contact = new OpenApiContact
                    {
                        Name = "weiyi lai",
                        Email = "joy777park@gmail.com"
                    }
                });

            string xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            string xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            options.IncludeXmlComments(xmlPath);
            options.EnableAnnotations();
        });

        return services;
    }
}
