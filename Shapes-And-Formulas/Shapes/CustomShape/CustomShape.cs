using Shapes_And_Formulas.InterfacesAndAbstracts;
using Shapes_And_Formulas.Extensions;
namespace Shapes_And_Formulas.Shapes.CustomShape
{
    /// <summary>
    /// Класс для кастомных фигур. 
    /// Было интересно сделать класс, с помощью которого юзер может сам задавать переменные для формулы и саму, собственно, формулу
    /// </summary>
    public class CustomShape : Shape
    {
        #region Public properties
        /// <summary>
        /// Параметры фигуры для формулы площади (или любой другой формулы)
        /// </summary>
        public List<ShapeParameter> Parameters { get; protected set; } = new();

        public override string Name
        {
            get => _name;
            protected set => _name = value;
        }

        public override string AreaFormula
        {
            get => _areaFormula;
            protected set => _areaFormula = value;
        }

        public override string PerimeterFormula
        {
            get => _perimeterFormula;
            protected set => _perimeterFormula = value;
        }

        public override double Area => AreaFormula.FormatTemplate(Parameters).ComputeExpression();
        public override double Perimeter => PerimeterFormula.FormatTemplate(Parameters).ComputeExpression();
        #endregion

        #region Public methods
        /// <summary>
        /// Задать название кастомной фигуре
        /// </summary>
        /// <param name="name">Название</param>
        public void SetName(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Задать формулу площади кастомной фигуре
        /// </summary>
        /// <param name="formula">Текстовое представление для формулы площади. Пример: "Pow({0},2)"</param>
        /// <returns>Рабочая ли формула</returns>
        public bool SetAreaFormula(string formula)
        {
            string areaFormula = formula;
            try
            {
                areaFormula.FormatTemplate(Parameters).ComputeExpression();
                AreaFormula = formula;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }

        /// <summary>
        /// Задать формулу периметра кастомной фигуре
        /// </summary>
        /// <param name="formula">Текстовое представление для формулы периметра. Пример: "({0}+{1})*2"</param>
        /// <returns>Рабочая ли формула</returns>
        public bool SetPerimeterFormula(string formula)
        {
            string perimeterFormula = formula;
            try
            {
                perimeterFormula.FormatTemplate(Parameters).ComputeExpression();
                PerimeterFormula = formula;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        #endregion



        #region Private fields

        private string _name = string.Empty;
        private string _areaFormula = string.Empty;
        private string _perimeterFormula = string.Empty;

        #endregion







    }
}
