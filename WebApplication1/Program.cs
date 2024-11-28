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

// Controller: MVC mimarisinde, gelen kullan�c� isteklerini kar��layan ve gerekli i�lemleri y�neten bir bile�endir. 
// Model ve View aras�nda bir k�pr� g�revi g�r�r. �� kurallar�n� ve i� mant���n� kontrol eder.

// Action: Controller i�indeki bir metot olarak tan�mlan�r ve belirli bir i�lemi ger�ekle�tirir.
// �rne�in, bir sayfay� g�stermek ya da bir formdan gelen veriyi i�lemek i�in kullan�l�r.

// Model: Uygulaman�n veri katman�n� temsil eder. Veritaban� veya ba�ka veri kaynaklar�ndan gelen
// bilgileri al�r ve View ile payla��r. Ayr�ca, veriler �zerinde do�rulama gibi i�lemleri de i�erir.

// View: Kullan�c�ya g�sterilen aray�zd�r. HTML, CSS ve Razor syntax ile tasarlan�r.
// Model'den gelen veriler bu katmanda g�rselle�tirilir.

// Razor: View'ler i�inde kullan�lan bir �ablon motorudur. 
// C# kodunu HTML ile birlikte kullanarak dinamik sayfalar olu�turmay� sa�lar.

// RazorView: Razor motoru kullan�larak olu�turulan View'lerdir.
// Bu dosyalar genellikle .cshtml uzant�l�d�r ve dinamik i�erik olu�turur.

// wwwroot: Uygulaman�n statik dosyalar�n�n (CSS, JavaScript, resimler, vb.) yer ald��� klas�rd�r.
// Kullan�c�lar do�rudan bu klas�rdeki dosyalara eri�ebilir.

// builder.Build(): Uygulama yap�land�rmas�n� tamamlar ve bir IHost nesnesi olu�turur.
// Bu nesne, uygulaman�n �al��mas�n� sa�layan temel yap� ta��d�r.

// app.Run(): Uygulamay� ba�lat�r ve gelen HTTP isteklerini dinlemeye ba�lar.
// Uygulaman�n ya�am d�ng�s�n�n ba�lad��� noktad�r.

//Yorumlar� k�sm�nda derleyici olarak Chat GPT kulland�m, daha anlaml� yazs�n diye:) 