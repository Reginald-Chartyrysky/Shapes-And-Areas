using Shapes_And_Formulas.Extensions;

namespace Shapes_And_Formulas.InterfacesAndAbstracts
{
    public abstract class Shape
    {
        public abstract string Name { get; protected set; }
        public virtual double Area => AreaFormula.ComputeExpression();
        public virtual double Perimeter => PerimeterFormula.ComputeExpression();

        public abstract string AreaFormula { get; protected set; }
        public abstract string PerimeterFormula { get; protected set; }

    }
}
