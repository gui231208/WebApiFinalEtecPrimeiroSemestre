using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiFinalEtecPrimeiroSemestre.Models;

namespace WebApiFinalEtecPrimeiroSemestre.Data
{
    public class WebApiFinalEtecPrimeiroSemestreContext : DbContext
    {
        public WebApiFinalEtecPrimeiroSemestreContext (DbContextOptions<WebApiFinalEtecPrimeiroSemestreContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiFinalEtecPrimeiroSemestre.Models.Produtos> Produtos { get; set; } = default!;
    }
}
