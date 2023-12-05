using Microsoft.Extensions.Logging;
using Serilog;
using System.Reflection;
using MongoDB.Driver;

namespace NotificationService
{
    public class Program
    {

        private static string DBPwd = "lkrVRBLJrkVxpH4m";
        private static string DbUri = $"mongodb+srv://teasella:{DBPwd}@minicluster.ivnvrlw.mongodb.net/?retryWrites=true&w=majority";
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddHttpClient();

            var logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();

            builder.Logging.ClearProviders();
            builder.Logging.AddSerilog(logger);

            builder.Services.AddMediatR(x => x.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

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

            MongoClient dbClient = new MongoClient(DbUri);

            var dbList = dbClient.ListDatabases().ToList();

            Console.WriteLine("List of Databases in this server:");

            foreach (var db in dbList)
            {
                Console.WriteLine(db);
            }

            app.Run();
        }
    }
}