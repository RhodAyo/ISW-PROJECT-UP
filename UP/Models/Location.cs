using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace UP.Models
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }

        [Display(Name = "Location Name")]
        public string Locationname { get; set; }
  
        public int LocationPostalcode { get; set; }
        public string LocationState { get; set; }

        [Required]
        public DateTime? RecordCreatedOn { get; set; }
        public IList<Job> Jobs { get; set; }
    }
}
