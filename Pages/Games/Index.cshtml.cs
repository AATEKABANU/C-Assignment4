using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AAssignment_4.Data;
using AAssignment_4.Models;

namespace AAssignment_4.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly AAssignment_4.Data.AppDbContext _context;

        public IndexModel(AAssignment_4.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; }

        public async Task OnGetAsync()
        {
            Game = await _context.Game.ToListAsync();
        }
    }
}
