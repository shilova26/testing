using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Coffeehouse1.Models
{
    public class CardContext:DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}