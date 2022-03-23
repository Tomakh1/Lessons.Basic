using System;
using System.Collections.Generic;
using System.Text;

namespace Market
{
    public interface ICategory
    {
        public string Sport { get; set; }
        public string Classic { get; set; }
        public string NoClassic { get; set; }
    }
}
