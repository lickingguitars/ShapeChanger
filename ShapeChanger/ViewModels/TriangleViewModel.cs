using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace ShapeChanger.ViewModels
{
    public class TriangleViewModel : Shape, IMultiValueConverter
    {
        //Constructors inherited from base
        public TriangleViewModel() : base(){}
        public TriangleViewModel(int size, Brush col, double op) : base(size, col, op) { }

        //Point converter returns 3 points of triangle for polygon
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            //Generate points
            PointCollection pc = new PointCollection
            {
            new Point(0, Size), //Bottom left
            new Point(Size / 2, 0), //Top center
            new Point(Size, Size) // Bottom right
            };
            return pc;
        }

        //Not implemented as convertion back not required
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
