namespace _2109
{
    public class Program
    {
        public static void Main(string[] args)
        {
			var builder = WebApplication.CreateBuilder(args);

            //https://localhost:7124/User/Index
            builder.Services.AddControllersWithViews();

			var app = builder.Build();

			app.UseHttpsRedirection();
			app.UseRouting();
			app.UseAuthorization();
			app.UseDefaultFiles();
			app.UseStaticFiles();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();

		}
	}
}
