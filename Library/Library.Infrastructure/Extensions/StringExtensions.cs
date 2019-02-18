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

        public static bool CheckForForbiddenCharacters(this string text)
        {
            var forbiddenCharacters = "-ß¤+!§łŁ×÷€\\@#$%^&*(),.?\"':}{<>|0123456789";

            foreach (var character in forbiddenCharacters)
            {
                if (text.Contains(character.ToString()))
                    return false;
            }

            return true;
        }

        public static string FirstLetterCapitalization(this string text)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
        }

        public static string NameFormatting(this string text)
        {
            var formattedString = TrimAndRemoveMultipleWhiteSpaces(text);
            return FirstLetterCapitalization(formattedString);
        }
    }
}
