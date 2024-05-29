using Shapes_And_Formulas.InterfacesAndAbstracts;

namespace Shapes_And_Formulas.Shapes.BasicShapes
{
    public class Circle : BasicShape
    {
        #region Constants

        private const string CIRCLE_NAME = "Круг";

        #endregion

        public override string Name
        {
            get => CIRCLE_NAME;
            protected set => throw new NotSupportedException(TRY_TO_SET_NAME_ERROR);
        }

        #region Formulas
        public override string AreaFormula 
        {
            get => $"{Math.PI} * {Radius} * {Radius}"; 
            protected set => throw new NotSupportedException(TRY_TO_SET_AREA_FORMULA_ERROR); 
        }
        public override string PerimeterFormula 
        { 
            get => $"{Math.PI} * {2} * {Radius}";
            protected set => throw new NotSupportedException(TRY_TO_SET_PERIMETER_FORMULA_ERROR); 
        }
        #endregion

        #region Parameters
        public double Radius { get; set; } = 0;
        #endregion
    }
}
