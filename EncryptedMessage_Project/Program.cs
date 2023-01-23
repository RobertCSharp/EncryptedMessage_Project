using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptedMessage_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a method that takes an encrypted text and decodes it with the following pattern:
            // - instead * replace with a
            // - instead @ replace withe t
            // - instead ! replace with W
            // - instead ^ replace with o
            // - instead & replace with i
            // - instead % replace with f
            // - instead ) replace with e
            // - instead # replace with s
            // - instead $ replace with n

            string encryptedText = "!) %^u$d @h) @*rg)@'# l^c*@&^$. !*&@&$g %^r @h) $)x@ m&##&^$..";
            Console.WriteLine(DecryptText(encryptedText));
            Console.WriteLine(DecrypText2(encryptedText));

            Console.ReadKey();
        }

        static string DecryptText(string text)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case '*':
                        result.Append('a');
                        break;
                    case '@':
                        result.Append('t');
                        break;
                    case '!':
                        result.Append('W'); ;
                        break;
                    case '^':
                        result.Append('o');
                        break;
                    case '&':
                        result.Append('i');
                        break;
                    case '%':
                        result.Append('f');
                        break;
                    case ')':
                        result.Append('e');
                        break;
                    case '#':
                        result.Append('s');
                        break;
                    case '$':
                        result.Append('n');
                        break;
                    default:
                        result.Append(text[i]);
                        break;
                }
            }

            return result.ToString();
        }

        static string DecrypText2(string text)
        {
            return text.Replace('*', 'a')
                .Replace('@', 't')
                .Replace('!', 'W')
                .Replace('^', 'o')
                .Replace('&', 'i')
                .Replace('%', 'f')
                .Replace(')', 'e')
                .Replace('#', 's')
                .Replace('$', 'n');
        }
    }
}
