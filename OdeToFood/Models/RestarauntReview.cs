using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Models
{
    public class RestarauntReview
    {
        public int Id { get; set; }
        [Range(1, 10)]
        public int Rating { get; set; }
        [Required]
        [StringLength(1024)]
        [Display(Name = "Comment: ")]
        public string Body { get; set; }
        [Display(Name = "Username")]
        [DisplayFormat(NullDisplayText = "Anonymous")]
        public string ReviewerName { get; set; }
        public int RestaurantId { get; set; }
    }
}
