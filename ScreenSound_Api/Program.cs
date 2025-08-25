using Screen_Sound.Banco;
using Screen_Sound.Models;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
var app = builder.Build();

app.MapGet("/Bandas", () =>
{
    var bandas = new DAL<Banda>(new ScreenSoundContext());
    IEnumerable<Banda> bandasEncontradas = bandas.Listar();

    if (bandasEncontradas is null)
        return Results.NotFound();
    else
        return Results.Ok(bandasEncontradas);
});

app.MapGet("/Bandas/{nome}", (string nome) =>
{
    var bandas = new DAL<Banda>(new ScreenSoundContext());
    Banda banda = bandas.ObterPor(banda => banda.Nome.ToUpper().Equals(nome.ToUpper()));

    if (banda is null)
        return Results.NotFound();
    else
        return Results.Ok(banda);
});

app.Run();
