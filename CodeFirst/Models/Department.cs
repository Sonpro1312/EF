using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    [Table("Department")]
    public class Department
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDepartment { get; set; }
        [Required, MaxLength]
        public required string Name { get; set; }

        [InverseProperty("Department")]
        public virtual ICollection<Employee> Employee { get; set; } = new HashSet<Employee>();
    }
}
