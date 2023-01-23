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
        }

        static string DecryptText(string text)
        {
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case '*':
                        result += 'a';
                        break;
                    case '@':
                        result += 't';
                        break;
                    case '!':
                        result += 'W';
                        break;
                    case '^':
                        result += 'o';
                        break;
                    case '&':
                        result += 'i';
                        break;
                    case '%':
                        result += 'f';
                        break;
                    case ')':
                        result += 'e';
                        break;
                    case '#':
                        result += 's';
                        break;
                    case '$':
                        result += 'n';
                        break;
                    default:
                        result += text[i];
                        break;
                }
            }

            return result;
        }
    }
}
