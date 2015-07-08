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
using System.Windows.Shapes;

namespace Remember_Pi
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        public Game()
        {
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.D1))
            {
               
                btn_1_Click(sender,e);
            }
            if (Keyboard.IsKeyDown(Key.NumPad1))
            {

                btn_1_Click(sender, e);
            }
            if (Keyboard.IsKeyDown(Key.D2))
            {
                btn_2_Click(sender, e);
            }
            if (Keyboard.IsKeyDown(Key.NumPad2))
            {

                btn_2_Click(sender, e);
            }
            if (Keyboard.IsKeyDown(Key.D3))
            {
                btn_3_Click(sender, e);
            }
            if (Keyboard.IsKeyDown(Key.NumPad3))
            {

                btn_3_Click(sender, e);
            }
            if (Keyboard.IsKeyDown(Key.D4))
            {
                btn_4_Click(sender, e);
            }
            if (Keyboard.IsKeyDown(Key.NumPad4))
            {

                btn_4_Click(sender, e);
            }
            if (Keyboard.IsKeyDown(Key.D5))
            {
                btn_5_Click(sender, e);
            }
            if (Keyboard.IsKeyDown(Key.NumPad5))
            {

                btn_5_Click(sender, e);
            }
            if (Keyboard.IsKeyDown(Key.D6))
            {
                btn_6_Click(sender, e);
            }
            if (Keyboard.IsKeyDown(Key.NumPad6))
            {

                btn_6_Click(sender, e);
            }
            if (Keyboard.IsKeyDown(Key.D7))
            {
                btn_7_Click(sender, e);
            }
            if (Keyboard.IsKeyDown(Key.NumPad7))
            {

                btn_7_Click(sender, e);
            }
            if (Keyboard.IsKeyDown(Key.D8))
            {
                btn_8_Click(sender, e);
            }
            if (Keyboard.IsKeyDown(Key.NumPad8))
            {

                btn_8_Click(sender, e);
            }
            if (Keyboard.IsKeyDown(Key.D9))
            {
                btn_9_Click(sender, e);
            }
            if (Keyboard.IsKeyDown(Key.NumPad9))
            {

                btn_9_Click(sender, e);
            }
            if (Keyboard.IsKeyDown(Key.NumPad0))
            {

                btn_0_Click(sender, e);
            }
            if (Keyboard.IsKeyDown(Key.Decimal))
            {
                btn_comma_Click(sender, e);
            }
            if (Keyboard.IsKeyDown(Key.OemComma))
            {
                btn_comma_Click(sender, e);
            }
            if (Keyboard.IsKeyDown(Key.OemPeriod))
            {
                btn_comma_Click(sender, e);
            }
            if (Keyboard.IsKeyDown(Key.Back))
            {
                btn_back_Click(sender, e);
            }
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to go back to the main menu?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                cleargame();
                this.Close();
            }
            else
            {
                // Do not close the window
            } 
            
        }

        private void cleargame()
        {
            PI.RememberedSoFar = "";
            PI.decimals = 0;
            PI.guess = 0;
            PI.counter = 0;
            PI.lives = 3;
            label_lives.Content = 3;
            Label_output.Content = "";
            label_Notify.Content = "Game over, press 3 to start.";
            label_Notify.Visibility = Visibility.Visible;
        }

        private void addguess()
        {
            
            PI.guess++;
            if (PI.guess == 3) //check if still alive
            {
                cleargame();
            }
            else
            {
                label_Notify.Visibility = Visibility.Visible;
                label_Notify.Content = "Wrong";
                PI.lives--;
                label_lives.Content = PI.lives;

            }
        }

        private void checknumber(string number)
        {
            label_Notify.Visibility = Visibility.Hidden;
            char[] pi = PI.pi.ToCharArray();
            char[] mynumber = number.ToCharArray();
            if (pi[PI.counter] == mynumber[0])
            {
                
                PI.RememberedSoFar = PI.RememberedSoFar + number;
                if (PI.RememberedSoFar.Length > 8)
                {
                    PI.RememberedSoFar = PI.RememberedSoFar.Substring(PI.RememberedSoFar.Length - 8, PI.RememberedSoFar.Length-1);
                }
                Label_output.Content = PI.RememberedSoFar;
                PI.counter++;
                if (PI.RememberedSoFar.Length > 2)
                {
                    PI.decimals++;
                    label_decimals.Content = PI.decimals;
                    
                }
            }
            else
            {
                addguess();
            }   
        }


        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            //compare 1 to element counter in pi"
            //
            //pi counter++;
            checknumber("1");         

        }
        
        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            checknumber("2");  
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            checknumber("3");
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            checknumber("4");
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            checknumber("5");
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            checknumber("6");
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            checknumber("7");
        }

        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            checknumber("8");
        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            checknumber("9");
        }

        private void btn_0_Click(object sender, RoutedEventArgs e)
        {
            checknumber("0");
        }

        private void btn_comma_Click(object sender, RoutedEventArgs e)
        {
            checknumber(".");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            cleargame();
        }



    }
}
