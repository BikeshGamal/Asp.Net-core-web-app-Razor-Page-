using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razor_crud.Model;

namespace razor_crud.Data
{
    public class razor_crudContext : DbContext
    {
        public razor_crudContext (DbContextOptions<razor_crudContext> options)
            : base(options)
        {
        }

        public DbSet<razor_crud.Model.Student> Student { get; set; } = default!;
    }
}
