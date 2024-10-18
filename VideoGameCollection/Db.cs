using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace VideoGameCollection.DB;

public record Consoles
{
    public int Id {get; set;}
    public string ? Name { get; set; }
}

public record Games
{
    public int Id {get; set;}

    public string ? Name { get; set; }
}

public class VideoGameDB
{
    private static List<Consoles> _consoles = new List<Consoles>()
    {
        new Consoles { Id = 1, Name="Atari 2600"},
        new Consoles { Id = 2, Name="Sega Genesis"}
    };

    private static List<Games> _games = new List<Games>()
    {
        new Games { Id=1, Name="Tetris 2"},
        new Games { Id=2, Name="Wario Woods"}
    };

    public static List<Consoles> GetConsoles()
    {
        return _consoles;
    }

    public static Consoles ? GetConsole(int id)
    {
        return _consoles.SingleOrDefault(console => console.Id == id);
    }

    public static Consoles AddConsole(Consoles console)
    {
        _consoles.Add(console);
        return console;
    }

    public static Consoles UpdateConsole(Consoles console)
    {
        _consoles = _consoles.Select(console =>
        {
            if (console.Id == update.Id)
            {
                console.Name = update.Name;
            }
            return console;
        }).ToList();
    }

    public static void RemoveConsole(int id)
    {
        _consoles = _consoles.FindAll(console => console.Id != id).ToList();
    }

    public static List<Games> GetGames()
    {
        return _games;
    }

     public static Games ? GetGame(int id)
    {
        return _games.SingleOrDefault(games => game.Id == id);
    }

    public static Games AddGames(Games games)
    {
        _consoles.Add(games);
        return game;
    }

    public static Games UpdateGame(Games update)
    {
        _games = _consoles.Select(console =>
        {
            if (game.Id == update.Id)
            {
                game.Name = update.Name;
            }
            return console;
        }).ToList();
    }

    public static void RemoveGame(int id)
    {
        _games = _games.FindAll(console => console.Id != id).ToList();
    }
}