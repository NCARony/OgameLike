using OgameLikeBO.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgameLikeBO
{
    public abstract class Building : IdbEntity
    {
        #region Private class variable
        public long? id;
        private String name;
        private int? level;
        #endregion
        #region Properties
        [StringLength(20, MinimumLength = 5)]
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        [IntOverValidator(Min = 0, Max = int.MaxValue)]
        public virtual int? Level
        {
            get { return level; }
            set { level = value; }
        }

        [NotMapped]
        [IntOverValidator(Min = 0, Max = int.MaxValue)]
        public virtual int? CellNb
        {
            get { return level; }
        }
        [NotMapped]
        public virtual List<Resource> TotalCost { get => new List<Resource>(); }
        [NotMapped]
        public virtual List<Resource> NextCost { get => new List<Resource>(); }
        #endregion
        #region Implemented properties
        public virtual long? Id { get => this.id; set => this.id = value; }
        #endregion
    }
}
