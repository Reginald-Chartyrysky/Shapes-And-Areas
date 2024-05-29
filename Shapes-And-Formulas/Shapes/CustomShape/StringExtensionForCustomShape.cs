using System.Text.RegularExpressions;

namespace Shapes_And_Formulas.Shapes.CustomShape
{
    static class StringExtensionForCustomShape
    {
        private static readonly Regex ParametersRegex = new(@"{(\d*)}", RegexOptions.Compiled);
        
        /// <summary>
        /// Replaces all the items in the template string with format "{variable}" using the value from the data
        /// </summary>
        /// <param name="templateString">string template</param>
        /// <param name="model">The data to fill into the template</param>
        /// <returns></returns>
        public static string FormatTemplate(this string templateString, List<ShapeParameter> parameters)
        {
            if (parameters is null) return templateString;
            
            return ParametersRegex.Replace(
                templateString,
                match =>
                {
                    int number = Convert.ToInt32( match.Value.Remove(0, 1).Remove(match.Value.Length - 2, 1) );
                    try
                    {
                        return parameters[number].Value.ToString();
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        return "0";
                    }
                });

        }
    }
}
