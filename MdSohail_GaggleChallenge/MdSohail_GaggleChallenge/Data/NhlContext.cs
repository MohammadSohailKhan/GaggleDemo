//using GaggleChallengeProject.Models.Nhl;
using MdSohail_GaggleChallenge.Models.Nhl;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MdSohail_GaggleChallenge.Data
{
    public class NhlContext : DbContext
    {
        public NhlContext() : base("DefaultConnection")
        {}

        public DbSet<Product> Products { get; set; }
    }
}