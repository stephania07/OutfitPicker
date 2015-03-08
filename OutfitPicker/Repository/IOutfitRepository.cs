using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OutfitPicker.Model;

namespace OutfitPicker.Repository
{
   public interface IOutfitRepository
    {
       int GetCount();
       void Add(Outfit O);
       void Delete(Outfit O);
       void Clear();
       void Dispose();

    }
}
