using Avalonia.Controls;
using Avalonia.Interactivity;
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
    private void AddCity_Click(object? sender, RoutedEventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(CityTextBox.Text))
        {
            CityListBox.Items.Add(CityTextBox.Text);
            CityTextBox.Clear();
        }
    }
}