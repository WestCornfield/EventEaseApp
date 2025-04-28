using EventEaseApp.Models;

namespace EventEaseApp.Services;

public class EventService
{
    private readonly List<Event> _events = new List<Event>
    {
        new Event { Id = 1, Name = "Tech Conference 2025", Date = new DateTime(2025, 5, 15), Location = "San Francisco, CA", Description = "A conference for tech enthusiasts." },
        new Event { Id = 2, Name = "Music Festival", Date = new DateTime(2025, 6, 20), Location = "Austin, TX", Description = "A festival featuring live music performances." },
        new Event { Id = 3, Name = "Art Expo", Date = new DateTime(2025, 7, 10), Location = "New York, NY", Description = "An exhibition showcasing modern art." }
    };

    public Task<List<Event>> GetEventsAsync()
    {
        return Task.FromResult(_events);
    }

    public Task<Event?> GetEventByIdAsync(int id)
    {
        var eventItem = _events.FirstOrDefault(e => e.Id == id);
        return Task.FromResult(eventItem);
    }

    public Task AddEventAsync(Event newEvent)
    {
        newEvent.Id = _events.Count > 0 ? _events.Max(e => e.Id) + 1 : 1;
        _events.Add(newEvent);
        return Task.CompletedTask;
    }

    public Task UpdateEventAsync(Event updatedEvent)
    {
        var existingEvent = _events.FirstOrDefault(e => e.Id == updatedEvent.Id);
        if (existingEvent != null)
        {
            existingEvent.Name = updatedEvent.Name;
            existingEvent.Date = updatedEvent.Date;
            existingEvent.Location = updatedEvent.Location;
            existingEvent.Description = updatedEvent.Description;
        }
        return Task.CompletedTask;
    }
}