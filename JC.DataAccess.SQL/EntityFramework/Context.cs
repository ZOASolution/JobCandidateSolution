using JC.DataAccess.Contracts.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JC.DataAccess.SQL.EntityFramework
{
    internal class Context:DbContext
    {
        public Context()
        {
            
        }
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<CandidateModel> Candidates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

