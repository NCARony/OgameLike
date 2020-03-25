
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgameLikeBO
{
    public class Planet : IdbEntity
    {
        public long? Id { get; set; }
        private string name { get; set; }
        private int? caseNb { get; set; }

        public List<Resource> resources { get; set; }
        public List<Building> buildings { get; set; }
    }
}
