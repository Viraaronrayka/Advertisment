using System;
using System.Collections.Generic;

namespace Advertisment.Db
{
    public partial class Category
    {
        public Category()
        {
            Ads = new HashSet<Ad>();
            InverseParent = new HashSet<Category>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int? ParentId { get; set; }
        public string? Status { get; set; }
        public string? Description { get; set; }
        public byte[]? Image { get; set; }

        public virtual Category? Parent { get; set; }
        public virtual ICollection<Ad> Ads { get; set; }
        public virtual ICollection<Category> InverseParent { get; set; }
    }
}
