using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using QuizKnock12Hour.Models;

namespace QuizKnock12Hour.Pages
{
	public class IndexModel : PageModel
	{
		private readonly QuizKnock12Hour.Models.qk12hContext _context;

		public IndexModel(QuizKnock12Hour.Models.qk12hContext context)
		{
			_context = context;
		}

		public IList<Players> Players { get; set; }

		public async Task OnGetAsync()
		{
			Players = await _context.Players.ToListAsync();
		}
	}
}
