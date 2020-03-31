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

namespace AP_Project_Part_A
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

        private void Button_new(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("welcome"+"\n"+"Fill in the information");
        }

        private void Blue_Click(object sender, RoutedEventArgs e)
        {
            doc1.Background = Brushes.Blue;
            border1.Background = Brushes.Blue;
        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            doc1.Background = Brushes.Red;
            border1.Background = Brushes.Red;
        }

        private void Green_Click(object sender, RoutedEventArgs e)
        {
            doc1.Background = Brushes.Green;
            border1.Background = Brushes.Green;
        }

        private void blue2_Click(object sender, RoutedEventArgs e)
        {
            Doc2.Background = Brushes.Blue;
            border2.Background = Brushes.Blue;
        }

        private void Red2_Click(object sender, RoutedEventArgs e)
        {
            Doc2.Background = Brushes.Red;
            border2.Background = Brushes.Red;
        }

        private void Green2_Click(object sender, RoutedEventArgs e)
        {
            Doc2.Background = Brushes.Green;
            border2.Background = Brushes.Green;
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            tabcontrol.SelectedItem = specificationstab;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox message = MessageBox.Show("do you want to exit?", "exit", MessageBoxButton.YesNo, MessageBoxImage.Question);
            MessageBoxResult result =MessageBox.Show("do you want to exit?","exit", MessageBoxButton.YesNo,MessageBoxImage.Question);
            switch(result)
            {
                case MessageBoxResult.Yes:
                    this.Close();
                    break;
                case MessageBoxResult.No:
   
                    break;
            }

        }
    }  
}
