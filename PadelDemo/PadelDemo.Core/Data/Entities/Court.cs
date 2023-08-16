using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadelDemo.Core.Data.Entities {
    public partial class Court {
        public int Id { get; set; }
        public int ClubId { get; set; }
        public string Name { get; set; }
        public bool IsCovered { get; set; }
        public bool IsSingles { get; set; }

        public virtual ICollection<Match> Matches { get; set; }

        public Club Club { get; set; }

        public Court()
        {
            Matches = new HashSet<Match>();
        }

    }
}
