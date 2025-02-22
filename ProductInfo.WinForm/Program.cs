using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductInfo.BLL;
using ProductInfo.DAL;

namespace ProductInfo.WinForm
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var mainForm = serviceProvider.GetRequiredService<ProductForm>();
                Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Build configuration from appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)  // Set base path for configuration
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true) // Add json config file
                .Build();

            // Retrieve connection string from the configuration
            string connectionString = configuration.GetConnectionString("DefaultConnection");

            // Register Dapper Repository
            services.AddSingleton(new ProductRepository(connectionString));

            // Register Business Logic Layer
            services.AddScoped<IProductService,ProductService>();

            // Register Form
            services.AddTransient<ProductForm>();
        }
    }
}