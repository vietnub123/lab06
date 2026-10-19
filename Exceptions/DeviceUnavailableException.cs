using Lab06.Models;

namespace Lab06.Exceptions;

public class DeviceUnavailableException : BorrowingException
{
    public string DeviceId { get; }
    public DeviceStatus CurrentStatus { get; }

    public DeviceUnavailableException(
        string deviceId,
        DeviceStatus currentStatus)
        : base($"Device {deviceId} is {currentStatus}.")
    {
        DeviceId = deviceId;
        CurrentStatus = currentStatus;
    }
}