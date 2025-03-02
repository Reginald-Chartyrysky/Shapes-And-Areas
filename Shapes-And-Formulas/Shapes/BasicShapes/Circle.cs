using Shapes_And_Formulas.InterfacesAndAbstracts;

namespace Shapes_And_Formulas.Shapes.BasicShapes
{
    /// <summary>
    /// Круг (круглый)
    /// </summary>
    public class Circle : BasicShape
    {
        #region Constants

        private const string CIRCLE_NAME = "Круг";

		#endregion

		public override string Name => CIRCLE_NAME;

		#region Formulas
		public override double Area => Math.PI * Radius * Radius; 
        
        public override double Perimeter => Math.PI * 2 * Radius;
        #endregion

        #region Parameters
        public double Radius { get; set; } = 0;
        #endregion
    }
}
