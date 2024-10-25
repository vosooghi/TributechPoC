namespace TributechPoC.Core.ApplicationServices.Commands
{
    /// <summary>
    /// a marker to classes that have commands' inputs.
    /// </summary>
    public interface ICommand { }
    /// <summary>
    /// a marker for classes that have commands' inputs.
    /// </summary>
    /// <typeparam name="TData">indicates return type</typeparam>
    public interface ICommand<TData> { }

}
