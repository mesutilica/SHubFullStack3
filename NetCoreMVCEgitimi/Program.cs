
using Microsoft.AspNetCore.Authentication.Cookies; // çerez tabanlı kimlik doğrulama için gerekli namespace

namespace NetCoreMVCEgitimi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews(); // Uygulamada MVC controller view yapısını kullanacağız
            builder.Services.AddDbContext<Models.UyeContext>(); // uygulamada DbContext yapısını kullanacağız
            builder.Services.AddSession(); // uygulamada session kullanımını aktif et

            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme) // çerez tabanlı kimlik doğrulama kullanacağımızı belirtiyoruz
                .AddCookie(options =>
                {
                    options.LoginPath = "/MVC15FiltersUsing/Login"; // kullanıcı login değilse yönlendirilecek sayfa
                    options.LogoutPath = "/MVC15FiltersUsing/Logout"; // kullanıcı logout olduğunda yönlendirilecek sayfa
                    options.AccessDeniedPath = "/MVC15FiltersUsing/AccessDenied"; // kullanıcı yetkisiz bir sayfaya erişmeye çalışırsa yönlendirilecek sayfa
                });

            var app = builder.Build(); // çalışacak olan uygulama örneği

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection(); // http den https ye otomatik yönlendire yap
            app.UseRouting();// Uygulamada Routing mekanizmasını aktif et

            app.UseAuthorization();// Uygulamada yetkilendirme kullanımını aktif et

            app.UseSession(); // uygulamada session kullanımını aktif et

            app.MapStaticAssets();// Uygulamada statik doyalar(wwwroot içerisindekiler) kullanılabilsin

            // area kullanabilmek için aşağıdaki kodu yazdık
            app.MapControllerRoute(
                name: "areas",
                pattern: "{area=exists}/{controller=Main}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run(); // uygulamayı yukarıdaki ayarlara göre çalıştır
        }
    }
}
