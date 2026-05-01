using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace WPFLabs
{
    public class Company
    {
        public string Name { get; set; }
        public ObservableCollection<Smartphone> Phones { get; set; }
        public Company()
        {
            Phones = new ObservableCollection<Smartphone>();
        }
    }
}
