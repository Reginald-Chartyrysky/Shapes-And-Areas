using NCalc;
namespace Shapes_And_Formulas.Extensions
{
    public static class StringExtension
    {
        /// <summary>
        /// Метод, вычисляющий результат математической операции, которая представлена через <see cref="string"/>
        /// </summary>
        /// <param name="str"></param>
        /// <returns>Результат операции <see cref="double"/></returns>
        /// <exception cref="Exception"></exception>
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
