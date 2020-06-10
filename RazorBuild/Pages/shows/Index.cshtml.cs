using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorBuild.Pages.shows
{
    public class IndexModel : PageModel
    {
        public List<Show> shows { get; set; }
        public void OnGet()
        {
            this.shows = DataService.GetShows();
        }
    }
}