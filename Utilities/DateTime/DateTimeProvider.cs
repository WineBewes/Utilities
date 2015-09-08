using Utilities.Contracts.DateTime;

namespace Utilities.DateTime
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public System.DateTime Now
        {
            get { return System.DateTime.Now; }
        }
    }
}