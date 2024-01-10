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
    sealed class MainWindowViewModel : INotifyPropertyChanged
    {
        private double _longitude;
        private double _latitude;
        private int _radius;
        private double _zoomLevel;
        private Location _mapCenter;
        private DataTransportline _dataTransportline;
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Location> _pushpins;

        public Location SearchPosition
        {
            get => _mapCenter;
            set
            {
                _mapCenter = value;
                OnPropertyChange("SearchPosition");
            }
        }

        public ObservableCollection<TransportStop> ResultData { get; set; }

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
            get => _pushpins;
            set
            {
                _pushpins = value;
            }
        }

        public double Lon
        {
            get => _longitude;
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
            get => _latitude;
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
            get => _radius;
            set
            {

                if (_radius != value)
                {
                    _radius = value;
                }

            }
        }

        public MainWindowViewModel()
        {
            SearchCommand = new RelayCommand(GetListOfStops);
            ResultData = new ObservableCollection<TransportStop>();
            Pushpins = new ObservableCollection<Location>();
            Lon = 5.731507;
            Lat = 45.185018;
            Radius = 100;
            ZoomLevel = 12.0;
            MapCenter = new Location(Lat, Lon);
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
            _dataTransportline = new DataTransportline(Lon, Lat, Radius);
            DisplayResult();
        }

        public void DisplayResult()
        {
            ClearObservabelsCollections();

            foreach (TransportStop transportline in _dataTransportline.Data)
            {
                ResultData.Add(transportline);
                DisplayPin(transportline);
            }

            ZoomLevel = setZoomLevel();
            MapCenter = new Location(Lat, Lon);
            SearchPosition = MapCenter;
        }

        public void ClearObservabelsCollections()
        {
            ResultData.Clear();
            Pushpins.Clear();
        }

        public void DisplayPin(TransportStop line)
        {
            Pushpins.Add(new Location(line.Lat, line.Lon));
        }

        public double setZoomLevel()
        {
            if (Radius < 100)
            {
                return 18;
            }
            else if (Radius < 700)
            {
                return 16;
            }
            else if (Radius < 900)
            {
                return 15.5;
            }
            else
            {
                return 14.5;
            }
        }
    }
}
