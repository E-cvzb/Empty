var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();



app.MapControllerRoute(
     name: "Default",
     pattern: "{controller=Home}/{action=Index}");
app.Run();

// controller view dosyas�na gitmeden �nce tetiklenen verileri kontrol ederek y�nlendirir 
// Action asl�nda bir metottur view dosyas�na gitmek i�in bize yard�mc� olur 
// Model verilerin bulundu�u dosyad�r 
// View son kullan�caya g�sterieln  ekrana gitmeyi sa�layan dosyad�r
// Razor c# ve HTML kodalr�n�n entegre bir �ekilde �al��mas�n� sa�lar 
// wwwroot taray�c� ile kodlar aras�nda ba�lant� sa�layan yap�
//  builder.Build() tasar�m nesnesi olu�turmaya ba�lamam�z� sa�lar 
// run.Build() uygulaman�n ba�lamas� i�in gerereklidir 