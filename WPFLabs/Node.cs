using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace WPFLabs
{
    public  class Node 
    {
        public string Name { get; set; }
        public ObservableCollection<Node> Nodes { get; set; }
    }
}
