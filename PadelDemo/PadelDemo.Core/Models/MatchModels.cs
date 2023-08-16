using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadelDemo.Core.Models {
    public class MatchModel {
        public int Id { get; set; }
        public int ClubId { get; set; }
        public int CourtId { get; set; }
        public DateTime Date { get; set; }
        public List<MatchPlayerModel> MatchPlayers { get; set; }

        public MatchModel()
        {
            MatchPlayers = new List<MatchPlayerModel>();
        }
    }

    public class MatchPlayerModel {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MatchId { get; set; }
        public bool IsWinner { get; set; } = false;
    }
}
