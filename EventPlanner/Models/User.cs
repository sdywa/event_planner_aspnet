using System.ComponentModel.DataAnnotations;

namespace EventPlanner.Models;

public class User : CommonModel
{
    [StringLength(30)]
    public string FirstName { get; set; } = null!;
    [StringLength(45)]
    public string LastName { get; set; } = null!;
    [StringLength(50)]
    public string Email { get; set; } = null!;
    [StringLength(70)]
    public string Password { get; set; } = null!;
    public long RegTime { get; set; }

    public int RoleId { get; set; }
    public Role Role { get; set; } = null!;

    public ICollection<FavEvent> FavEvents { get; set; } = null!;
    public ICollection<Participant> PreviousEvents { get; set; } = null!;
    public ICollection<Event> CreatedEvents { get; set; } = null!;
}