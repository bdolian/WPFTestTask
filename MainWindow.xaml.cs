using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using WPFTestApp.Models;

namespace WPFTestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<PersonNameModel> PersonNames { get; set; } = new ObservableCollection<PersonNameModel>
        {
            new PersonNameModel("Mick", "Jagger"),
            new PersonNameModel("Freddie", "Mercury"),
            new PersonNameModel("Robert", "Plant"),
            new PersonNameModel("Kurt", "Cobain"),
            new PersonNameModel("Axl", "Rose"),
            new PersonNameModel("Steven", "Tyler")
        };
        public MainWindow()
        {
            InitializeComponent();
            listBox.ItemsSource = PersonNames;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files|*.png;*.jpg;*.jpeg";
            if (openFileDialog.ShowDialog() == true)
            {
                LoadedPicture.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            }
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is PersonNameModel item)
            {
                PersonNames.Remove(item);
            }
        }
    }
}
