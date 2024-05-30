using Shapes_And_Formulas.InterfacesAndAbstracts;
using Shapes_And_Formulas.Shapes.BasicShapes;
using Shapes_And_Formulas.Shapes.CustomShape;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Windows;
using Shape = Shapes_And_Formulas.InterfacesAndAbstracts.Shape;
namespace Shapes_And_Areas
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private List<Shape> _figures = [new Circle(), new Triangle()];

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;


            while (Application.Current != null)
            {

                foreach (Shape shape in _figures)
                {
                    Console.WriteLine($"{_figures.IndexOf(shape) + 1}. Посчитать площадь {shape.Name}");
                }

                Console.WriteLine($"{_figures.Count + 1}. Создать новую фигуру");

                string? input = Console.ReadLine();

                if (!int.TryParse(input, out int value))
                {
                    Console.WriteLine("Введено не число");
                    continue;
                };


                if (value < 1 || value > _figures.Count + 1)
                {
                    Console.WriteLine("Введена неизвестная команда");
                    continue;
                };


                if (value <= _figures.Count)
                {
                    Shape currShape = _figures[value-1];

                    switch (currShape)
                    {
                        case Circle circle:
                            {
                                do
                                {
                                    Console.WriteLine("Введите радиус круга (положительное число)");

                                    double.TryParse(Console.ReadLine(), out var circleRadius);
                                    circle.Radius = circleRadius > 0 ? circleRadius : 0;

                                } while (circle.Radius == 0);

                                break;
                            }
                        case Triangle triangle:
                            {
                                do
                                {
                                    Console.WriteLine("Помните, что треугольник является треугольником, только когда сумма двух его любых сторон больше третьей");

                                    Console.WriteLine("Введите первую сторону треугольника (положительное число)");

                                    double.TryParse(Console.ReadLine(), out var a);
                                    triangle.A = a;

                                    Console.WriteLine("Введите вторую сторону треугольника (положительное число)");

                                    double.TryParse(Console.ReadLine(), out var b);
                                    triangle.B = b;

                                    Console.WriteLine("Введите третью сторону треугольника (положительное число)");

                                    double.TryParse(Console.ReadLine(), out var c);
                                    triangle.C = c;

                                } while (triangle.Area == 0);

                                if (triangle.IsRightTriangle)
                                {
                                    Console.WriteLine("О, прямой треугольник. Неплохо");
                                }

                                break;
                            }
                        case CustomShape custom:
                            {
                                foreach(ShapeParameter param in custom.Parameters)
                                {
                                    bool paramIsSet = false;
                                    do
                                    {
                                        Console.WriteLine($"Введите {param.Name}");
                                        if (!double.TryParse(Console.ReadLine(), out var paramValue))
                                            continue;

                                        param.Value = paramValue;
                                        paramIsSet = true;
                                    }while (paramIsSet is false);
                                    
                                }
                                break;
                            }
                        default:
                            break;
                    }

                    Console.WriteLine($"Найденная площадь: {currShape.Area}"); ;
                }

                if (value == _figures.Count + 1)
                {
                    CustomShape newCustom = new();

                    Console.WriteLine("Введите название новой фигуры");
                    newCustom.SetName(Console.ReadLine() ?? "Нет названия");
                    bool isDone;
                    do
                    {
                        Console.WriteLine("Введите название параметра фигуры");
                        string paramName = Console.ReadLine() ?? "Нет названия";

                        newCustom.Parameters.Add(new ShapeParameter(paramName, 0));

                        Console.WriteLine("Наберите \"done\", чтобы закончить добавлять параметры. Чтобы продолжить введите что-либо другое");

                        isDone = Console.ReadLine() == "done";

                    } while (isDone is false);


                    bool isFormulaSet;
                    do
                    {
                        Console.WriteLine("Введите формулу площади фигуры\n");

                        Console.WriteLine("Формула имеет следующий формат.");

                        Console.WriteLine("Доступные символы:\n");
                        Console.WriteLine("{n}, где n — индекс введенных параметров (начиная с 0)");

                        Console.WriteLine("+");
                        Console.WriteLine("-");
                        Console.WriteLine("*");
                        Console.WriteLine("/");

                        Console.WriteLine("Pow(n,q), где n — число, q — степень");

                        Console.WriteLine("Sqrt(n), где n — число\n");


                        Console.WriteLine("Пример площади квадрата, где первый (и единственный) параметр – его сторона:");

                        Console.WriteLine("Pow({0},2)");

                        string paramFormula = Console.ReadLine() ?? string.Empty;

                        isFormulaSet = newCustom.SetAreaFormula(paramFormula);

                    } while (!isFormulaSet);

                    _figures.Add(newCustom);
                }

                Console.WriteLine("\n\n"); ;

            }

        }

        
    }

}
