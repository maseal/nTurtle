using System.Collections.Generic;
using System.Globalization;

namespace NTurtle.Core.Extensions
{
    public static class CharExtensions
    {
        /// <summary>
        /// Determines whether the specified character is a word character (equivalent to '\w').
        /// </summary>
        /// <param name="c">The c.</param>
        public static bool IsWordChar(this char c) => WordLetterCategories.Contains(char.GetUnicodeCategory(c));
        public static bool IsDigit(this char c) => char.GetUnicodeCategory(c) == UnicodeCategory.DecimalDigitNumber;

        public static bool IsBreak(this char c) => (c == '\x0a' || c == '\n');

        public static bool IsTab(this char c) => (c == '\x09' || c == '\t');

        public static bool IsWhiteSpace(this char c) => (c == ' ' || IsTab(c));

        private static readonly HashSet<UnicodeCategory> WordLetterCategories = new HashSet<UnicodeCategory>(
            new[]
            {
                UnicodeCategory.UppercaseLetter,
                UnicodeCategory.ConnectorPunctuation,
                UnicodeCategory.LowercaseLetter,
                UnicodeCategory.OtherLetter,
                UnicodeCategory.TitlecaseLetter,
                UnicodeCategory.ModifierLetter,
                UnicodeCategory.NonSpacingMark,
            });
    }
}