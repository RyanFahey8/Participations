using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONParticipation
{
    class Results
    {
        public List<Result> results { get; set; }
    }

    class Result
    {
        public string name { get; set; }
        public string url { get; set; }
    }
}
