using Microsoft.Extensions.DependencyInjection;

namespace ConsoleTemplate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            var startup = new Startup();
            startup.ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();



            //Test
            var testClass = serviceProvider.GetRequiredService<ITestClass>();
            testClass.TestMethode();
            
            Console.ReadKey();
        }
    }
}