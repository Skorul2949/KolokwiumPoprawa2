namespace KolokwiumPoprawa2.Models;

public class Employee
{
     [Key]
     public int EmployeeId { get; set; }
     [MaxLenght(100)]
     public string FirstName {get; set;}
     [MaxLenght(100)]
     public string LastName {get; set;}
     [Column(TypeName = "Date")]
     public DateTime HireDate { get; set; }
 
     public ICollection<Responsible> Responsible { get; set; }
 
 }