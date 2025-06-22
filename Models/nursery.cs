using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KolokwiumPoprawa2.Models;

[Table("Nursery")]
public class Nursery
{
    [Key]
    public int NurseryID { get; set; }
    [MaxLength(100)]
    public string Name { get; set; }
    [Column(TypeName = "Date")]
    public DateTime EstablishedDate  { get; set; }

    public ICollection<Seedling_Batch> Seedling_Batch { get; set; }
}