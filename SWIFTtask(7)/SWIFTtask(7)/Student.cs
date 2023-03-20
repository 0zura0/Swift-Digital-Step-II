using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SWIFTtask_7_
{

    // სტუდენტ ცხრილის შესაქმნელი კლასი
    public class Student
    {
        public Student()
        {
            this.teacher = new HashSet<teacher>();
        }
        [Key]
        public int pupil_id { get; set; }

        [Required]
        [StringLength(50)]
        public string first_name { get; set; }

        [Required]
        [StringLength(50)]
        public string last_name { get; set; }

        [Required]
        [StringLength(10)]
        public string gender { get; set; }

        [Column("class")]
        [Required]
        public int _class { get; set; }

        public virtual ICollection<teacher> teacher { get; set; }
    }
}
