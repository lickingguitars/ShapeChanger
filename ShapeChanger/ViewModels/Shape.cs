using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ShapeChanger.ViewModels
{
    
    public class Shape : ObservableObject
    {
        private Double _opacity;
        private Brush _colour;
        private int _size;

        //Constructor - default values
        public Shape()
        {
            _colour = Brushes.Blue;
            _opacity = 1;
            _size = 100;
        }

        //Constructor - assign values
        public Shape(int size,Brush colour, Double opacity)
        {
            _colour = colour;
            _opacity = opacity;
            _size = size;
        }

        //Size accessor/mutator
        public int Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = value;
                onPropertyChanged("Size");
            }
        }

        //Opacity accessor/mutator
        public Double Opacity
        {
            get
            {
                 return _opacity;
            }
            set
            {
                _opacity = value;
                onPropertyChanged("Opacity");
            }
        }

        //Colour accessor/mutator
        public Brush Colour
        {
            get
            {
                if (_colour == null)
                {
                    return Brushes.Black;
                }
                else
                {
                    return _colour;
                }
            }
            set
            {
                _colour = value;
                onPropertyChanged("Colour");
            }
        }
    }
}
