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

namespace Remember_Pi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Positon();

        }

        public void Positon()
        {
            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            this.Left = (screenWidth / 2) - (windowWidth / 2);
            this.Top = (screenHeight / 2) - (windowHeight / 2);
        }

        private void btn_linear_Click(object sender, RoutedEventArgs e)
        {
            Game g = new Game();
            g.Left = this.Left;
            g.Top = this.Top;
            this.Hide();
            g.ShowDialog();
            this.Left = g.Left;
            this.Top = g.Top;
            this.Show();
            
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btn_tutorial_Click(object sender, RoutedEventArgs e)
        {
           //MessageBox.Show("Not implemented yet, go google Pi for now.","Notice");
           // Tutorial g = new Tutorial();

            // string pi = PI.pi;            
            // int start = 0;
            // int end = 10;
            // string test = "";
            // string newpi = "";
            ////formatted pi = pi with an interval of 10.
            // for (int i = 0; i < PI.pi.Length; i++)
            // {
            //     newpi = PI.pi.Substring(start, end);
            //     test = newpi + "\n";
            //     start = start + 10;
            //     end = end + 10;
            // }


           // g.label_showpi.Content = "Not implemented yet, use Google for now!";

           // g.Left = this.Left;
           // g.Top = this.Top;
           // this.Hide();
           // g.ShowDialog();
           // this.Left = g.Left;
           // this.Top = g.Top;
            MessageBox.Show("Not implemented yet, use Google for now!","Notice");
            this.Show();

        }
    }
}
