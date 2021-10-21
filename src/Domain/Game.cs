using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Game
    {
        #region Fields
        private List<int> _highscores = new List<int>();
        private Dice _dice1;
        private Dice _dice2;
        #endregion
        #region Properties
        public int Eye1 { get { return _dice1.Dots; } }
        public int Eye2 { get { return _dice2.Dots; } }
        public bool HasSnakeEyes { get { return (Eye1 == 1 && Eye2 == 1); } }
        public IReadOnlyList<int> HighScores { get { return _highscores; } }
        public int Total { get; set; }

        #endregion
        #region Constructor
        public Game()
        {
            initialize();
        }
        #endregion
        #region Methods

        private void initialize()
        {
            _dice1 = new Dice();
            _dice2 = new Dice();
        }
        public void Play()
        {
            _dice1.Roll();
            _dice2.Roll();
            if (HasSnakeEyes)
            {
                _highscores.Add(Total);
                Total = 0;
            } else
            {
                Total += Eye1 + Eye2;
            }
        }
        public void Restart()
        {
            initialize();

        }
        #endregion
    }
}
