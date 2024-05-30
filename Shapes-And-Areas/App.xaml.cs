using Shapes_And_Formulas.Shapes.BasicShapes;
using Shapes_And_Formulas.Shapes.CustomShape;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Windows;

namespace Shapes_And_Areas
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;


            while (Application.Current != null)
            {
                CustomShape square = new();
                square.Parameters.Add(new ShapeParameter("Side", 5.2));
                square.SetAreaFormula("Pow({0},2)");

                Console.WriteLine(square.Area);
                square.Parameters[0].Value = 4;

                Console.WriteLine(square.Area);
                Console.ReadLine();

                Triangle triangle = new()
                {
                    A = 5.5,
                    B = 5.5,
                    C = 10
                };

                Console.WriteLine(triangle.Area);
                Console.ReadLine();
            }
            
        }
    }

}
