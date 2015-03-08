using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentInformation.Models
{
    public class StudentInfo
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Character Not More Then 50")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Father Name")]
        public string FatherName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Character Not More Then 10")]
        public string Class { get; set; }

        [Required]
        public int Roll { get; set; }
    }
}