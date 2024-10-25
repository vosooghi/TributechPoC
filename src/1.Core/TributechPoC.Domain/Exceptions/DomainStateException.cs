namespace TributechPoC.Domain.Exceptions
{
    /// <summary>
    /// The exceptions for ValueObjects and Entities.
    /// </summary>
    public class DomainStateException : Exception
    {
        /// <summary>
        /// the paramters to sent as exception message.
        /// </summary>
        public string[] Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message">string message or message pattern</param>
        /// <param name="parameters">message pattern parameters</param>
        public DomainStateException(string message, params string[] parameters) : base(message)
        {
            Parameters = parameters;

        }
        /// <summary>
        /// if there is some parameters, it returns message as a patterns, else returns Message.
        /// </summary>
        /// <returns>String Message or Message Pattern</returns>
        public override string ToString()
        {
            if (Parameters?.Length < 1)
            {
                return Message;
            }


            string result = Message;

            for (int i = 0; i < Parameters.Length; i++)
            {
                string placeHolder = $"{{{i}}}";
                result = result.Replace(placeHolder, Parameters[i]);
            }

            return result;
        }
    }
}
