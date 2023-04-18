using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SigmaHomeTask1.Task3
{//Освоїли лінки гарно!)))
    internal class StringTask
    {
        //Знайти індекс другого входження заданої підстрічки в текст, якщо таке
        //входження існує, у іншому випадку - повернути null.
        public int? IndexOfSecondSubstring(string text, string subString)
        {
            for (int i = 1, pos = text.IndexOf(subString); i <= 2 && pos != -1; i++)
            {
                if (i == 2)
                    return pos;
                pos = text.IndexOf(subString, pos + subString.Length);
            }

            return null;
        }
        //Повернути кількість слів, що починаються з великої літери.
        public int WordsCountWithCapital(string text)
        {
            return text.Split(new string[] { "<<", "...", " ", ",", ".", "-", "\n", "\t", "|", "\\", "*", "&", "%" }, StringSplitOptions.RemoveEmptyEntries)
                    .Where(word => !string.IsNullOrEmpty(word) && char.IsUpper(word[0]))
                    .Count();
        }
        //Замінити всі слова, що містять подвоєння літер на заданий користувачем текст.
        public void ReplaceWordsWithDoubleLetters(string text, string userText)
        {
            //works only for words with one duplicate-letters group!
            var words = text.Split(new string[] { "<<", "...", " ", ",", ".", "-", "\n", "\t", "|", "\\", "*", "&", "%" }, StringSplitOptions.RemoveEmptyEntries)
                .Where(word => word.Count() > 1);

            words.Where(word => HasWordDoubleLetters(word) != -1)
                 .ToList()
                 .ForEach(word => word.Replace(word.Substring(HasWordDoubleLetters(word), 2), userText));
        }
        private int HasWordDoubleLetters(string word)
        {
            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] == word[i + 1])
                    return i;
            }
            return -1;
        }
    }
}
