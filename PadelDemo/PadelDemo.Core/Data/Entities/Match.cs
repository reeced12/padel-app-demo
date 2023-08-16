using PadelDemo.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadelDemo.Core.Data.Entities {
    public partial class Match {
        public int Id { get; set; }
        public int ClubId { get; set; }
        public int CourtId { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<MatchPlayer> MatchPlayers { get; set; }
        public Court Court { get; set; }

        public Match()
        {
            MatchPlayers = new HashSet<MatchPlayer>();
        }
    }
}
