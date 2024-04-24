using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BasicCRUD.Model;

namespace BasicCRUD.Data
{
    public class BasicCRUDContext : DbContext
    {
        public BasicCRUDContext (DbContextOptions<BasicCRUDContext> options)
            : base(options)
        {
        }

        public DbSet<BasicCRUD.Model.User> User { get; set; } = default!;
    }
}
