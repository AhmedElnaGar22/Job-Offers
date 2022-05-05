using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Job_Offers_Website.Models
{
    public class Job
    {
        public int Id { get; set; }
        [Display(Name ="اسم الوظيفه")]
        public string JobTitle { get; set; }
        [Display(Name ="الوصف")]
        public string JobContent { get; set; }
        [Display(Name ="صوره الوظيفه")]
        public string JobImage { get; set; }

        [Display(Name ="نوع الوظيفه")]
        public int categoryId { get; set; }
        public virtual Category category { get; set; }
    }
}