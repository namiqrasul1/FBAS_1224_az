using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace CaclHomework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName]string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private string? result = "0";

        public string? Result { get => result; set { result = value; OnPropertyChanged(); } }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            if(sender is Button btn)
            {
                if (Result != "0" && !string.IsNullOrWhiteSpace(Result))
                {
                    Result += btn.Content.ToString();
                }
                else Result = btn.Content.ToString();
            }
            
        }

    }
}
