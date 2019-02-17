using System.Globalization;
using System.Text.RegularExpressions;

namespace Library.Infrastructure.Extensions
{
    public static class StringExtensions
    {
        public static string TrimAndRemoveMultipleWhiteSpaces(this string text)
        {
            text = text.Trim();
            var regex = new Regex(@"\s{2,}");
            while (regex.IsMatch(text))
                text = regex.Replace(text, " ", 1);
            return text;
        }

        public static string TrimAndRemoveWhiteSpaces(this string text)
        {
            text = text.Trim();
            var regex = new Regex(@"\s{1,}");
            while (regex.IsMatch(text))
                text = regex.Replace(text, "", 1);
            return text;
        }

        public static string FirstLetterCapitalization(this string text)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
        }

        public static string NameFormatting(this string text)
        {
            var textWithoutMultipleWhiteSpaces = TrimAndRemoveMultipleWhiteSpaces(text);
            return FirstLetterCapitalization(textWithoutMultipleWhiteSpaces);
        }
    }
}
