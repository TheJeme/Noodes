using System;
using System.Windows;
using System.Windows.Input;

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

        private void TxtEditor_PreviewMouseWheel(object sender, MouseWheelEventArgs e) //Changes the fontsize
        {
        if (e.Delta > 0 && Keyboard.Modifiers == ModifierKeys.Control)
            try
            {
                txtBox.FontSize += 1;
            }
            catch (Exception)
            {
                return;
            }
        else if (e.Delta < 0 && Keyboard.Modifiers == ModifierKeys.Control)
            try
            {
                txtBox.FontSize -= 1;
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
