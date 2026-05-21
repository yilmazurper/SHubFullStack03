namespace NetCoreMVCEgitimi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews(); //uygulamada MVC controller view yapisnizi kullanacagiz

            var app = builder.Build(); // calisacak olan uygulama ornegi

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection(); // http den ye otamatik yonlendirme yap
            app.UseRouting(); // uuygulamada routing mekanizmainisi aktif et

            app.UseAuthorization(); // uygulamada yetkilendirme kullanimini aktig et

            app.MapStaticAssets(); // uygulamada static dosyalar( wwwroot icerisindekiler) kullanabilsin
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();// uygulamayi yukaridaki ayarlara gore calistir
        }
    }
}
