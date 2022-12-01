using System.ComponentModel.DataAnnotations;

namespace UP.Models
{
    public class Category
    {
        [Key]
        public int CatId { get; set; }

        public string CatName { get; set; }
        public IList<Job> Jobs { get; set; }
        public IList<Training> Trainings { get; set; }
    }
}
