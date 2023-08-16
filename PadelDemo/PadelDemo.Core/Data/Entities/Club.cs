using PadelDemo.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadelDemo.Core.Data.Entities {
    public partial class Club {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Court> Courts { get; set; }
        public Club()
        {
            Courts = new HashSet<Court>();
        }
    }
}
