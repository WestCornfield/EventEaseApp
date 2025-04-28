using System.ComponentModel.DataAnnotations;
namespace EventEaseApp.Models;

public class Event
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Event name is required.")]
    [StringLength(100, ErrorMessage = "Event name cannot exceed 100 characters.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Event date is required.")]
    public DateTime Date { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "Event location is required.")]
    public string Location { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}