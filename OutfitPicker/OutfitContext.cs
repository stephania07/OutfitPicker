using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OutfitPicker.Model;
using System.Data.Entity;

namespace OutfitPicker
{
    public class OutfitContext : DbContext
    {
        public OutfitContext()
        { 
        
        }
        public DbSet<Outfit> Outfits { get; set; }
        
    }
}
