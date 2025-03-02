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
        public abstract string Name { get; }

        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public abstract double Area { get; }

        /// <summary>
        /// Периметр фигуры
        /// </summary>
        public abstract double Perimeter { get; }


    }
}
