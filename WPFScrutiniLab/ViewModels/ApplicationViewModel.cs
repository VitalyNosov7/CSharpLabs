using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using WPFScrutiniLab.Models;

namespace WPFScrutiniLab.ViewModels
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<Person> Persons { get; set; }

        private Person _selectedPerson;
        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set { _selectedPerson = value; OnPropertyChanged("SelectedPerson"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


        public ApplicationViewModel()
        {
            Persons = new ObservableCollection<Person>
            {
                    new Person(1, "Иванов", "Иван", "Иванович", new DateTime(1977, 12, 06), Gender.Male),
                    new Person(2, "Иванова", "Мария", "Ивановна", new DateTime(1980, 12, 06), Gender.Female),
                    new Person(3, "Иванова", "Елена", "Ивановна", new DateTime(2012, 06, 06), Gender.Female),
                    new Person(4, "Петров", "Петр", "Степанович", new DateTime(1946, 09, 06), Gender.Male),
                    new Person(5, "Петрова", "Людмила", "Георгиевна", new DateTime(1947, 08, 01), Gender.Female),
                    new Person(6, "Петров", "Денис", "Сергеевич", new DateTime(2021, 05, 01), Gender.Male)
            };
      
        }
    }
}
