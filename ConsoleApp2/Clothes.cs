using System;
using System.Collections.Generic;
using System.Text;

namespace Market
{
    public class Clothes : BaseShop, ICategory, IGender, ISeasons
    {

        public Clothes(decimal price, int size):base(price,size)
        {

        }
        public string Sport { get; set; }
        public string Classic { get ; set ; }
        public string NoClassic { get ; set ; }
        public bool IsFemale { get ; set ; }
        public bool IsBaby { get; set; }
        public bool IsMale { get ; set ; }
        public string Seasons { get ; set ; }
    }
}
