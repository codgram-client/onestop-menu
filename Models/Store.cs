using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models;


public class Store
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string? Id { get; set; }
    public string EntityId { get; set; }
    public Entity? Entity { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public StoreType Type { get; set; }
}