using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpendataLibrary;

namespace OpenDataWPF
{
    sealed class MyViewModel : INotifyPropertyChanged
    {
        private DataTransportline _transportline;

        public List<string> Names
        {
            get
            {
                return _transportline.getNames();
            }
            set { }
        }

        public ObservableCollection<TransportLine> DataTransportlines { get; set; }

        //public string LastName
        //{
        //    get { return user.LastName; }
        //    set
        //    {
        //        if (user.LastName != value)
        //        {
        //            user.LastName = value;
        //            OnPropertyChange("LastName");
        //            // If the first name has changed, the FullName property needs to be udpated as well.
        //            OnPropertyChange("FullName");
        //        }
        //    }
        //}

        // This property is an example of how model properties can be presented differently to the View.
        // In this case, we transform the birth date to the user's age, which is read only.


        // This property is just for display purposes and is a composition of existing data.

        public MyViewModel()
        {
            _transportline = new DataTransportline(5.73119705178461, 45.184446886268645);
            DataTransportlines = new ObservableCollection<TransportLine>(_transportline.Data);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
