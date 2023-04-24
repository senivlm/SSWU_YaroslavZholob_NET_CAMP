using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
// Ваші бали:90	0	0	95	85	70	0	68
namespace ConsoleApp.Ex1
{
    internal static class TextFromParentheses
    {

        public static List<string> GetTextFromParentheses(string text)
        {
            MatchCollection separators = Regex.Matches(text, @"(\.|\,|\?|!)");

            var separatorsPos = separators.Select(s => s.Index).ToList();

            var sentences = new List<string>();

            separatorsPos.Aggregate(-1, (a, b) =>
            {
                sentences.Add(text.Substring(a + 1, b - a));
                return b;
            });

            return sentences.Where(s => Regex.IsMatch(s, @"(\(.*\)|\{.*\}|\[.*\])"))
                            .Select(s => s)
                            .ToList();
        }
    }
}
