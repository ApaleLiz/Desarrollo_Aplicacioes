using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using p28_crud_universidad.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddScoped<EstudianteServicio>();
builder.Services.AddScoped<CursoServicio>();
builder.Services.AddScoped<InscripcionServicio>();

builder.Services.AddDbContext<ContextoDatos>(options =>
options.UseSqlite(builder.Configuration.GetConnectionString("bdcon")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

using (var scope = app.Services.CreateScope()) {
var servicios = scope.ServiceProvider;
var contexto = servicios.GetRequiredService<ContextoDatos>();
contexto.Database.EnsureCreated();
InicializadorBD.Inicializar(contexto);
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
