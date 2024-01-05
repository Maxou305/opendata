using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml;
using System.Xml.Linq;
using Microsoft.Maps.MapControl.WPF;
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

        private ObservableCollection<Location> _pushpins;

        public ObservableCollection<Location> Pushpins
        {
            get { return _pushpins; }
            set
            {
                _pushpins = value;
            }
        }

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
            Pushpins = new ObservableCollection<Location>();
            Lon = 5.731507;
            Lat = 45.185018;
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
            Pushpins.Clear();
            foreach (TransportLine transportline in _transportline.Data)
            {
                DataTransportlines.Add(transportline);
                DisplayPin(transportline);
            }
        }
        public void DisplayPin(TransportLine line)
        {
            Pushpins.Add(new Location(line.Lat, line.Lon));
        }

    }
}
