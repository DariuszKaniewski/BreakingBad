using System;
using System.Collections.Generic;
using System.Text;

namespace BreakingBad.Models
{
    public class Quotes
    {
        public int quote_id { get; set; }
        public string quote { get; set; }
        public string author { get; set; }
        public string series { get; set; }
    }
}
