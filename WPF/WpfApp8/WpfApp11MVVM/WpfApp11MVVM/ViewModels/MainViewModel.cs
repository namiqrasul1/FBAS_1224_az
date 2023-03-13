using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp11MVVM.Commands;
using WpfApp11MVVM.Models;
using WpfApp11MVVM.Views;

namespace WpfApp11MVVM.ViewModels
{
    public class MainViewModel
    {
        public Book Book { get; set; }

        public RelayCommand ShowCommand { get; set; }
        public RelayCommand EditCommand { get; set; }

        public MainViewModel()
        {
            Book = new()
            {
                Id = 1,
                Author = "Ozu",
                Name = "Allahverdinin Maceralari",
                PublishYear = 2023
            };

            ShowCommand = new RelayCommand(
                    obj =>
                    {
                        MessageBox.Show($"{Book.Id} {Book.Name} {Book.Author} {Book.PublishYear}");
                    }
                );

            EditCommand = new RelayCommand(
                    obj =>
                    {
                        EditViewModel editViewModel = new();
                        editViewModel.Book = Book;
                        EditVIew editView = new();
                        editView.DataContext = editViewModel;
                        editView.ShowDialog();
                    }

                );
        }
    }
}
