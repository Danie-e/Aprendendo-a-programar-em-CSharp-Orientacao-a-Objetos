using Screen_Sound.Banco;
using Screen_Sound.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
var app = builder.Build();

app.MapGet("/", () =>
{
    var dal = new DAL<Banda>(new ScreenSoundContext());
    return dal.Listar();
});

app.Run();
