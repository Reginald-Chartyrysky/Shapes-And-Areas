using Shapes_And_Formulas.Shapes.CustomShape;
using System.Reflection.Metadata;
using System.Windows;

namespace Shapes_And_Areas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CustomShape square = new();
            square.Parameters.Add(new ShapeParameter("Side", 5));
            square.SetAreaFormula("{0} * {0}");

            var res = square.Area;
            square.Parameters[0].Value = 4;
            res = square.Area;
        }
    }
}