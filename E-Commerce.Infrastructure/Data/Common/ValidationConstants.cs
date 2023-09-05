using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure.Data.Common
{
    public class ValidationConstants
    {
        public class UserConstraints
        {
            public const int PasswordMinLength = 4;
            public const int PasswordMaxLength = 50;

            public const int LastNameMinLength = 2;
            public const int LastNameMaxLength = 40;

            public const int FirstNameMinLength = 2;
            public const int FirstNameMaxLength = 40;

            public const int UserNameMinLength = 4;
            public const int UserNameMaxLength = 15;
        }

        public class CategoryConstrains
        {
            public const int NameMaxLength = 50;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 2000;
        }

        public class ProductConstrains
        {
            public const int NameMaxLength = 50;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 2000;
        }
        public class ReviewConstrains
        {

            public const int CommentMinLength = 2;
            public const int CommentMaxLength = 500;
        }
    }
}
