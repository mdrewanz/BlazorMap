using BlazorMapper.Data;
using BlazorMapper.Profiles;
using BlazorMapper.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddAutoMapper(options =>
                            {
                                options.AddProfile<PreOrderProfile>();
                            });


// data + services
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddScoped<IPreOrderService, PreOrderService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
