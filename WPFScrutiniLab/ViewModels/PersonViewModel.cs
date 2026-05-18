using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using WPFScrutiniLab.Models;

namespace WPFScrutiniLab.ViewModels
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private Person _selectedPerson;
        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set { _selectedPerson = value; OnPropertyChanged("SelectedPerson"); }
        }

        private Person _person;
        public ObservableCollection<Person> Persons { get; set; }
        public PersonViewModel(/*Person person*/)
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
            //_person = person;
        }



        /// <summary>   Идентификатор персоны.  </summary>
        public Int32 PersonID
        {
            get { return _person.PersonID; }
            set { _person.PersonID = value; 
                OnPropertyChanged("PersonID");
            }
        }

       
        /// <summary>   Фамилия персоны </summary>
        public string Surname
        {
            get { return _person.Surname; }
            set { _person.Surname = value; 
                OnPropertyChanged("Surname"); 
            }
        }

        /// <summary>   Имя персоны </summary>
        public string Name
        {
            get { return _person.Name; }
            set { _person.Name = value; 
                OnPropertyChanged("Name"); 
            }
        }

 
        /// <summary>   Отчество персоны </summary>
        public String Patronymic
        {
            get { return _person.Patronymic; }
            set { _person.Patronymic = value; 
                OnPropertyChanged("Patronymic"); 
            }
        }

     
        /// <summary>   Дата рождения персоны.  </summary>
        public DateTime Birthdate
        {
            get { return _person.Birthdate; }
            set { _person.Birthdate = value; 
                OnPropertyChanged("Birthdate"); 
            }
        }


        /// <summary>   Пол персоны.  </summary>
        public Gender Gender
        {
            get { return _person.Gender; }
            set { _person.Gender = value; 
                OnPropertyChanged("Gender"); 
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
