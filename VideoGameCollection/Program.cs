using Microsoft.OpenApi.Models;
using VideoGameCollection.DB;

//Creating Builder
var builder = WebApplication.CreateBuilder(args);

//Allows Swagger,CORS, and Entity Framework
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
     c.SwaggerDoc("V1", new OpenApiInfo {Title = "VideoGame API", Description = "Keeping Track of the Consoles and Video Games in the Collection", Version = "v1"});
});



var app = builder.Build();

//Call the app to use swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Video Game Collection V1");
    });
}



app.MapGet("/", () => "C# API Demo!");




//Basic Middleware example
//app.UseCors("MiddleWare Test");

//Maps and Getters

/*** Consoles ***/
app.MapGet("/consoles/{id}", (int id) => VideoGameDB.GetConsole(id));
app.MapGet("/consoles", () => VideoGameDB.GetConsoles());
app.MapPost("/consoles", (Consoles console) => VideoGameDB.AddConsole(console));
app.MapPut("/consoles", (Consoles console) => VideoGameDB.UpdateConsole(console));
app.MapDelete("/consoles/{id}", (int id) => VideoGameDB.RemoveConsole(id));

/*** Games ***/

app.MapGet("/games/{id}", (int id) => VideoGameDB.GetGame(id));
app.MapGet("/games", () => VideoGameDB.GetGames());
app.MapPost("/games", (Games game) => VideoGameDB.AddGame(game));
app.MapPut("/games", (Games game) => VideoGameDB.UpdateGame(game));
app.MapDelete("/games/{id}", (int id) => VideoGameDB.RemoveGame(id));


/*** Controllers/Accessories ***/

app.MapGet("/controllers/{id}", (int id) => VideoGameDB.GetGame(id));
app.MapGet("/controllers", () => VideoGameDB.GetGames());
app.MapPost("/controllers", (Games game) => VideoGameDB.AddGame(game));
app.MapPut("/controllers", (Games game) => VideoGameDB.UpdateGame(game));
app.MapDelete("/controllers/{id}", (int id) => VideoGameDB.RemoveGame(id));


//Start API and listen to requests
app.Run();
