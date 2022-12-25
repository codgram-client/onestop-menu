using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models;


public class Entity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string? Id { get; set; }

    public string CompanyId { get; set; }
    public Company? Company { get; set; }

    [Required]
    [MaxLength(20)]
    public string Code { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    [MaxLength(100)]
    public string? Description { get; set; }
}