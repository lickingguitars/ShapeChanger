using ShapeChanger.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShapeChanger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Initialize default shap on startup
        ViewModels.Shape _shape = new CircleViewModel();

        public MainWindow()
        {
            InitializeComponent();

            //Set dataconext to shape
            DataContext = _shape;
        }

        //Shape selector handlers

        //Circle selector button
        private void CircleButton_Clicked(object sender, RoutedEventArgs e)
        {
            //Create newly selected shape, copying existing set values, and update datacontext
            _shape = new CircleViewModel(_shape.Size,_shape.Colour,_shape.Opacity);
            DataContext = _shape;
        }

        //Square selector button
        private void SquareButton_Clicked(object sender, RoutedEventArgs e)
        {
            //Create newly selected shape, copying existing set values, and update datacontext
            _shape = new SquareViewModel(_shape.Size, _shape.Colour, _shape.Opacity);
            DataContext = _shape;
        }

        //Triangle selector button
        private void TriangleButton_Clicked(object sender, RoutedEventArgs e)
        {
            //Create newly selected shape, copying existing set values, and update datacontext
            _shape = new TriangleViewModel(_shape.Size, _shape.Colour, _shape.Opacity);
            DataContext = _shape;
        }

        //Colour selector handlers

        //Blue selector button
        private void Blue_Clicked(object sender, RoutedEventArgs e)
        {
            _shape.Colour = Brushes.Blue;
        }

        //Green selector button
        private void Green_Clicked(object sender, RoutedEventArgs e)
        {
            _shape.Colour = Brushes.Green;
        }

        //Red selector button
            private void Red_Clicked(object sender, RoutedEventArgs e)
        {
            _shape.Colour = Brushes.Red;
        }

        //Yellow selector button
        private void Yellow_clicked(object sender, RoutedEventArgs e)
        {
            _shape.Colour = Brushes.Yellow;
        }
    }
}
