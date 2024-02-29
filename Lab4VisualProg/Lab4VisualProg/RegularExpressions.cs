using System;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
namespace Lab4VisualProg
{
    public class RegularExpressions
    {
        //1
        public int PostCount(string text)
        {
            Regex countPost = new Regex(@"\b\d{6}\b");
            MatchCollection matches = countPost.Matches(text);

            int count = matches.Count();
            return count;
        }
        //2
        public string Replaceble(string text)
        {
            string[] words = text.Split(" ");
            StringBuilder v1 = new StringBuilder();
            foreach (string word in words)
            {
                if (word.Length > 1)
                {
                    StringBuilder tmp = new StringBuilder(word);
                    (tmp[tmp.Length - 1], tmp[0]) = (tmp[0], tmp[tmp.Length - 1]);
                    v1.Append(tmp+" ");
                }
                else v1.Append(word+" ");
            }
            return v1.ToString();
        }
        //3
        public string HideNumber(string text)
        {
            Regex hide = new Regex(@"\+\d\s*\(\d{3,5}\)\s*\d");
            string n1 = @"\d\d-\d\d-\d\d";
            string n2 = @"\d\d-\d\d";
            string words = Regex.Replace(text, $@"({hide})({n1}|{n2})\b", m =>
            {
                return m.Groups[1]/*ПОлучаем текст группы захвата находящая текст по шаблону ({hide})*/
                + Regex.Replace(m.Groups[2].Value, @"\d", "x");/*Группа захвата ({n1}|{n2})*/
            });
            return words;
        }
        //4
        public string FindAutoNum(string text)
        {
            Regex autoNumber = new Regex(@"\b[А-Я]\d{3}[А-Я]{2}\d{2,3}\b|\b\d{4}[А-Я]{2}\d{2}\b|\b[А-Я]\d{3}[А-Я]{2}\b");
            MatchCollection num = autoNumber.Matches(text);
            StringBuilder autoOutput = new StringBuilder("Номера: ");
            foreach (var word in num)
            {
                autoOutput.Append(word + " ");
            }
            return autoOutput.ToString();
        }
        //5

    }
}
