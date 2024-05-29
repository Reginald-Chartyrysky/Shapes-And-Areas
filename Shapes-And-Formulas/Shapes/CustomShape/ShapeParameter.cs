namespace Shapes_And_Formulas.Shapes.CustomShape
{
    public class ShapeParameter(string name, double value)
    {
        public string Name { get; set; } = name;
        public double Value { get; set; } = value;
    }
}
