using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Linq;

namespace UP.Models
{
    public class Job

    {
        [Key]
        public int JobID { get; set; }

        [Display(Name = "Job Name")]
        public string Jobname { get; set; }
        [DataType(DataType.MultilineText)]
        public string JobDes { get; set; }

        public string Jobstatus { get; set; }
        public string JobCategory { get; set; }

        public decimal  JobSalary {get; set;}

        [Required]
        public DateTime? RecordCreatedOn { get; set; }

        public Category jobcat { get; set; }
        public Location joblocate { get; set; }
    }
}
