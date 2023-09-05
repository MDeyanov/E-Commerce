using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static E_Commerce.Infrastructure.Data.Common.ValidationConstants.ReviewConstrains;

namespace E_Commerce.Infrastructure.Data.Entity
{
    public class Review
    {
        [Required]
        public int ReviewID { get; set; }

        [Required]
        public string UserID { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(UserID))]
        public AppUser User { get; set; } = null!;

        [Required]
        public int ProductID { get; set; }
        [Required]
        public Product Product { get; set; } = null!;

        [Required]     
        public int Rating { get; set; }

        [Required]
        [StringLength(CommentMaxLength)]
        public string Comment { get; set; } = null!;
        public DateTime ReviewDate { get; set; }
    }
}
