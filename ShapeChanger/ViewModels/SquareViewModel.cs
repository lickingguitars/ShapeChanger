using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ShapeChanger.ViewModels
{
    public class SquareViewModel : Shape
    {
        //Constructors inherited from base
        public SquareViewModel() : base() { }
        public SquareViewModel(int size, Brush col, double op) : base(size, col, op) { }
    }
}
