using System.Collections.ObjectModel;
using WPFTestApp.Models;
using WPFTestApp.MVVM;

namespace WPFTestApp.ViewModels
{
    class ElementsListViewModel : ViewModelBase
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

        public RelayCommand DeleteCommand => new (execute => DeletePersonName(), canExecute => SelectedPersonName != null);

        private PersonNameModel _selectedPersonName;
        public PersonNameModel SelectedPersonName
        {
            get { return _selectedPersonName; }
            set 
            {
                _selectedPersonName = value;
                OnPropertyChanged();
            }
        }

        private void DeletePersonName()
        {
            PersonNames.Remove(SelectedPersonName);
        }
    }
}
