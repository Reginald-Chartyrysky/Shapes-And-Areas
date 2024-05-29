
namespace Shapes_And_Formulas.InterfacesAndAbstracts
{
    public abstract class BasicShape: Shape
    {
        #region Constants

        protected const string TRY_TO_SET_NAME_ERROR = "Базовым фигурам нельзя задать имя";

        protected const string TRY_TO_SET_AREA_FORMULA_ERROR = "Базовым фигурам нельзя задать формулу площади";

        protected const string TRY_TO_SET_PERIMETER_FORMULA_ERROR = "Базовым фигурам нельзя задать формулу периметра";
        #endregion
    }
}
