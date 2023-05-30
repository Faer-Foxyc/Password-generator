using System;
using System.Linq;

namespace Password_generator.Classes
{
    internal class PasswordGeneratorClass
    {
        bool symbols { get; set; }
        int lengthsPassword { get; set; }

        public PasswordGeneratorClass(bool _symbols, int _lengthsPassword)
        {
            symbols = _symbols;
            lengthsPassword = _lengthsPassword;
        }
        public PasswordGeneratorClass() { }

        public string Generate() 
        {
            string password = string.Empty;

            if (symbols == false)
            {
                password = GeneratePasswordLetters();
            }
            else 
            {
                password = GeneratePasswordWithSymbol();
            }

            return password;
        }

        string GeneratePasswordLetters()
        {

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, lengthsPassword)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        string GeneratePasswordWithSymbol()
        {

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%&*";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, lengthsPassword)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
