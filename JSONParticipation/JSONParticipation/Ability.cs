using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONParticipation
{
    class Abilities
    {
        public List<Ability> abilities { get; set; }
    }

    class Ability
    {
        public string name { get; set; }
        public string url { get; set; }
        public bool ishidden { get; set; }
        public int slot { get; set; }
    }
}
