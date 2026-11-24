using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using WorkoutLog.Core.Interfaces;
using WorkoutLog.Core.Services;
using WorkoutLog.Data.Context;
using WorkoutLog.Data.Repositories;
using WorkoutLog.WinForms.Forms;

namespace WorkoutLog.WinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Read the connection string from App.config
            string connectionString =
                ConfigurationManager.ConnectionStrings["WorkoutLogDb"]
                ?.ConnectionString
                ?? throw new InvalidOperationException(
                    "WorkoutLogDb connection string was not found.");

            // Create the DI container
            var services = new ServiceCollection();

            // Register the database context
            services.AddDbContext<WorkoutLogDbContext>(options =>
                options.UseSqlServer(connectionString));

            // Register the repository
            services.AddScoped<IWorkoutRepository, WorkoutRepository>();

            // Register the service
            services.AddScoped<IWorkoutService, WorkoutService>();

            // Register the main form
            services.AddTransient<WorkoutLogForm>();

            // Build the service provider
            using var serviceProvider = services.BuildServiceProvider();

            // Create a scope for the application's lifetime
            using var scope = serviceProvider.CreateScope();

            // Resolve and run the main form
            Application.Run(scope.ServiceProvider.GetRequiredService<WorkoutLogForm>());
        }
    }
}