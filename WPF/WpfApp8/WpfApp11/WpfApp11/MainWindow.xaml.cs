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
using WpfApp11.Commands;

namespace WpfApp11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Text { get; set; } = "";
        //public MessageCommand MessageCommand { get; set; }

        public RelayCommand MessageCommand { get; set; }
        public RelayCommand SendCommand { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            MessageCommand = new(Message);
            SendCommand = new(Send, CanSend);
            DataContext = this;
        }


        public void Message(object? param) => MessageBox.Show("Hakuna");
        public void Send(object? param) => MessageBox.Show(Text);
        public bool CanSend(object? param) => Text.Length > 5;

        private void HelpCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = Text.Length > 5;
        }

        private void HelpCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show(Text);
        }
    }
}
