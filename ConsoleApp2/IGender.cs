using System;
using System.Collections.Generic;
using System.Text;

namespace Market
{
    public interface IGender
    {
        public bool IsFemale { get; set; }
        public bool IsBaby { get; set; }
        public bool IsMale { get; set; }
    }
}
