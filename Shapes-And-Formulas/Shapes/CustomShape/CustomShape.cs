using Shapes_And_Formulas.InterfacesAndAbstracts;
using Shapes_And_Formulas.Extensions;
namespace Shapes_And_Formulas.Shapes.CustomShape
{
    public class CustomShape : Shape
    {
        public List<ShapeParameter> Parameters { get; protected set; } = new();
        
        public override string Name
        {
            get => _name;
            protected set => _name = value;
        }
        private string _name = string.Empty;
        public override string AreaFormula
        {
            get => _areaFormula;
            protected set => _areaFormula = value;
        }

        private string _areaFormula = string.Empty;
        public override string PerimeterFormula
        {
            get => _perimeterFormula;
            protected set => _perimeterFormula = value;
        }

        private string _perimeterFormula = string.Empty;
        public void SetName(string name)
        {
            Name = name;
        }

        public override double Area => AreaFormula.FormatTemplate(Parameters).ComputeExpression();
        public override double Perimeter => PerimeterFormula.FormatTemplate(Parameters).ComputeExpression();
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
        public void SetPerimeterFormula(string formula)
        {
            PerimeterFormula = formula;
        }


    }
}
