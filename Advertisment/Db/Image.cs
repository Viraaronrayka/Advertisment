using System;
using System.Collections.Generic;

namespace Advertisment.Db
{
    public partial class Image
    {
        public int Id { get; set; }
        public byte[] Picture { get; set; } = null!;
        public int AdId { get; set; }

        public virtual Ad Ad { get; set; } = null!;
    }
}
