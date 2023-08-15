using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadelDemo.Core.Models {
    public class ClubModel {
        public int Id { get; set; }
        public string Name { get; set; }
        // TODO: link to address
        public List<Court> Courts { get; set; }
        public ClubModel()
        {
            Courts = new List<Court>();
        }
    }

    public class Court {
        public int Id { get; set; }
        public int ClubId { get; set; }
        public string Name { get; set; }
        public bool IsCovered { get; set; } = false;
        public bool IsSingles { get; set; } = false;

    }
}
