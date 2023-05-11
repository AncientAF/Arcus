
using Arcus.Data;
using Arcus.Repositories;
using Arcus.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;

namespace Arcus
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var ArcusFrontend = "_arcusFrontend";

            var builder = WebApplication.CreateBuilder(args);


            // Add services to the container.
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                                      policy =>
                                      {
                                          policy.WithOrigins("http://localhost:3000")
                                                              .AllowAnyHeader()
                                                              .AllowAnyMethod();
                                      });
            });

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContextPool<ArcusDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("ArcusDbConnection")));

            builder.Services.AddScoped<IBlogRepository, BlogRepository>();

            var app = builder.Build();

            app.UseFileServer(new FileServerOptions
            {
                EnableDirectoryBrowsing = true,
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"Data\Assets")),
                RequestPath = new PathString("/files"),
                EnableDefaultFiles = false
            });

            app.UseCors();

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
        }
    }
}