using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    [Table("Company")]
    public class Company
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCompany { get; set; }
        [Required, MaxLength(50)]
        public required string Name { get; set; }
        [InverseProperty("Company")]
        public virtual ICollection<Employee> Employee { get; set; }
    }
}
