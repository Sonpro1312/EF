using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    public class Employee
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public required string Name { get; set; }
        [Required, MaxLength(50)]
        public bool Gender { get; set; }
        [Required, Range(18, int.MaxValue)]
        public int Age { get; set; }
        [Required]
        public int IdDepartment { get; set; }
        [Required]
        public int IdCompany { get; set; }
        
        [ForeignKey("IdDepartment")]
        public virtual Department Department { get; init; }
        [ForeignKey("IdCompany")]
        public virtual Company Company { get; init; }
    }
}
