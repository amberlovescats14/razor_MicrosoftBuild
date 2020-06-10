using System;
using System.Collections.Generic;

namespace RazorBuild
{
    public static class DataService
    {
        private static List<Show> shows { get; set; }

        // constructor
        static DataService()
        {
            shows = new List<Show>()
            {
                new Show{Title = "Mrs. Maisal", StreamingService = "Amazon", Description = "women"},
                new Show {Title = "Peaky Blinders", StreamingService = "Netflix", Description = "foreign"},
                new Show {Title = "Mandalorian", StreamingService = "Disney+", Description = "star wars"}
            };
        }

        public static List<Show> GetShows()
        {
            return shows;
        }
    }
}
