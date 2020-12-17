using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cojocaru_Stefan_Lab6.Models;

namespace Cojocaru_Stefan_Lab6.Data
{
    public class Cojocaru_Stefan_Lab6Context : DbContext
    {
        public Cojocaru_Stefan_Lab6Context (DbContextOptions<Cojocaru_Stefan_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Cojocaru_Stefan_Lab6.Models.Book> Book { get; set; }
    }
}
