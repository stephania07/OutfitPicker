using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OutfitPicker.Model;
using System.Data.Entity;
using System.Windows;


namespace OutfitPicker.Repository
{
   public class OutfitRepository : IOutfitRepository
    {
       private OutfitContext _dbContext; //declares db field

    public OutfitRepository()
    {
        _dbContext = new OutfitContext(); //generates new instance of OutfitContext
        _dbContext.Outfits.Load(); //Loads the DbSet Outfits,
    }
    public OutfitContext Context()
    {
        return _dbContext;
    }
    public int GetCount()
    {
        return _dbContext.Outfits.Count<Outfit>();
    }

    public void Add(Outfit O)
    {
        _dbContext.Outfits.Add(O);
        _dbContext.SaveChanges();
    }
    public void Delete(Outfit O)
    {
        if (O == null)
        {
            MessageBox.Show("Please select the item to be deleted");
        }
        else
        {
            _dbContext.Outfits.Remove(O);
            _dbContext.SaveChanges();
        }
    }
       public void Clear()
       {
           var items = from Outfit in _dbContext.Outfits select Outfit;
           var a = items.ToList<Outfit>();
           _dbContext.Outfits.RemoveRange(a);
           _dbContext.SaveChanges();
       }
       public void Dispose() 
       {
        _dbContext.Dispose();
       }

    }
}
 
