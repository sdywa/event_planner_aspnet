using System.ComponentModel.DataAnnotations;

namespace EventPlanner.Models;

public class User
{
    public int UserId { get; set; }
    [StringLength(30)]
    public string? FirstName { get; set; }
    [StringLength(45)]
    public string? LastName { get; set; }
    [StringLength(50)]
    public string? Email { get; set; }
    [StringLength(70)]
    public string? Password { get; set; }
    public int RegTime { get; set; }
    [StringLength(70)]
    public string? AvatarUrl { get; set; }

    public int RoleId { get; set; }
    public Role? Role { get; set; }
}