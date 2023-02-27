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
using WpfApp4.Models;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Brush ColorBrush { get; set; } = Brushes.Orange;
        public List<Book> Books { get; set; } = new()
        {
            new()
            {
                Id = 1,
                Name = "Inferno",
                Author = "Dan Brown",
                ImagePath = @"https://m.media-amazon.com/images/I/61RpxrfYE2L.jpg"
            },
            new()
            {
                Id = 2,
                Name = "Jane Eyre",
                Author = "Charlotte Bronte",
                ImagePath = @"https://sevenov.com/wp-content/uploads/2022/06/jane-eyre-20220620.jpg"
            },
        };
        public List<Person> People { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            People = new Bogus.Faker<Person>()
                .RuleFor(p => p.Id, f => f.Random.Number(1, 100))
                .RuleFor(p => p.FirstName, f => f.Person.FirstName)
                .RuleFor(p => p.LastName, f => f.Person.LastName)
                .RuleFor(p => p.Gender, f => f.Person.Gender.ToString())
                .RuleFor(p => p.PhoneNumber, f => f.Person.Phone)
                .RuleFor(p => p.Avatar, f => f.Person.Avatar)
                .RuleFor(p => p.Email, f => f.Person.Email)
                .RuleFor(p => p.Address, f => f.Person.Address.City)
                .RuleFor(p => p.BDate, f => f.Person.DateOfBirth)
                .Generate(50);



            DataContext = this;
        }
    }
}
