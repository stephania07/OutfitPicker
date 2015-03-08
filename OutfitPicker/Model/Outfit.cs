using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OutfitPicker.Model
{
   public class Outfit
    {
       public int OutfitId {get; set;}
       public string Occassion { get; set;} 
       public string OutfitName { get; set; }
       public string Note { get; set;}
       public string OutfitImagePath { get; set;}
    

    public Outfit()
    {
    }
    public Outfit(string Occassion, string Outfit, string Note)
    {
        this.Occassion = Occassion;
        this.OutfitName = OutfitName;
        this.Note = Note;
        this.OutfitImagePath = OutfitImagePath;
    }
  }
}
