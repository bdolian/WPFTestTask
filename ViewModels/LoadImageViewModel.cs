using Microsoft.Win32;
using WPFTestApp.MVVM;

namespace WPFTestApp.ViewModels
{
    class LoadImageViewModel : ViewModelBase
    {
        private string _imagePath;
        public string ImagePath
        {
            get { return _imagePath; }
            set
            {
                _imagePath = value;
                OnPropertyChanged();
            }
        }
        public RelayCommand LoadImageCommand => new (execute => LoadImage());
        private void LoadImage()
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Image files|*.png;*.jpg;*.jpeg"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                ImagePath = openFileDialog.FileName;
            }
        }
    }
}
