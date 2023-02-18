using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Alpaca.Tool.WebAPI.First.Models;

namespace Alpaca.Tool.WebAPI.First.Data
{
    public class AlpacaToolWebAPIFirstContext : DbContext
    {
        public AlpacaToolWebAPIFirstContext (DbContextOptions<AlpacaToolWebAPIFirstContext> options)
            : base(options)
        {
        }

        public DbSet<Alpaca.Tool.WebAPI.First.Models.M_Member> M_Member { get; set; } = default!;
    }
}
