using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Imaging;
using WPFTestApp.Models;

namespace WPFTestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<PersonName> PersonNames { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            PersonNames = new ObservableCollection<PersonName>();
            FillElements(PersonNames);
            listBox.ItemsSource = PersonNames;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files|*.png;*.jpg;*.jpeg";
            if (openFileDialog.ShowDialog() == true)
            {
                LoadedPicture.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            }
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is PersonName item)
            {
                PersonNames.Remove(item);
            }
        }

        private static void FillElements(ObservableCollection<PersonName> elements)
        {
            elements.Add(new PersonName("Mick", "Jagger"));
            elements.Add(new PersonName("Freddie", "Mercury"));
            elements.Add(new PersonName("Robert", "Plant"));
            elements.Add(new PersonName("Kurt", "Cobain"));
            elements.Add(new PersonName("Axl", "Rose"));
            elements.Add(new PersonName("Steven", "Tyler"));
        }
    }
}
