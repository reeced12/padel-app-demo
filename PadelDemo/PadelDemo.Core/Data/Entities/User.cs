using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadelDemo.Core.Data.Entities {
    public partial class User {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public virtual ICollection<MatchPlayer> Matches { get; set; }

        public User()
        {
                Matches = new HashSet<MatchPlayer>();
        }
    }
}
