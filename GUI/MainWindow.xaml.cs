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

namespace GUI
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dataSetFile_txt.Text = "dataset.csv";
            testFile_txt.Text = "dataset.csv";
            intervalValue_txt.Text = "0";
            simpleValidationValue_txt.Text = "60";
            simpleValidation_rad.IsChecked = false;
            crossedValidation_rad.IsChecked = false;
            externText_chk.IsChecked = false;
        }

        private void externText_chk_Checked(object sender, RoutedEventArgs e)
        {
            simpleValidationValue_txt.IsEnabled = false;
            simpleValidation_rad.IsEnabled = false;
            crossedValidation_rad.IsEnabled = false;
            testFile_btn.IsEnabled = true;
            testFile_txt.IsEnabled = true;
        }

        private void externText_chk_Unchecked(object sender, RoutedEventArgs e)
        {
            simpleValidationValue_txt.IsEnabled = true;
            simpleValidation_rad.IsEnabled = true;
            crossedValidation_rad.IsEnabled = true;
            testFile_btn.IsEnabled = false;
            testFile_txt.IsEnabled = false;
        }

        private void start_btn_Click(object sender, RoutedEventArgs e)
        {
            Results results = new Results();
            results.Show();
        }
    }
}
