namespace Evently.Modules.Events.Api.Events;

/// <summary>
/// Enum representing the status of an event.
/// </summary>
public enum EventStatus
{
    /// <summary>
    /// The event is in draft mode.
    /// </summary>
    Draft = 0,

    /// <summary>
    /// The event is published.
    /// </summary>
    Published = 1,

    /// <summary>
    /// The event is completed.
    /// </summary>
    Completed = 2,


    /// <summary>
    /// The event is canceled.
    /// </summary>
    Canceled = 3
}
