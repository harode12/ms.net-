namespace ConventionalMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.MapControllerRoute(
                name :"user",
                pattern: "{controller=User}/{action=CheckUser}/{un}/{pw}"
                );
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Demo}/{action=Index}/{id?}"
                );
            app.MapControllerRoute(
                name: "sample1",
                pattern: "{ controller=Home}/{ Action = Welcome}/{nm})"
                );

            app.Run();
        }
    }
}
