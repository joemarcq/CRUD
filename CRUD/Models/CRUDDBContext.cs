using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class CRUDDBContext : DbContext
    {
        public CRUDDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
    }
}
