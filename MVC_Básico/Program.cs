var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//Activamos el uso de la memoria RAM como una memoria estatica para que no se a volatil
//cuando la sesion acabe se borra de la memoria. 
builder.Services.AddDistributedMemoryCache();

//Con esto establecemos la duracion de la sesion. 
builder.Services.AddSession(
        options =>
        {
            options.IdleTimeout = TimeSpan.FromMinutes(30);
        }
    );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

//Con esto activamos el uso de la sesion y hay que colocarlo justo despues de app.UseRouting();
app.UseSession();

app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Usuarios}/{action=Index}/{id?}");

app.Run();
