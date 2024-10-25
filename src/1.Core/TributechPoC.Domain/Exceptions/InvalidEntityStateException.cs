namespace TributechPoC.Domain.Exceptions
{
    /// <summary>
    /// A microtype to identify Entity Invalid State Exception.
    /// </summary>
    public class InvalidEntityStateException : DomainStateException
    {
        /// <summary>
        /// the exceptions related to invalid state of an Entity is thrown by this class.
        /// </summary>
        /// <param name="message">String message or Message Pattern</param>
        /// <param name="parameters">the parameters of message patterns</param>
        public InvalidEntityStateException(string message, params string[] parameters) : base(message)
        {
            Parameters = parameters;
        }
    }
}
