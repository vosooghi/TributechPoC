namespace TributechPoC.Domain.Shared
{
    public class Messages
    {
        public static string InvalidStringLength = "The length of {0} must be between {1}-{2}";
        public static string InvalidNullValue = "{0} should not be Null";
        public static string InvalidNumberValueRange = "The value of {0} should not be less than {1}";
        public static string SensorName = nameof(SensorName);
        public static string SensorLocation = nameof(SensorLocation);
        public static string Id = nameof(Id);
    }
}
