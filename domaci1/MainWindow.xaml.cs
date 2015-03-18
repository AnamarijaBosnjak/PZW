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

namespace WpfApplication2
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.AddL.Click += AddL_Click;
            this.AddR.Click += AddR_Click;
        }

        void AddR_Click(object sender, RoutedEventArgs e)
        {
            this.rightRectangle.Children.Add
            (
                new Rectangle()
                {
                    Width = 300,
                    Height = 30,
                    Margin = new Thickness(5),
                    Fill = Brushes.Red
                }
            );
        }

        void AddL_Click(object sender, RoutedEventArgs e)
        {
            this.leftRectangle.Children.Add
            (
                new Rectangle()
                {
                    Width = 70,
                    Height = 60,
                    Margin = new Thickness(5),
                    Fill = Brushes.OrangeRed
                }
            );
        }
    }
}

