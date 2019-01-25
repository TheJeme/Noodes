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

namespace Noodes
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

        private void CloseButton_Click(object sender, RoutedEventArgs e) //Closes the window
        {
            this.Close();
        }
        private void MinimizeButton_Click(object sender, RoutedEventArgs e) //Minimizes the window
        {
            this.WindowState = WindowState.Minimized;
        }
        private void NewButton_Click(object sender, RoutedEventArgs e) //Minimizes the window
        {
            MainWindow win2 = new MainWindow();
            win2.Show();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) //For dragging the window
        {
            this.DragMove();
        }
    }
}
