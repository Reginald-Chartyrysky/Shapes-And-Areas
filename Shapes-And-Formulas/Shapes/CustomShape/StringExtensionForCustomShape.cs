using System.Globalization;
using System.Text.RegularExpressions;

namespace Shapes_And_Formulas.Shapes.CustomShape
{
    /// <summary>
    /// Класс для форматирования параметризированного <see cref="string"/>
    /// </summary>
    static class StringExtensionForCustomShape
    {
        /// <summary>
        /// Регекс для параметров типа "{n}", где n — число
        /// </summary>
        private static readonly Regex _parametersRegex = new(@"{(\d*)}", RegexOptions.Compiled);

        /// <summary>
        /// Заменяет все параметры типа "{n}" из шаблона <see cref="string"/>, используя значение из предоставленного списка параметров
        /// </summary>
        /// <param name="templateString">Шаблон</param>
        /// <param name="parameters">Список используемых параметров</param>
        /// <returns></returns>
        public static string FormatTemplate(this string templateString, List<ShapeParameter> parameters)
        {
            if (parameters is null) return templateString;
            
            return _parametersRegex.Replace(
                templateString,
                match =>
                {
                    int number = Convert.ToInt32( match.Value.Remove(0, 1).Remove(match.Value.Length - 2, 1) );
                    try
                    {
                        return parameters[number].Value.ToString(CultureInfo.InvariantCulture);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        throw new Exception("Ошибка при форматировании");
                    }
                });

        }
    }
}
