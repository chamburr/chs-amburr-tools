using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Conway_Life
{
    public class CellsBoard : IValueConverter, INotifyPropertyChanged
    {
        public string CellColour()
        {
            return MainWindow.BrushColour;
        }
        public List<CellsBoard> Neighbors { get; set; }

        public CellsBoard() //constructor that initializes new list when needed 
        {
            Neighbors = new List<CellsBoard>();
        }

        public int LiveNeighborCount
        {
            get
            {
                int count = 0;
                foreach (CellsBoard neighbor in Neighbors)
                {
                    if (neighbor.IsAlive)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        private bool _isAlive;

        public bool IsAlive
        {
            get
            {
                return _isAlive;
            }
            set
            {
                _isAlive = value;
                NotifyPropertyChanged("IsAlive");
            }
        }

        public bool CheckIfAlive;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); //checks if null
        }

        public SolidColorBrush brushColour;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (CellColour())
            {
                case "Black":
                    brushColour = Brushes.Black;
                    break;

                case "Red":
                    brushColour = Brushes.Red;
                    break;

                case "Yellow":
                    brushColour = Brushes.Yellow;
                    break;

                case "Green":
                    brushColour = Brushes.Green;
                    break;

                default:
                    brushColour = Brushes.Black;
                    break;
            }
            SolidColorBrush brush = null;
            if (targetType == typeof(Brush))
            {
                brush = (bool)value ? brushColour : Brushes.Gray;
            }
            return brush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}