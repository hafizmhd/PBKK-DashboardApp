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
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;

namespace DashboardApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            range_comboBox.Items.Add("7 Days");
            range_comboBox.Items.Add("30 Days");
            range_comboBox.Items.Add("6 Months");

        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void minimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void titleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        
    }

    public class ViewModel
    {
        public ISeries[] Series { get; set; } = new ISeries[]
        {
            new ColumnSeries<int>
            {
                Values = new int[] { 600, 800, 1200, 900, 1000, 1400},
                Fill = new SolidColorPaint(SKColors.Blue),
                Stroke = null
            }
        };

        public Axis[] XAxes { get; set; } = new Axis[]
        {
            new Axis
            {
                TextSize = 14,
                Labels = new string[] { "January", "February", "March", "April", "May", "June"}
            },
        };

        public Axis[] YAxes { get; set; } = new Axis[]
        {
            new Axis
            {
                TextSize = 14,
                Labeler = Labelers.Currency
            },
        };

    }
}
