
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgameLikeBO
{
    public class Planet : IdbEntity
    {
        public long? Id { get; set; }
        [StringLength(20, MinimumLength = 5)]
        private string name { get; set; }
        [Range(0, int.MaxValue)]
        private int? caseNb { get; set; }

        public List<Resource> resources { get; set; }
        public List<Building> buildings { get; set; }
    }
}
