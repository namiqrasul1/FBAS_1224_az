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
using WpfApp3.Model;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CarList.ItemsSource = cars;
        }

        readonly List<Car> cars = new()
        {
            new Car() { Vendor = "Nissan", Model = "Skyline GTR", Year = "1999" },
            new Car() { Vendor = "Toyota", Model = "Supra", Year = "2003" },
            new Car() { Vendor = "Ford", Model = "Mustang", Year = "1967" }
        };
        private void CarList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var car = CarList.SelectedItem as Car;
            vendorBlock.Text = car?.Vendor;
            modelBlock.Text = car?.Model;
            yearBlock.Text = car?.Year;
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    //exp.Header = "Deyishdim Deyishdim";
        //    if(sender is Button bt)
        //    {
        //        if(bt.Parent is StackPanel st)
        //        {
        //            if (st.Parent is Expander ex)
        //                ex.Header = "Deyishdim";
        //        }
        //    }
        //}

        //private void CheckBox_Checked(object sender, RoutedEventArgs e)
        //{
        //    btn.IsEnabled = checkBox.IsChecked != null && checkBox.IsChecked == true;
        //}

        //private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        //{
        //    btn.IsEnabled = false;
        //}

        //private void btn_Click(object sender, RoutedEventArgs e)
        //{
        //    if(pgBar.Value < pgBar.Maximum)
        //    {
        //        pgBar.Value += 5;
        //        lbl.Content = pgBar.Value.ToString();
        //    }
        //}

        //private void Sld_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    Background = new SolidColorBrush(Color.FromRgb((byte)sldR.Value, (byte)sldG.Value, (byte)sldB.Value));
        //}
    }
}
