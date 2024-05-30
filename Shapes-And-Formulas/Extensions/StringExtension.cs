using NCalc;
namespace Shapes_And_Formulas.Extensions
{
    public static class StringExtension
    {
        public static double ComputeExpression(this string str)
        {
            double result = 0;
            try
            {
                Expression expr = new(str);
                result = Convert.ToDouble(expr.Evaluate());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Ошибка при форматировании");
            }
            return result;
        }

    }

    
}
