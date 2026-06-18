using Microsoft.AspNetCore.Authentication.Cookies; // cerez tabnali kimlik dogrulma icin gerekli namespace
namespace NetCoreMVCEgitimi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews(); //uygulamada MVC controller view yapisnizi kullanacagiz
            builder.Services.AddDbContext<Models.UyeContext>(); // uygulamada Dbcontext yapisini kullanacagiz
            builder.Services.AddSession();// uuygulamada session kullanimi aktif et

            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme) // cerez tabnali kimlik kimlik dogtulama kullanicimizii belirtiyoruz
            .AddCookie(Options =>
             {
                 Options.LoginPath = "/MVC15FiltersUsing/Login"; //kullannici login degilse
                 Options.LogoutPath = "/MVC15FiltersUsing/Logout"; // kullanici logout oldugunda
                 Options.AccessDeniedPath = "/MVC15FiltersUsing/AccessDenied"; //kullannici yetkisiz bir erismeye calisirsa yonlendirelecek sayfa
             });

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

            app.UseSession(); // uygulamda aktif et

            app.MapStaticAssets(); // uygulamada static dosyalar( wwwroot icerisindekiler) kullanabilsin
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();// uygulamayi yukaridaki ayarlara gore calistir
        }
    }
}
