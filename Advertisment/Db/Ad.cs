using System;
using System.Collections.Generic;

namespace Advertisment.Db
{
    public partial class Ad
    {
        public Ad()
        {
            Images = new HashSet<Image>();
        }

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int CityId { get; set; }
        public string? Latitude { get; set; }
        public string? Langtitude { get; set; }
        public string? NationalCode { get; set; }
        public string? PostalCode { get; set; }
        public short? Area { get; set; }
        public decimal? Price { get; set; }
        public byte? ChamberNo { get; set; }
        public short? BuildYear { get; set; }
        public byte? FloorCount { get; set; }
        public bool? HasElevator { get; set; }
        public bool? HasParking { get; set; }
        public bool? HasBarn { get; set; }
        public bool IsChatActivated { get; set; }
        public bool PhoneCallActivated { get; set; }
        public string Title { get; set; } = null!;
        public string Body { get; set; } = null!;

        public virtual Category Category { get; set; } = null!;
        public virtual City City { get; set; } = null!;
        public virtual ICollection<Image> Images { get; set; }
    }
}
