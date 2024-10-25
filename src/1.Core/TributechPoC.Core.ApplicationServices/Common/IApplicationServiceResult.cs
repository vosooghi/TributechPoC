namespace TributechPoC.Core.ApplicationServices.Common
{
    public interface IApplicationServiceResult
    {
        IEnumerable<string> Messages { get; }
        ApplicationServiceStatus Status { get; }
    }
}
