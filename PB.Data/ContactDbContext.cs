using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PB.Core;

namespace PB.Data
{
    public class ContactDbContext : DbContext
    {
        public ContactDbContext(DbContextOptions<ContactDbContext> dbContextOptns) : base(dbContextOptns)
        {
        }
        public DbSet<ContactInfo> Contacts { get; set; }
    }
}
