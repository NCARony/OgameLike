using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgameLikeBO
{
    public class Resource :IdbEntity
    {
        public long? Id { get; set; }
        private string name { get; set; }
        [Range(0, int.MaxValue)]
        private int? lastQuantity { get; set; }
        private DateTime lastUpdate { get; set; }

    }
}
