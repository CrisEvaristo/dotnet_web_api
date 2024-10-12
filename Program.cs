
using api.Data;
using Microsoft.EntityFrameworkCore;
namespace api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

         // Configurar a conexão com o banco de dados MySQL
            builder.Services.AddDbContext<DataContext>(options =>
                options.UseMySql(
                    builder.Configuration.GetConnectionString("conexaoMySQL"),
                    new MySqlServerVersion(new Version(10,4,17)) // Especifique a versão do MySQL que você está usando
                ));

            // Add services to the container.
            
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

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
