namespace TributechPoC.Utilities
{
    public static class StringValidatorExtensions
    {
        public static bool IsLengthBetween(this string input, int minLength, int maxLenght)
        {
            if (input.Length <= maxLenght && input.Length >= minLength)
                return true;
            return false;
        }

        public static bool IsLengthLessThan(this string input, int lenght)
        {
            return input.Length < lenght;
        }

        public static bool IsLengthLessThanOrEqual(this string input, int lenght)
        {
            return input.Length <= lenght;
        }
    }
}
