using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgameLikeBO
{
    public abstract class Building : IdbEntity
    {
        public long? Id { get => throw new NotImplementedException(); }

        [StringLength(20, MinimumLength = 5)]
        private string name { get; set; }
        [Range(0, int.MaxValue)]
        private int? level { get; set; }

        public abstract int? CellNb();
        public List<Resource> TotalCost()
        {
            return null;
        }
        public List<Resource> NextCost()
        {
            return null;
        }
    }
}
