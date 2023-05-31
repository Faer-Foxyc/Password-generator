using System;
using System.Linq;

namespace Password_generator.Classes
{
    internal class PasswordGeneratorClass
    {
        bool Symbols { get; set; }
        int LengthsPassword { get; set; }

        public PasswordGeneratorClass(bool _symbols, int _lengthsPassword)
        {
            Symbols = _symbols;
            LengthsPassword = _lengthsPassword;
        }
        public PasswordGeneratorClass() { }

        public string Generate() 
        {
            string password = string.Empty;

            const string charsWithoutSymbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            const string charsWithSymbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%&*";

            var random = new Random();
            var chars = Symbols ? charsWithSymbols : charsWithoutSymbols;

            return new string(Enumerable.Repeat(chars, LengthsPassword)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            return password;
        }
    }
}
