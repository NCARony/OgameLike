using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgameLikeBO
{
    public class Resource :IdbEntity
    {
        public long? Id { get; set; }
        private string name { get; set; }
        private int? lastQuantity { get; set; }
        private DateTime lastUpdate { get; set; }

    }
}
