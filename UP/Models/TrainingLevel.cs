using System.ComponentModel.DataAnnotations;

namespace UP.Models
{
    public class TrainingLevel
    {
        [Key]
        public int TrainingId { get; set; }

        public string TrainingLevels { get; set; }
        public IList<Training> Trainings { get; set; }
    }
}
