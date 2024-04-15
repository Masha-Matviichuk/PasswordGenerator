namespace PasswordGenerator
{
    public class PasswordGeneratorSettings : PasswordSettings
    {
        public PasswordGeneratorSettings(bool includeLowercase, bool includeUppercase, bool includeNumeric, 
            bool includeSpecial, int passwordLength, int maximumAttempts, bool usingDefaults, bool useOwnCharactersSet = false, string latinCharactersSet = null) 
            : base(includeLowercase, includeUppercase, includeNumeric, 
                includeSpecial, passwordLength, maximumAttempts, usingDefaults, useOwnCharactersSet, latinCharactersSet)
        {
        }
    }
}
