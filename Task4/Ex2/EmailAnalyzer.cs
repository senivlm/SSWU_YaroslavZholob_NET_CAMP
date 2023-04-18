using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp.Ex2
{
    internal static class EmailAnalyzer
    {
        private static string addressRegex = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";
        private static string lexemeRegex = @"\b\w+@\w+\b";

        public static (Dictionary<string,List<string>>, Dictionary<string, List<string>>) ReturnValidAddresses(string address)
        {
            var validAdresses = new Dictionary<string, List<string>>();
            validAdresses.Add("Valid email addresses", new List<string>());
            var validLexeme = new Dictionary<string, List<string>>();
            validLexeme.Add("Valid lexeme", new List<string>());

            Regex.Matches(address, addressRegex).ToList().ForEach(a => validAdresses["Valid email addresses"].Add(a.Value));
            Regex.Matches(address, lexemeRegex).ToList().ForEach(l =>
            {
                if (l.Value != new System.Net.Mail.MailAddress(l.Value).Address)
                    validLexeme["Valid lexeme"].Add(l.Value);
            });
            return (validAdresses, validLexeme);
        }

    }
}
