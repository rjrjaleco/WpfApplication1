using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApplication1
{
    class MVM
    {
        ObservableCollection<ENTRY> _entryList = new ObservableCollection<ENTRY>();
        public ObservableCollection<ENTRY> EntryList { get { return _entryList; } }

        public void AddEntry()
        {
            var window = new AddEntryWindow();
            window.Owner = Application.Current.MainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;

            var newEntry = new ENTRY();
            window.DataContext = newEntry;

            var result = window.ShowDialog();
            if(result == true)
            {
                _entryList.Add(newEntry);
            }
        }

    }
}
