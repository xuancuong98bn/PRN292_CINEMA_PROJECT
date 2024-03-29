﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace cinema.Models
{
    public class Film
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public String Code { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public String Title { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public String Author { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public String Actor { get; set; }

        [Display(Name = "Publication Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PublicationDate { get; set; }
        public String ContentFilm { get; set; }

        [DisplayName("Upload File")]
        public String Image { get; set; }       //this to save image name

    //    public HttpPostedFileBase ImageFile { get; set; }
        public bool IsEnable { get; set; }
    }
}