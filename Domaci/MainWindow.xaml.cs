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

namespace Domaci
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
            this.LeftButton.Click += LeftButton_Click;
            this.RightButton.Click += RightButton_Click;
        }

        void RightButton_Click(object sender, RoutedEventArgs e)
        {
            var rectangle = new Rectangle()
                {
                  Width=400,
                  Height=50,
                  Margin = new Thickness(10),
                  Fill = Brushes.Red
                };
             

            this.RightContainer.Children.Add(rectangle);
        }

        void LeftButton_Click(object sender, RoutedEventArgs e)
        {
            var rectangle = new Rectangle()
            {
                Width = 120,
                Height = 100,
                Margin = new Thickness(5),
                Fill = Brushes.Orange
            };


            this.LeftContainer.Children.Add(rectangle);
        }

        

    }
}
