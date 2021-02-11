using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoApp.Data;
using ToDoApp.Models;

namespace ToDoApp.Pages.ToDos
{
    public class IndexModel : PageModel
    {
        private readonly ToDoAppContext _context;

        public IndexModel(ToDoAppContext context)
        {
            _context = context;
        }
   
        public IList<ToDoItem> ToDoItem { get;set; }

        public async Task OnGetAsync()
        {
            ToDoItem = await _context.ToDoItem.ToListAsync();
        }
    }
}