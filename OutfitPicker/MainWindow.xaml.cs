using OutfitPicker.Model;
using OutfitPicker.Repository;
using System.Windows;
using System.Windows.Controls;

namespace OutfitPicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static OutfitRepository repo = new OutfitRepository();
        public string Occassion { get; set; }
        public string OutfitName { get; set; }
        public string Note { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            outfitList.DataContext = repo.Context().Outfits.Local;

        }

        private void AddOccasion_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.Occassion = AddOccassion.Text.ToUpper();
        }

        private void AddOutfitName_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.OutfitName = AddOutfitName.Text.ToUpper();
        }

        private void AddNote_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.Note = AddNote.Text.ToLower();
        }

        private void AddItem(object sender, RoutedEventArgs e)
        {

        }
      }
       
    }

