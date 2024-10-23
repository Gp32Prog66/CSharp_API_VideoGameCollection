using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace VideoGameCollection.DB;

public record Consoles
{
    public int Id {get; set;}
    public string ? Name { get; set; }

    public string ? Manufacturer { get; set; }

    public int Release_Year { get; set; }
}

public record Games
{
    public int Id {get; set;}

    public string ? Title { get; set; }

    public string ? System_Name { get; set; }

    public string ? Publisher { get; set; }
}

public record Controllers
{
    public int Id {get; set;}

    public bool Accessory {get; set;}

    public bool Controller {get; set;}

    public string ? Manufacturer {get; set;}

    public string ? Console_Name {get; set;}

    public string ? Description {get; set;}
}

public class VideoGameDB
{
    private static List<Consoles> _consoles = new List<Consoles>()
    {
        new Consoles { Id = 1, Name="Playstation 2", Manufacturer="Sony", Release_Year = 2000},
        new Consoles { Id = 2, Name="Nintendo 64", Manufacturer="Nintendo", Release_Year = 1996},
        new Consoles { Id = 3, Name="Atari 2600", Manufacturer="Atari", Release_Year = 1977},
        new Consoles { Id = 4, Name="Sega Genesis", Manufacturer="Sega", Release_Year = 1989},
        new Consoles { Id = 5, Name="Xbox 360", Manufacturer="Microsoft", Release_Year = 2005},
        new Consoles { Id = 6, Name="Wii U", Manufacturer="Nintendo", Release_Year = 2012},
        new Consoles { Id = 7, Name="Colecovision", Manufacturer="Coleco", Release_Year = 1982}
    };

    private static List<Games> _games = new List<Games>()
    {
        new Games { Id=1, Title="Super Mario Bros.", System_Name="Nintendo Entertainment System", Publisher="Nintendo"},
        new Games { Id=2, Title="Doom", System_Name="PC", Publisher="ID Software"},
        new Games { Id=3, Title="Saints Row", System_Name="Xbox 360", Publisher="THQ"},
        new Games { Id=4, Title="Sonic The Hedgehog", System_Name="Sega Genesis", Publisher="Sega"},
        new Games { Id=5, Title="Grand Theft Auto III", System_Name="Playstation 2", Publisher="Rockstar Games"},
        new Games { Id=6, Title="Ratchet & Clank", System_Name="Playstation 2", Publisher="Sony Computer Entertainment"},
        new Games { Id=7, Title="Call of Duty Black Ops", System_Name="Xbox 360", Publisher="Activision"},
        new Games { Id=8, Title="The Sims", System_Name="PC", Publisher="Electronic Arts"},
        new Games { Id=9, Title="Castlevania", System_Name="Nintendo Entertainment System", Publisher="Konami"},
        new Games { Id=10, Title="Final Fantasy VI", System_Name="Super Famicom", Publisher="Squaresoft"},
        new Games { Id=11, Title="Hexen: Beyond Heretic", System_Name="PC", Publisher="Broderbund"},
        new Games { Id=12, Title="Donkey Kong", System_Name="Colecovision", Publisher="Coleco"},
        new Games { Id=13, Title="LittleBigPlanet", System_Name="Playstation 3", Publisher="Sony Interactive Entertainment"},
        new Games { Id=14, Title="Tetris", System_Name="Nintendo Entertainment System", Publisher="Nintendo"},
        new Games { Id=15, Title="Ant Attack", System_Name="Commodore 64", Publisher="Softsolid 3D"},
        new Games { Id=16, Title="Cybermorph", System_Name="Atari Jaguar", Publisher="Atari Corporation"},
        new Games { Id=17, Title="Bomberman", System_Name="Nintendo Entertainment System", Publisher="Hudson Soft"},
        new Games { Id=18, Title="Shinobi", System_Name="Sega Master System", Publisher="Sega"},
        new Games { Id=19, Title="Super Mario Bros. 2", System_Name="Nintendo Entertainment System", Publisher="Nintendo"},
        new Games { Id=20, Title="Super Mario World", System_Name="SNES", Publisher="Nintendo"}
    };

        private static List<Controllers> _controllers = new List<Controllers>()
    {
        new Controllers { Id=1, Accessory= false, Controller = true, Manufacturer="Nintendo", Console_Name="Snes", Description="Official Super Nintendo Controller"},
        new Controllers { Id=2, Accessory= false, Controller = true, Manufacturer="Microsoft", Console_Name="Xbox 360", Description="Official Xbox 360 Controller"},
        new Controllers { Id=3, Accessory= false, Controller = true, Manufacturer="Suncala", Console_Name="Playstation 2", Description="Third Party Playstation 2 Controller"},
        new Controllers { Id=4, Accessory= false, Controller = true, Manufacturer="FIOTOK", Console_Name="Nintendo GameCube", Description="Third Party Nintendo GameCube Controller"},
        new Controllers { Id=5, Accessory= false, Controller = true, Manufacturer="Samfox", Console_Name="Atari 2600", Description="Aftermarket Atari 2600 Controller"},
        new Controllers { Id=6, Accessory= true, Controller = false, Manufacturer="Konami", Console_Name="Playstation 2", Description="Dance Dance Revolution Pad"},
        new Controllers { Id=7, Accessory= true, Controller = false, Manufacturer="Nintendo", Console_Name="Nes", Description="NES Zapper"},
        new Controllers { Id=8, Accessory= true, Controller = false, Manufacturer="Nintendo", Console_Name="Snes", Description="Super Scope"},
        new Controllers { Id=9, Accessory= true, Controller = false, Manufacturer="Microsoft", Console_Name="Xbox 360", Description="Kinect"},
        new Controllers { Id=10,Accessory= true, Controller = false, Manufacturer="Nintendo", Console_Name="Wii", Description="Wii Fit Board"},
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

    public static Consoles UpdateConsole(Consoles update)
    {
        _consoles = _consoles.Select(console =>
        {
            if (console.Id == update.Id)
            {
                console.Name = update.Name;
            }
            return console;
        }).ToList();
        return update;
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
        return _games.SingleOrDefault(game => game.Id == id);
    }

    public static Games AddGame(Games games)
    {
        _games.Add(games);
        return games;
    }

    public static Games UpdateGame(Games update)
    {
        _games = _games.Select(game =>
        {
            if (game.Id == update.Id)
            {
                game.Title = update.Title;
            }
            return game;
        }).ToList();
        return update;
    }

    public static void RemoveGame(int id)
    {
        _games = _games.FindAll(game => game.Id != id).ToList();
    }

        public static List<Games> GetControllers()
    {
        return _games;
    }

     public static Controllers ? GetControllers(int id)
    {
        return _controllers.SingleOrDefault(controller => controller.Id == id);
    }

    public static Controllers AddController(Controllers controllers)
    {
        _controllers.Add(controllers);
        return controllers;
    }

    public static Controllers UpdateGame(Controllers update)
    {
        _controllers = _controllers.Select(controller =>
        {
            if (controller.Id == update.Id)
            {
                controller.Console_Name = update.Console_Name;
            }
            return controller;
        }).ToList();
        return update;
    }

    public static void RemoveController(int id)
    {
        _controllers = _controllers.FindAll(controller => controller.Id != id).ToList();
    }
}