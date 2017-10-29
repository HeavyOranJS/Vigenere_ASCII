using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Visiner
{
    class Visiner
    {
        //char[] trimmer = { '.', ' ', '\'' };
        //а = 1072; я = 1103; нет ё
        private const int a = 1072;
        private const int ya = 1103;

        private const int alphaLength = ya-a+1;
        private const int alphaPreLength = a-1;

        private char VigenereInc(int _charAsciiInput, int _charAsciiKey)
        {
            int _answer = 0;
            if (_charAsciiInput + (_charAsciiKey) > ya)
            {
                _answer = _charAsciiInput + _charAsciiKey - alphaLength;
            }
            else
            {
                _answer = _charAsciiInput + _charAsciiKey;
            }
            return (char)_answer;
        }

        private char VigenereDec(int _charAsciiInput, int _charAsciiKey)
        {
            int _answer = 0;
            if (_charAsciiInput - (_charAsciiKey) < a)
            {
                _answer = _charAsciiInput - _charAsciiKey + alphaLength;
            }
            else
            {
                _answer = _charAsciiInput - _charAsciiKey;
            }
            return (char)_answer;
        }

        public string Cipher(string textInput, string textKey, bool chiper, int ROT)
        {
            int keyIndex = 0;
            string answer = "";
            for (int i = 0; i < textInput.Length; i++)
            {
                if (char.IsLetter(textInput[i])){
                    if (keyIndex >= textKey.Length)
                        keyIndex = 0;
                    int charAsciiInput = (int)textInput[i];
                    int charAsciiKey = (int)textKey[keyIndex] - alphaPreLength - 1 + ROT;//translate current key symbols's ASCII code to numbers

                    keyIndex++;
                    answer += chiper ? VigenereInc(charAsciiInput, charAsciiKey) : VigenereDec(charAsciiInput, charAsciiKey);
                }
                else
                {
                    answer += textInput[i];//spaces and non-alphabetic chars
                }
            }
            return answer;
        }

        public void Alphabet()
        {
            //for (int i = 1072; i <= 1103; i++)
            //{
            //    richOutput.Text += (char)i + " - " + i + " - " + (i - 1072) + "\n";
            //}
        }
    }
}
