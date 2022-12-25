using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models;



public class CatalogueItem
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string? Id { get; set; }
    
    public string CatalogueSectionId { get; set; }
    public CatalogueSection? CatalogueSection { get; set; }
    public string ItemId { get; set; }
    public Item? Item { get; set; }
    public int LineNumber { get; set; }
}