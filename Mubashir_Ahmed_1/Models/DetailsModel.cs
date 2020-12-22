using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mubashir_Ahmed_1.Models
{
    public class DetailsModel
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        [DisplayName("Father Name")]
        [Required]
        public string FName { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage ="Age Must Be Greater Than 0")]
        public int Age { get; set; }

        public int Phone { get; set; }
    }
}
