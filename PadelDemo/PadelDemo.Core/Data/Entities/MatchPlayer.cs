using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadelDemo.Core.Data.Entities {
    public partial class MatchPlayer {
        //public int Id { get; set; }
        public int UserId { get; set; }
        public int MatchId { get; set; }
        public bool IsWinner { get; set; }

        public Match Match { get; set; }
        public User User { get; set; }
    }
}
