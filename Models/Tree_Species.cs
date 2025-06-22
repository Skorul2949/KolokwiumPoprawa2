using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KolokwiumPoprawa2.Models;

[Table("Tree_Species")]
public class Tree_Species
{
    [Key]
    public int SpeciesID { get; set; }
    [MaxLength(100)]
    public string LatinName { get; set; }
 
    public int GrowthTimeInYears { get; set; }


    public ICollection<Seedling_Batch> Seedling_Batch { get; set; }
}