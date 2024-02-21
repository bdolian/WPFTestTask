using System.Windows.Controls;
using WPFTestApp.ViewModels;

namespace WPFTestApp.Views
{
    public partial class ElementsListView : UserControl
    {
        public ElementsListView()
        {
            InitializeComponent();
            DataContext = new ElementsListViewModel();
        }
    }
}
