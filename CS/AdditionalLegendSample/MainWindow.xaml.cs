using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
using System.Windows.Resources;
using System.Windows.Shapes;

namespace AdditionalLegendSample {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            DataContext = LoadData();
        }

        List<DataPoint> LoadData() {
            List<DataPoint> result = new List<DataPoint>();
            StreamResourceInfo info = Application.GetResourceStream(new Uri("Data/AUDUSDDaily.csv", UriKind.RelativeOrAbsolute));
            StreamReader reader = new StreamReader(info.Stream);
            while(!reader.EndOfStream) {
                string line = reader.ReadLine();
                var values = line.Split(',');
                var point = new DataPoint();
                point.Argument = DateTime.ParseExact(values[0], "yyyy.MM.dd", null);
                point.OpenValue = double.Parse(values[1], CultureInfo.InvariantCulture);
                point.HighValue = double.Parse(values[2], CultureInfo.InvariantCulture);
                point.LowValue = double.Parse(values[3], CultureInfo.InvariantCulture);
                point.CloseValue = double.Parse(values[4], CultureInfo.InvariantCulture);
                result.Add(point);
            }
            return result;
        }
    }

    public class DataPoint {
        public DateTime Argument { get; set; }
        public double LowValue { get; set; }
        public double HighValue { get; set; }
        public double OpenValue { get; set; }
        public double CloseValue { get; set; }
    }
}
