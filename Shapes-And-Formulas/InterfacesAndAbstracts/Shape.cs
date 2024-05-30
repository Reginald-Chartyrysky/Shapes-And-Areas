using Shapes_And_Formulas.Extensions;

namespace Shapes_And_Formulas.InterfacesAndAbstracts
{
    /// <summary>
    /// Общий абстрактный класс для фигур
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Название фигуры
        /// </summary>
        public abstract string Name { get; protected set; }

        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public virtual double Area => AreaFormula.ComputeExpression();

        /// <summary>
        /// Периметр фигуры
        /// </summary>
        public virtual double Perimeter => PerimeterFormula.ComputeExpression();

        /// <summary>
        /// Формула площади фигуры
        /// </summary>
        public abstract string AreaFormula { get; protected set; }

        /// <summary>
        /// Формула периметра фигуры
        /// </summary>
        public abstract string PerimeterFormula { get; protected set; }

    }
}
