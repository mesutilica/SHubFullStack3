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
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run(); // uygulamayı yukarıdaki ayarlara göre çalıştır
        }
    }
}
