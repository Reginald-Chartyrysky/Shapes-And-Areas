namespace Shapes_And_Formulas.Shapes.CustomShape
{
    /// <summary>
    /// Класс параметров кастомной фигуры
    /// </summary>
    /// <param name="name">Название параметра</param>
    /// <param name="value">Значение параметра</param>
    public class ShapeParameter(string name, double value)
    {
        /// <summary>
        /// Название параметра
        /// </summary>
        public string Name { get; set; } = name;
        /// <summary>
        /// Значение параметра
        /// </summary>
        public double Value { get; set; } = value;
    }
}
