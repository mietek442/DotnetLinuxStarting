namespace GameStore.Api.Extensions;

public static class ServiceExtensions
{
   public static void ConfigureCors(this IServiceCollection services)
   {
        services.AddCors(options =>
        {
            options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
        });
    }     
}