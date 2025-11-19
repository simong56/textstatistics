using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TextStatistics
    {
        public int CountWords(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return 0;
            var words = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        public int CountSentences(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return 0;
            var sentences = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            return sentences.Length;
        }
        public string MostCommonWord(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return string.Empty;
            var words = text.Split(new char[] { ' ', '\n', '\r', '\t', '.', ',', '!', '?' },StringSplitOptions.RemoveEmptyEntries).Select(word => word.ToLowerInvariant());
            var mostCommon = words.GroupBy(word => word).OrderByDescending(group => group.Count()).First().Key;
            return mostCommon;
        }
    }
}
