using System.Windows.Controls;
using WPFTestApp.ViewModels;

namespace WPFTestApp.Views
{
    public partial class LoadImageView : UserControl
    {
        public LoadImageView()
        {
            InitializeComponent();
            DataContext = new LoadImageViewModel();
        }
    }
}
