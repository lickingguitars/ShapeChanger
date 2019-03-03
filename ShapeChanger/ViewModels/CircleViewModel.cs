using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ShapeChanger.ViewModels
{
    public class CircleViewModel : Shape
    {
        //Constructors inherited from base
        public CircleViewModel() : base() { }
        public CircleViewModel(int size,Brush col,double op) : base(size,col,op) { }

    }
}
