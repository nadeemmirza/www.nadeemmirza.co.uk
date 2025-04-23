namespace EmptyWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            // Serve static files and set index.html as the default startup file
            app.UseDefaultFiles();
            app.UseStaticFiles();

            //// Add default files configuration
            //var defaultFilesOptions = new DefaultFilesOptions();
            //defaultFilesOptions.DefaultFileNames.Clear();
            //defaultFilesOptions.DefaultFileNames.Add("index.html");
            //app.UseDefaultFiles(defaultFilesOptions);


            app.Run();
        }
    }
}

//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;
//using System.Collections.Generic;

//namespace EmptyWebApp
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            var builder = WebApplication.CreateBuilder(args);

//            // Add services to the container (equivalent to ConfigureServices in Startup.cs)
//            builder.Services.AddControllers();

//            // New .NET 9 features - add observability
//            builder.Services.AddOpenTelemetry()
//                .WithTracing(tracing => tracing
//                    .AddAspNetCoreInstrumentation()
//                    .AddHttpClientInstrumentation())
//                .WithMetrics(metrics => metrics
//                    .AddAspNetCoreInstrumentation()
//                    .AddHttpClientInstrumentation());

//            // Enhanced performance options
//            builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options =>
//            {
//                options.SerializerOptions.DefaultIgnoreCondition =
//                    System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
//            });

//            var app = builder.Build();

//            // Configure the HTTP request pipeline (equivalent to Configure in Startup.cs)
//            if (app.Environment.IsDevelopment())
//            {
//                app.UseDeveloperExceptionPage();
//            }

//            app.UseHttpsRedirection();
//            app.UseStaticFiles();

//            // Add default files configuration
//            var defaultFilesOptions = new DefaultFilesOptions();
//            defaultFilesOptions.DefaultFileNames.Clear();
//            defaultFilesOptions.DefaultFileNames.Add("index.html");
//            app.UseDefaultFiles(defaultFilesOptions);

//            app.UseRouting();

//            app.MapControllers();

//            // .NET 9 health checks
//            app.MapHealthChecks("/health");

//            //await app.RunAsync();
//            app.Run();
//        }
//    }
//}


