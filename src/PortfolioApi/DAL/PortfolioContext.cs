using Microsoft.EntityFrameworkCore;
using PortfolioApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApi.DAL
{
    public class PortfolioContext: DbContext
    {
        public PortfolioContext() : base()
        {

        }

        public DbSet<BaseClass> Classes { get; set; }
    }
}
