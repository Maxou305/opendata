using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using OpendataLibrary;
using OpenDataWPF.Commands;

namespace OpenDataWPF
{
    sealed class MyViewModel : INotifyPropertyChanged
    {
        private double _longitude;
        private double _latitude;
        private int _radius;
        private DataTransportline _transportline;
        public ObservableCollection<TransportLine> DataTransportlines { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand SearchCommand { get; private set; }

        private DataTransportline Transportline
        {
            get; set;
        }
        public double Lon
        {
            get { return _longitude; }
            set
            {
                {
                    if (_longitude != value)
                    {
                        _longitude = value;
                    }
                }
            }
        }
        public double Lat
        {
            get { return _latitude; }
            set
            {
                {
                    if (_latitude != value)
                    {
                        _latitude = value;
                    }
                }
            }
        }
        public int Radius
        {
            get { return _radius; }
            set
            {
                {
                    if (_radius != value)
                    {
                        _radius = value;
                    }
                }
            }
        }

        public MyViewModel()
        {
            SearchCommand = new RelayCommand(DoNewRequest);
            DataTransportlines = new ObservableCollection<TransportLine>();
            Lon = 5.73119705178461;
            Lat = 45.184446886268645;
            Radius = 100;
        }

        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public void DoNewRequest(object obj)
        {
            _transportline = new DataTransportline(_longitude, _latitude, _radius);
            DataTransportlines.Clear();
            foreach (TransportLine transportline in _transportline.Data)
            {
                DataTransportlines.Add(transportline);
            }
        }
    }
}
