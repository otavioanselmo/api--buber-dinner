namespace BuberDinner.Application.Common.Interfaces.DateTimeProvider
{
    public interface IDateTimeProvider
    {
        DateTime UtcNow { get; }
    }
}