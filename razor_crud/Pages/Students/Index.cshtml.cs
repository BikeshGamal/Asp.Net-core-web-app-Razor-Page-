using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razor_crud.Data;
using razor_crud.Model;

namespace razor_crud.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly razor_crud.Data.razor_crudContext _context;

        public IndexModel(razor_crud.Data.razor_crudContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
