var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

// Controller: MVC mimarisinde, gelen kullanýcý isteklerini karþýlayan ve gerekli iþlemleri yöneten bir bileþendir. 
// Model ve View arasýnda bir köprü görevi görür. Ýþ kurallarýný ve iþ mantýðýný kontrol eder.

// Action: Controller içindeki bir metot olarak tanýmlanýr ve belirli bir iþlemi gerçekleþtirir.
// Örneðin, bir sayfayý göstermek ya da bir formdan gelen veriyi iþlemek için kullanýlýr.

// Model: Uygulamanýn veri katmanýný temsil eder. Veritabaný veya baþka veri kaynaklarýndan gelen
// bilgileri alýr ve View ile paylaþýr. Ayrýca, veriler üzerinde doðrulama gibi iþlemleri de içerir.

// View: Kullanýcýya gösterilen arayüzdür. HTML, CSS ve Razor syntax ile tasarlanýr.
// Model'den gelen veriler bu katmanda görselleþtirilir.

// Razor: View'ler içinde kullanýlan bir þablon motorudur. 
// C# kodunu HTML ile birlikte kullanarak dinamik sayfalar oluþturmayý saðlar.

// RazorView: Razor motoru kullanýlarak oluþturulan View'lerdir.
// Bu dosyalar genellikle .cshtml uzantýlýdýr ve dinamik içerik oluþturur.

// wwwroot: Uygulamanýn statik dosyalarýnýn (CSS, JavaScript, resimler, vb.) yer aldýðý klasördür.
// Kullanýcýlar doðrudan bu klasördeki dosyalara eriþebilir.

// builder.Build(): Uygulama yapýlandýrmasýný tamamlar ve bir IHost nesnesi oluþturur.
// Bu nesne, uygulamanýn çalýþmasýný saðlayan temel yapý taþýdýr.

// app.Run(): Uygulamayý baþlatýr ve gelen HTTP isteklerini dinlemeye baþlar.
// Uygulamanýn yaþam döngüsünün baþladýðý noktadýr.

//Yorumlarý kýsmýnda derleyici olarak Chat GPT kullandým, daha anlamlý yazsýn diye:) 