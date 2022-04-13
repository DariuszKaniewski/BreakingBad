using System;
using System.Collections.Generic;
using System.Text;

namespace BreakingBad.Models
{
    public class Deaths
    {
        public int death_id { get; set; }
        public string death { get; set; }
        public string cause { get; set; }
        public string responsible { get; set; }
        public string last_words { get; set; }
        public int season { get; set; }
        public int episode { get; set; }
        public int number_of_deaths { get; set; }
    }
}
