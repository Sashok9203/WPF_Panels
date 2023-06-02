using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Brush searchButtonBrush;
        public MainWindow()
        {
            InitializeComponent();
            searchButtonBrush = searchTextBox.Background;
        }

       

        private void searchTextBox_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (!searchTextBox.IsFocused)
            {
                searchTextBox.Text = string.Empty;
                searchTextBox.Background = null;
            }
            else
            {
                searchTextBox.Text = "      Search";
                searchTextBox.Background = searchButtonBrush;
            }
        }

        private void TextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock? textBlock = sender as TextBlock;
            textBlock.Foreground = Brushes.Blue;
        }

        private void TextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            TextBlock? textBlock = sender as TextBlock;
            textBlock.Foreground = Brushes.Black;
        }
    } 
}
