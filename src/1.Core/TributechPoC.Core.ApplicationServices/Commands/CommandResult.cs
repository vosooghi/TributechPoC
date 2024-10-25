using TributechPoC.Core.ApplicationServices.Common;

namespace TributechPoC.Core.ApplicationServices.Commands
{
    /// <summary>
    /// the result of each command is returend by this class.
    /// </summary>
    public class CommandResult : ApplicationServiceResult
    {

    }
    /// <summary>
    /// the result of each command is returend by this class.
    /// </summary>
    /// <typeparam name="TData">Return Type</typeparam>
    public class CommandResult<TData> : CommandResult
    {
        public TData? _data;
        public TData? Data => _data;
    }
}