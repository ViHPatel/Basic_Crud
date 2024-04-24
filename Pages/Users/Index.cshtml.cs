using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BasicCRUD.Data;
using BasicCRUD.Model;

namespace BasicCRUD.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly BasicCRUD.Data.BasicCRUDContext _context;

        public IndexModel(BasicCRUD.Data.BasicCRUDContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
