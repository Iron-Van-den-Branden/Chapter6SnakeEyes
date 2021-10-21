using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Dice
    {
        #region Fields
        private Random _randomizer;
        #endregion
        #region Properties
        public int Dots { get; set; }
        #endregion
        #region Constructor
        public Dice()
        {
            _randomizer = new Random();
            Dots = 6;
        }
        #endregion
        #region Methods
        public void Roll()
        {
            Dots = _randomizer.Next(6) + 1;
        }
        #endregion
    }
}
