using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace aspnetmvc_mvaintro.Models
{
    public class Review
    {
        public int ReviewId { get; set; }

        public Album Album { get; set; }

        public string Contents { get; set; }

        [Display(Name="Email")]
        [DataType(DataType.EmailAddress)]
        public string ReviewerEmail { get; set; }
    }
}
