using Shapes_And_Formulas.InterfacesAndAbstracts;

namespace Shapes_And_Formulas.Shapes.BasicShapes
{
    /// <summary>
    /// Треугольник (треугольный)
    /// </summary>
    public class Triangle : BasicShape
    {

        #region Constants

        private const string TRIANGLE_NAME = "Треугольник";

        #endregion
        public override string Name
        {
            get => TRIANGLE_NAME;
            protected set => throw new NotSupportedException(TRY_TO_SET_NAME_ERROR);
        }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRightTriangle => 
            double.Equals(Math.Pow(_hypotenuse, 2) , (Math.Pow(_firstCatet, 2) + Math.Pow(_secondCatet, 2)));

        #region Formulas
        public override string AreaFormula
        {
            get => $"Sqrt({_halfPerimeter} * ({_halfPerimeter} - {A}) * ({_halfPerimeter} - {B}) * ({_halfPerimeter} - {C}))";
            protected set => throw new NotSupportedException(TRY_TO_SET_AREA_FORMULA_ERROR);
        }
        public override string PerimeterFormula 
        {
            get => $"{A} + {B} + {C}";
            protected set => throw new NotSupportedException(TRY_TO_SET_PERIMETER_FORMULA_ERROR); 
        }
        #endregion

        #region Parameters
        private double _halfPerimeter => Perimeter / 2;

        private double _hypotenuse => _sides.Max();

        private double _firstCatet => _sides.FirstOrDefault(x => x != _hypotenuse);

        private double _secondCatet => _sides.LastOrDefault(x => x != _hypotenuse);

        private readonly List<double> _sides = [0, 0 ,0];

        /// <summary>
        /// Первая сторона треугольника
        /// </summary>
        public double A
        {
            get => _sides[0];
            set => _sides[0] = value;
        }

        /// <summary>
        /// Вторая сторона треугольника
        /// </summary>
        public double B
        {
            get => _sides[1];
            set => _sides[1] = value;
        }

        /// <summary>
        /// Третья сторона треугольника
        /// </summary>
        public double C
        {
            get => _sides[2];
            set => _sides[2] = value;
        }

        #endregion


    }
}
