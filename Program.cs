var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
var app = builder.Build();



app.MapGet("/", () => "Hello World!");
app.MapGet("/asd", () => "deneme1");


app.Run();
