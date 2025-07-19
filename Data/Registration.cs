// Data/Registration.cs
namespace EventEase.Data;
using System.ComponentModel.DataAnnotations;

public class Registration
{
    [Required]
    [StringLength(50, ErrorMessage = "Name is too long.")]
    public string Name { get; set; } = "";

    [Required]
    [EmailAddress(ErrorMessage = "Invalid Email Address.")]
    public string Email { get; set; } = "";

    [Required(ErrorMessage = "You must select an event.")]
    public int? EventId { get; set; }
}