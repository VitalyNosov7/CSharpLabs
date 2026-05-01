using System;
using System.Collections.Generic;
using System.Text;

namespace WPFLabs
{
    public interface IFileService
    {
        List<Phone> Open(string filename);
        void Save(string filename, List<Phone> phonesList);
    }
}
