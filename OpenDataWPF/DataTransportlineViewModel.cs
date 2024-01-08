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
        private double _zoomLevel;
        private Location _mapCenter;
        private DataTransportline _transportline;
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Location> _pushpins;

        public ObservableCollection<TransportStop> DataTransportlines { get; set; }

        public Location MapCenter
        {
            get => _mapCenter;
            set
            {
                _mapCenter = value;
                OnPropertyChange("MapCenter");
            }
        }

        public double ZoomLevel
        {
            get => _zoomLevel;
            set
            {
                _zoomLevel = value;
                OnPropertyChange("ZoomLevel");
            }
        }

        public ICommand SearchCommand { get; private set; }

        public ObservableCollection<Location> Pushpins
        {
            get { return _pushpins; }
            set
            {
                _pushpins = value;
            }
        }     

        public double Lon
        {
            get { return _longitude; }
            set
            {

                if (_longitude != value)
                {
                    _longitude = value;
                }

            }
        }
        public double Lat
        {
            get { return _latitude; }
            set
            {

                if (_latitude != value)
                {
                    _latitude = value;
                }

            }
        }
        public int Radius
        {
            get { return _radius; }
            set
            {

                if (_radius != value)
                {
                    _radius = value;
                }

            }
        }

        public MyViewModel()
        {
            SearchCommand = new RelayCommand(GetListOfStops);
            DataTransportlines = new ObservableCollection<TransportStop>();
            Pushpins = new ObservableCollection<Location>();
            Lon = 5.731507;
            Lat = 45.185018;
            Radius = 100;
            ZoomLevel = 12.0;
            MapCenter = new Location(45.185018, 5.731507);
        }

        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void GetListOfStops(object obj)
        {
            _transportline = new DataTransportline(_longitude, _latitude, _radius);
            DisplayResult();
        }


        public void DisplayResult()
        {
            DataTransportlines.Clear();
            Pushpins.Clear();
            foreach (TransportStop transportline in _transportline.Data)
            {
                DataTransportlines.Add(transportline);
                DisplayPin(transportline);
            }
            ZoomLevel = 18;
            MapCenter = new Location(Lat, Lon);
            Pushpins.Add(MapCenter);
        }

        public void DisplayPin(TransportStop line)
        {
            Pushpins.Add(new Location(line.Lat, line.Lon));
        }

    }
}
