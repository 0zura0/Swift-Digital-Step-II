using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace SWIFTtask_7_
{

    //მასწავლებლების ცხრილის შესაქმნელი კლასი
    [Table("teacher")]
    public class teacher
    {
        public teacher()
        {
            this.pupils = new HashSet<Student>();
        }

        [Key]
        public int teacher_id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(50)]
        public string surname { get; set; }

        [Required]
        [StringLength(10)]
        public string gender { get; set; }

        [Required]
        [StringLength(50)]
        public string subject { get; set; }

        public virtual ICollection<Student> pupils { get; set; }
    }
}
