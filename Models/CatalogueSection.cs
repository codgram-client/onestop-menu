using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models;



public class CatalogueSection
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string? Id { get; set; }
    
    public string CatalogueId { get; set; }
    public Catalogue? Catalogue { get; set; }
    public int LineNumber { get; set; }
    public string Name { get; set; }
    public string NormalizedName { get; set; }
    public string Description { get; set; }
}