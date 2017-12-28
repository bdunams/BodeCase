using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BodeCase.Models
{
    public class Blog : DbContext
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string BlogTitle { get; set; }

        [Required]
        public string BlogContent { get; set; }

        [Required]
        public DateTime DateWritten { get; set; }

    }
}