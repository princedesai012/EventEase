// Data/Event.cs
namespace EventEase.Data; 
public class Event
{
    public int Id { get; set; }
    public string Title { get; set; } = "New Event";
    public string Description { get; set; } = "Description coming soon.";
    public DateTime Date { get; set; } = DateTime.Now;
    public string Location { get; set; } = "TBD";
}