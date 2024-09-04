var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();



app.MapControllerRoute(
     name: "Default",
     pattern: "{controller=Home}/{action=Index}");
app.Run();

// controller view dosyasýna gitmeden önce tetiklenen verileri kontrol ederek yönlendirir 
// Action aslýnda bir metottur view dosyasýna gitmek için bize yardýmcý olur 
// Model verilerin bulunduðu dosyadýr 
// View son kullanýcaya gösterieln  ekrana gitmeyi saðlayan dosyadýr
// Razor c# ve HTML kodalrýnýn entegre bir þekilde çalýþmasýný saðlar 
// wwwroot tarayýcý ile kodlar arasýnda baðlantý saðlayan yapý
//  builder.Build() tasarým nesnesi oluþturmaya baþlamamýzý saðlar 
// run.Build() uygulamanýn baþlamasý için gerereklidir 