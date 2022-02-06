using Microsoft.AspNetCore.Mvc;
using MinimalApp.Services;
using MinimalApp.Models;
using MinimalApp.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IVideoGameService, VideoGameService>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!159");

app.MapPost("/create",
    (VideoGameModel vgmo, IVideoGameService service) => 
    {
        var result = service.Create(vgmo);
        return Results.Ok(result);
    });

app.MapGet("/get",
    (int id, IVideoGameService service) =>
    {
        var game = service.Get(id);

        if (game == null) return Results.NotFound("Data not found");

        return Results.Ok(game);
    });

app.MapGet("/list",
    (IVideoGameService service) =>
    {
        var games = service.List();

        if (games == null) return Results.NotFound("Data not found");

        return Results.Ok(games);
    });

app.MapPut("/update",
    (VideoGameModel videoGame, IVideoGameService service) =>
    {
        var update = service.Update(videoGame);

        if (update == null) return Results.NotFound("Data not found");

        return Results.Ok(update);
    });

app.MapDelete("/delete",
    (int id, IVideoGameService service) =>
    {
        var result = service.Delete(id);

        if (!result) return Results.BadRequest("something went wrong");

        return Results.Ok(result);
    });

app.Run();
