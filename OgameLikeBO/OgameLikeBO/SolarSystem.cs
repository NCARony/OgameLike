using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgameLikeBO
{
    public class SolarSystem : IdbEntity
    {
        public long? Id { get; set; }
        [StringLength(20, MinimumLength = 5)]
        private string name { get; set; }
        public List<Planet> planets { get; set; }
    }
}
