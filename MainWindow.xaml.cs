using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System;
using System.Windows;
using System.Windows.Input;
using System.Diagnostics.Metrics;

namespace _11.ChatApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Border_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
        int counter = 0;
        private void ButtonMaximize_Click(Object sender, RoutedEventArgs e)
        {
            counter++;
            if(counter % 2 != 0)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;

            }else
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }

            }
        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0); 
        }
    }
}
