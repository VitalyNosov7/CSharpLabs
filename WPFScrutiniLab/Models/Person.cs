using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace WPFScrutiniLab.Models
{
    /// <summary>   Информация о персоне.   </summary>
	public class Person /*: INotifyPropertyChanged*/
    {
        /// <summary>   Идентификатор персоны.  </summary>
        private Int32 _personID = default;

        /// <summary>   Идентификатор персоны.  </summary>
        public Int32 PersonID
        {
            get { return _personID; }
            set { _personID = value;/* OnPropertyChanged("PersonID");*/ }
        }

        /// <summary>   Фамилия персоны </summary>
        private String _surname = String.Empty;

        /// <summary>   Фамилия персоны </summary>
        public string Surname
        {
            get { return _surname; }
            set { _surname = value;/* OnPropertyChanged("Surname");*/ }
        }

        /// <summary>   Имя персоны </summary>
        private String _name = String.Empty;

        /// <summary>   Имя персоны </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; /*OnPropertyChanged("Name");*/ }
        }

        /// <summary>   Отчество персоны </summary>
        private String _patronymic = String.Empty;

        /// <summary>   Отчество персоны </summary>
        public String Patronymic
        {
            get { return _patronymic; }
            set { _patronymic = value; /*OnPropertyChanged("Patronymic");*/ }
        }

        /// <summary>   Дата рождения персоны.  </summary>
        private DateTime _birthdate = default;
        /// <summary>   Дата рождения персоны.  </summary>
        public DateTime Birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; /*OnPropertyChanged("Birthdate");*/ }
        }

        /// <summary>   Пол персоны.  </summary>
        private Gender _gender = default;

        /// <summary>   Пол персоны.  </summary>
        public Gender Gender
        {
            get { return _gender; }
            set { _gender = value; /*OnPropertyChanged("Gender");*/ }
        }

        /// <summary>	Создать персону.	</summary>
        /// <param name="personId">Идентификатор персоны</param>
        /// <param name="surname">Фамилия персоны</param>
        /// <param name="name">Имя персоны</param>
        /// <param name="patronymic">Отчество персоны</param>
        /// <param name="birthdate">Дата роджения персоны</param>
        /// <param name="gender">Пол персоны</param>
        public Person(Int32 personId
                        , String surname
                        , String name
                        , String patronymic
                        , DateTime birthdate
                        , Gender gender)
        {
            PersonID = personId;
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Birthdate = birthdate;
            Gender = gender;
        }

        //public ObservableCollection<Person> Persons { get; set; }


        public Person()
        {
            //Persons = new ObservableCollection<Person>
            //{
            //        new Person(1, "Иванов", "Иван", "Иванович", new DateTime(1977, 12, 06), Gender.Male),
            //        new Person(2, "Иванова", "Мария", "Ивановна", new DateTime(1980, 12, 06), Gender.Female),
            //        new Person(3, "Иванова", "Елена", "Ивановна", new DateTime(2012, 06, 06), Gender.Female),
            //        new Person(4, "Петров", "Петр", "Степанович", new DateTime(1946, 09, 06), Gender.Male),
            //        new Person(5, "Петрова", "Людмила", "Георгиевна", new DateTime(1947, 08, 01), Gender.Female),
            //        new Person(6, "Петров", "Денис", "Сергеевич", new DateTime(2021, 05, 01), Gender.Male)
            //};
        }

        //public event PropertyChangedEventHandler? PropertyChanged;
        //public void OnPropertyChanged([CallerMemberName] string prop = "")
        //{
        //    if (PropertyChanged != null)
        //        PropertyChanged(this, new PropertyChangedEventArgs(prop));
        //}

    }
}
