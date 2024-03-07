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
            StringBuilder replacebleWord = new StringBuilder();
            foreach (string word in words)
            {
                if (word.Length > 1)
                {
                    StringBuilder tmp = new StringBuilder(word);
                    (tmp[tmp.Length - 1], tmp[0]) = (tmp[0], tmp[tmp.Length - 1]);
                    replacebleWord.Append(tmp+" ");
                }
                else replacebleWord.Append(word+" ");
            }
            return replacebleWord.ToString();
        }

        //3
        public string HideNumber(string text)
        {
            Regex hidePattern = new Regex(@"\+\d\s*\(\d{3,5}\)\s*\d");
            string pattern1 = @"\d\d-\d\d-\d\d";
            string pattern2 = @"\d\d-\d\d";
            string words = Regex.Replace(text, $@"({hidePattern})({pattern1}|{pattern2})\b", message =>
            {
                return message.Groups[1]/*ПОлучаем текст группы захвата находящая текст по шаблону ({hide})*/
                + Regex.Replace(message.Groups[2].Value, @"\d", "x");/*Группа захвата ({n1}|{n2})*/
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
        public string ReturnIp(string text)
        {
            Regex regex = new Regex(@"\b(\d{1,3}\.){3}\d{1,3}\b");
            MatchCollection matches = regex.Matches(text);

            StringBuilder ipOutput = new StringBuilder("IPv4-адреса: ");
            foreach (Match match in matches)
            {
                ipOutput.Append(match + " ");
            }
            return ipOutput.ToString();
        }

        //6 Доп
        public string CorrectPhoneNumber(string phoneNum)
        {
            Regex hide = new Regex(@"(\+7|8)?(\d{3})(\d{3})(\d\d)(\d\d)");
            string words = Regex.Replace(phoneNum, $@"{hide}", " +7 ($2) $3-$4-$5");
           
            return words;
        }

    }
}

///8(\d{3}){2}(\d\d){2} | 8\s*(\d{3}\s*){2}(\d\d\s*)(\d\d) | 8\((\d{3})\)(\d{3})(\d\d){2} | 8\s*\((\d{3}))\s*(\d{3})\s*(\d\d\s*)(\d\d) |
