using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace cinema.Areas.Admin.Models
{
    public class Film2
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        [Index(IsUnique = true)]
        public String Code { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public String Title { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public String Author { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public String Actor { get; set; }

        [Display(Name = "Publication Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PublicationDate { get; set; }
        public String ContentFilm { get; set; }

        public String Image { get; set; }       //this to save image name

        [Required]
        public HttpPostedFileBase ImageFile { get; set; }
        public bool IsEnable { get; set; }
    }
}