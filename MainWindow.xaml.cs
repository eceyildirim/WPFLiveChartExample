using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;

namespace WPFLiveChartExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random random;
        public MainWindow()
        {
            InitializeComponent();
            random = new Random();
        }

        public SeriesCollection SeriesCollection { get; set; }

        private void ButtonChangePieChart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataContext = new object();

                SeriesCollection = new SeriesCollection
                {
                    new PieSeries
                    {
                        Title = "1. Instagram",
                        Values = new ChartValues<ObservableValue> { new ObservableValue(random.Next(50000, 650000))},
                        DataLabels = true
                    },                    new PieSeries
                    {
                        Title = "2. Twitter",
                        Values = new ChartValues<ObservableValue> { new ObservableValue(random.Next(45000, 400000))},
                        DataLabels = true
                    },                    new PieSeries
                    {
                        Title = "3. YouTube",
                        Values = new ChartValues<ObservableValue> { new ObservableValue(random.Next(30000, 800000))},
                        DataLabels = true
                    }
                };
                DataContext = this;
            }
            catch(Exception exp)
            {
                MessageBox.Show("Pasta Grafiği Oluşturulamadı \n" + exp.Message);
            }
        }
    }
}
