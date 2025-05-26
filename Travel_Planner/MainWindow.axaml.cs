using Avalonia.Controls;
using Avalonia.Media.Imaging;

namespace Travel_Planner;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void CountryComboBox_SelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        if (CountryComboBox.SelectedItem is ComboBoxItem selectedItem)
        {
            string country = selectedItem.Content.ToString();
            string imagePath = $"Images/{country}.jpg";
            CountryImage.Source = new Bitmap(imagePath);
        }
    }
}