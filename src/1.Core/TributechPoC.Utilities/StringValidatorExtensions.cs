namespace TributechPoC.Utilities
{
    /// <summary>
    /// Extentions methods for String
    /// </summary>
    public static class StringValidatorExtensions
    {
        /// <summary>
        /// Check wethere the input string is between the specified lenghts
        /// </summary>
        /// <param name="input">input string</param>
        /// <param name="minLength">min lenght</param>
        /// <param name="maxLenght">max lenght</param>
        /// <returns></returns>
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
