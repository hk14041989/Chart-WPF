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
using System.Windows.Threading;

namespace YTGraphWPFTester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DateTime timeStarted;
        double yValue = 2;
        double dVariance = 0;
        Random rand;
        DispatcherTimer timer = new DispatcherTimer();
        List<int> list = new List<int>(new int[] { 0, 0, 0, -1, -1, -1, -3, -3, -3, -5, -5, -5, 1, 1, 1, 3, 3, 3, 4, 4, 4, -10, -10, -10, -20, -20, -20, -30, -30, -30 });
        int i;

        public MainWindow()
        {
            InitializeComponent();
            graphUC.CheckAndAddSeriesToGraph("roto", "rpm");
            dVariance = yValue;
            rand = new Random();
            timeStarted = DateTime.Now;
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        public int Value()
        {
            //Random r = new Random();
            //int index = r.Next(0, list.Count - 1);
            if(i <= (list.Count -1))
            {
                return list.ElementAt(i);
            }
            else 
            {
                i = 0;
                return list.ElementAt(i);
            }
        }
        void timer_Tick(object sender, EventArgs e)
        {
            double dValueX = (double)(DateTime.Now.Subtract(timeStarted).TotalSeconds);

            graphUC.AddPointToLine("roto", yValue + (Value() - dVariance), dValueX);

            i++;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            graphUC.Width = e.NewSize.Width - 40;
            graphUC.Height = e.NewSize.Height - 20;
        }
    }
}
