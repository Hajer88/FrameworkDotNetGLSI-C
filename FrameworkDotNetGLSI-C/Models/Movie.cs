using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FrameworkDotNetGLSI_C.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Title of the Movie")]
        public string Title { get; set; }
        public int genreId { get; set; }
        public Genre genre { get; set; }
    }
}