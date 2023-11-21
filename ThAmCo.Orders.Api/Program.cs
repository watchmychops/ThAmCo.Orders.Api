
using Microsoft.EntityFrameworkCore;
using ThAmCo.Orders.Api.Data;

namespace ThAmCo.Orders.Api {
    public class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<OrderContext>(options => {
                if (builder.Environment.IsDevelopment()) {
                    var folder = Environment.SpecialFolder.LocalApplicationData;
                    var path = Environment.GetFolderPath(folder);
                    var dbPath = System.IO.Path.Join(path, "orders.db");
                    options.UseSqlite($"Data Source={dbPath}");
                    options.EnableDetailedErrors();
                    options.EnableSensitiveDataLogging();
                } else {
                    var cs = builder.Configuration.GetConnectionString("OrderContext");
                    options.UseSqlServer(cs);
                }
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment()) {
                app.UseSwagger();
                app.UseSwaggerUI();
            //}

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
