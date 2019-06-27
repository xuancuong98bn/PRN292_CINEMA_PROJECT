using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace cinema.Models
{
    public class Role
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public String Code { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public String Name { get; set; }
    }
}