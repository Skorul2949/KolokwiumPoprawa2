using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KolokwiumPoprawa2.Models;

[Table("Seedling_Batch")]
public class Seedling_Batch
{
    [Key]
    public int BatchID { get; set; }
    
    [ForeignKey(nameof(Nursery))]
    public int NurseryID { get; set; }
    [ForeignKey(nameof(Tree_Species))]
    public int SpeciesID { get; set; }
    
    public int Quantity { get; set; }
    [Column(TypeName = "Date")]
    public DateTime SownDate { get; set; }
    [Column(TypeName = "Date")]
    public DateTime? ReadyDate { get; set; }
    
    public ICollection<Responsible> Responsible { get; set; }
}