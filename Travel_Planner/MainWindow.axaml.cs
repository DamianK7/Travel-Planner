using System.IO;
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
    private void ShowSummary_Click(object? sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text;
            
            string country = "";
            if (CountryComboBox.SelectedItem is ComboBoxItem comboBoxItem)
            {
                country = comboBoxItem.Content.ToString();
            }
            
          
            string cities = string.Join(", ", CityListBox.Items);
            
            string countryImagePath = string.Empty;
            if (!string.IsNullOrEmpty(country))
            {
                countryImagePath = $"Images/{country}.jpg";
                if (!File.Exists(countryImagePath))
                {
                    countryImagePath = string.Empty;
                }
            }
            
            SummaryWindow summaryWindow = new SummaryWindow(
                 name, country, cities, countryImagePath
            );
            summaryWindow.Show();
        }
}