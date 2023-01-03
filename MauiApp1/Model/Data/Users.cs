using MauiApp1.Model.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Model.Data
{
    public class Users : IUser, INotifyPropertyChanged
    {
        private string _UserFirstName { get; set; }
        public string UserFirstName {
            get { return _UserFirstName; }
            set 
            { 
                if (_UserFirstName != value)
                {
                    _UserFirstName = value;
                    OnPropertyChanged("UserFirstName");
                }
            } 
        }
        private string _UserLastName { get; set; }
        public string UserLastName {

            get { return _UserLastName; }
            set
            {
                if (_UserLastName != value)
                {
                    _UserLastName = value;
                    OnPropertyChanged("UserLastName");
                }
            }
        }
        private string _HomePhone { get; set; }
        public string HomePhone {
            get { return _HomePhone; }
            set
            {
                if (_HomePhone != value)
                {
                    _HomePhone = value;
                    OnPropertyChanged("HomePhone");
                }
            }
        }

        private string _Note { get; set; }
        public string Note {
            get { return _Note; }
            set
            {
                if (_Note != value)
                {
                    _Note = value;
                    OnPropertyChanged("Note");
                }
            }
        }




        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string str)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(str));
            }
        }
    }
}
