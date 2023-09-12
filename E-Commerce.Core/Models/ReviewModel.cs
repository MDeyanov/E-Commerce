using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static E_Commerce.Infrastructure.Data.Common.ValidationConstants.ReviewConstrains;

namespace E_Commerce.Core.Models
{
    public class ReviewModel
    {
        public int ReviewID { get; set; }

        [Required(ErrorMessage = "UserID is required.")]
        public string UserID { get; set; } = null!;

        [Required(ErrorMessage = "ProductID is required.")]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Rating is required.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Comment is required.")]
        [StringLength(CommentMaxLength, ErrorMessage = "Comment length exceeds the maximum limit.")]
        public string Comment { get; set; } = null!;

        public DateTime ReviewDate { get; set; }
    }
}
