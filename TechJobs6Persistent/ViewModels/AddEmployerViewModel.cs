using System.ComponentModel.DataAnnotations;

namespace TechJobs6Persistent.ViewModels
{
    public class AddEmployerViewModel
    {

        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Name { get; set; }


        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Location { get; set;  }
    }
}
