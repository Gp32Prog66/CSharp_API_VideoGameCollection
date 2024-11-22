using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameCollection.Collection
{
    public static class ConsoleCollection
    {
        private static List<Console> _consoleList = new List<Console> {
            new Console{Id=1, Name = "Console", Manufacturer="PointPark", Release_Year=1999},
            new Console{Id=2, Name = "Console 2", Manufacturer="PointParkGames", Release_Year=1998}
        };
    }
}