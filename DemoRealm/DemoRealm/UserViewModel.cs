using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoRealm
{
    public class UserViewModel : INotifyPropertyChanged
    {
        private string _Name { get; set; }
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }

        private string _LastName { get; set; }
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                _LastName = value;
                OnPropertyChanged("LastName");
            }
        }
        private int _Grade { get; set; }
        public int Grade
        {
            get
            {
                return _Grade;
            }
            set
            {
                _Grade = value;
                OnPropertyChanged("Grade");
            }
        }
        public ICommand SaveCommand { get; set; }
        public UserViewModel()
        {
            SaveCommand = new Command(Save);
        }

        private void Save()
        {
            UserModel.SalvarUsuario(new UserModel { Nombre= Name, Apellido=LastName,Nota=Grade });

        }
  

        #region INotifyPropertyChange Interface

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

        }

        #endregion
    }
}
