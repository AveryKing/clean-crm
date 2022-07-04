using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PlatformService.Models;

public class Platform
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Publisher { get; set; }
    [Required]
    public string Cost { get; set; }
}