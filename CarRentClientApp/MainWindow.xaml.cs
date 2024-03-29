using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Windows;

using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CarRentClientApp.Models;


namespace CarRentClientApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly HttpClient _client;

        public MainWindow()
        {
            InitializeComponent();
            _client = new HttpClient();
        }

        private async void List_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync("https://localhost:7173/api/Car-listCars");
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                List<Car> cars = JsonSerializer.Deserialize<List<Car>>(responseBody);

                carListBox.ItemsSource = cars;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"HTTP error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}