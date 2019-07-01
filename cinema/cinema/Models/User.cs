using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace cinema.Models
{
    public class User
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public String Username { get; set; }

        [StringLength(60, MinimumLength = 6)]
        public String Password { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public String Fullname { get; set; }


        public bool Gender { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }

        [RegularExpression(@"^[0-9]{9,11}$")]
        public String Phone { get; set; }
        public int RoleID { get; set; }
        public bool IsEnable { get; set; }
    }
}