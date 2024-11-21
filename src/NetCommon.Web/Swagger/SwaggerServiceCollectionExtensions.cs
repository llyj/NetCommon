using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace NetCommon.Web.Swagger
{
    public static class SwaggerServiceCollectionExtensions
    {
        private static SwaggerConfig _swaggerConfig;

        public static IServiceCollection AddSwagger(this IServiceCollection services, SwaggerConfig? swaggerConfig)
        {
            if (swaggerConfig != null)
            {
                _swaggerConfig = swaggerConfig;
            }

            if (_swaggerConfig.IsEnable)
            {
                //配置swagger
                services.AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("v1", new OpenApiInfo
                    {
                        Title = $"{Assembly.GetEntryAssembly().GetName().Name}",
                        Description = $"API for {Assembly.GetEntryAssembly().GetName().Name}",
                        Version = "v1",
                        Contact = new OpenApiContact() { Name = "", Email = "" }
                    });

                    //var xmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{_swaggerConfig.WebApiProjectName!}.xml");
                    //c.IncludeXmlComments(xmlPath);
                    //var xmlPath_entity = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{_swaggerConfig.EntityProjectName!}.xml");
                    //c.IncludeXmlComments(xmlPath_entity);
                    c.CustomSchemaIds((type) => type.FullName);

                    // 启用特性支持
                    c.EnableAnnotations();

                    #region JWTToken

                    c.AddSecurityDefinition("bearerAuth", new OpenApiSecurityScheme()
                    {
                        Type = SecuritySchemeType.Http,
                        Name = "Authorization",
                        Scheme = "Bearer",
                        In = ParameterLocation.Header,
                        BearerFormat = "JWT",
                        Description = "JWT Token"
                    });
                    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                    {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "bearerAuth" }
                        },
                        new string[] {  }
                    }
                    });

                    #endregion JWTToken
                });
            }

            return services;
        }

        public static IApplicationBuilder UseSwaggerService(this IApplicationBuilder app)
        {
            if (_swaggerConfig.IsEnable)
            {
                // AccessToken存在时自动添加到 Header 里
                if (!string.IsNullOrEmpty(_swaggerConfig.AccessToken))
                {
                    app.Use((httpContext, next) =>
                    {
                        if (!httpContext.Request.Headers["Authorization"].Any())
                        {
                            httpContext.Request.Headers["Authorization"] = $"Bearer {_swaggerConfig.AccessToken}";
                        }
                        return next();
                    });
                }

                app.UseSwagger();

                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", $"{Assembly.GetEntryAssembly().GetName().Name} V1");
                });
            }

            return app;
        }
    }
}