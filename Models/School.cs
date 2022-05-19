using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace dss.Models
{
    public class School
    {
        public School()
        {

        }
        [Key]
        public int SchoolId { get; set; }
        [DisplayName("School Name")]
        public string SchoolName { get; set; }

        public ICollection<Student>? Students { get; set; }
    }
}