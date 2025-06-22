namespace KolokwiumPoprawa2.Models;

public class Responsible
{
    [ForeignKey(nameof(Seedling_Batch))]
    public int BatchID { get; set; }
    [ForeignKey(nameof(Employee))]
    public int EmployeeID { get; set; }
    [MaxLength(100)]
    public string Role { get; set; }
}