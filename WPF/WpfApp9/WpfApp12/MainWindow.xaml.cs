using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product>? Products { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            Products = new()
            {
                new() {Name = "Chorek", Price = 0.7 },
                new() {Name = "Perpetoyun", Price = 0.5 },
                new() {Name = "Chorek", Price = 0.7 },
                new() {Name = "Perpetoyun", Price = 0.5 },
                new() {Name = "Chorek", Price = 0.7 },
                new() {Name = "Perpetoyun", Price = 0.5 },
                new() {Name = "Chorek", Price = 0.7 },
                new() {Name = "Perpetoyun", Price = 0.5 },
                new() {Name = "Chorek", Price = 0.7 },
                new() {Name = "Perpetoyun", Price = 0.5 },
                new() {Name = "Chorek", Price = 0.7 },
                new() {Name = "Perpetoyun", Price = 0.5 },
                new() {Name = "Chorek", Price = 0.7 },
                new() {Name = "Perpetoyun", Price = 0.5 },
                new() {Name = "Chorek", Price = 0.7 },
                new() {Name = "Perpetoyun", Price = 0.5 },
                new() {Name = "Chorek", Price = 0.7 },
                new() {Name = "Perpetoyun", Price = 0.5 },
                new() {Name = "Chorek", Price = 0.7 },
                new() {Name = "Perpetoyun", Price = 0.5 },

            };

            DataContext = this;
        }
    }
}
