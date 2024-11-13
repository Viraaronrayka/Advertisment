using System;
using System.Collections.Generic;

namespace Advertisment.Db
{
    public partial class City
    {
        public City()
        {
            Ads = new HashSet<Ad>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Status { get; set; }

        public virtual ICollection<Ad> Ads { get; set; }
    }
}
