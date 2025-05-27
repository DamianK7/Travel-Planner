using Avalonia.Controls;
using Avalonia.Media.Imaging;
using System.IO;

namespace Travel_Planner
{
    public partial class SummaryWindow : Window
    {
        public SummaryWindow(string name, string country, string attractions, string transport, string cities,
            string countryImagePath)
        {
            InitializeComponent();
            
            SummaryText.Text = $"Podróżujący: {(!string.IsNullOrEmpty(name) ? name : "Nie podano imienia")}\n" +
                               $"Kraj: {(!string.IsNullOrEmpty(country) ? country : "Nie wybrano kraju")}\n" +
                               $"Atrakcje: {(!string.IsNullOrEmpty(attractions) ? attractions : "Brak wybranych atrakcji")}\n" +
                               $"Transport: {(!string.IsNullOrEmpty(transport) ? transport : "Brak wybranego transportu")}\n" +
                               $"Miasta: {(!string.IsNullOrEmpty(cities) ? cities : "Brak dodanych miast")}";
            
            if (!string.IsNullOrEmpty(countryImagePath) && File.Exists(countryImagePath))
            {
                SummaryImage.Source = new Bitmap(countryImagePath);
            }
            else
            {
                SummaryImage.Source = null;
            }
        }
    }
}