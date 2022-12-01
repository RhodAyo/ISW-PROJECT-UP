using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Linq;

namespace UP.Models
{
    public class Training
    {
        [Key]
        public int TrainID { get; set; }

        [Display(Name = "Training Name")]
        public string TrainName { get; set; }
        [DataType(DataType.MultilineText)]
        public string TrainDes { get; set; }

        public string TrainStatus { get; set; }
        public string TrainCategory { get; set; }

        public string TrainLevel { get; set; }

        public decimal TrainPrice { get; set; }

        [Required]
        public DateTime? RecordCreatedOn { get; set; }

        public Category category { get; set; }
        public TrainingLevel level { get; set; }
    }
}
