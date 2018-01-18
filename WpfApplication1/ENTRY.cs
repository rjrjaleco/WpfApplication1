using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class ENTRY
    {
        private int _id;
        private string _name;
        private string _age;
        private string _address;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                OnPropertyChanged("Age");
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                OnPropertyChanged("Address");
            }
        }
        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string e)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(e));
            }
        }
        #endregion
        #region Instantiate
        public ENTRY() { }
        public ENTRY(int iD, string name, string age, string address)
        {
            Id = iD;
            Name = name;
            Age = age;
            Address = address;
        }
        #endregion
    }
}
