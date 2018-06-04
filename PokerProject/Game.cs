using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerProject
{
    public class Game
    {
        private static uint roundCounter = 1;
        private uint bank;
        private uint bigblind;

        public Game()
        { }

        public Game(uint bigblind)
        {
            this.bigblind = bigblind;
            this.bank = 0;
        }

        public uint Bank
        {
            get { return bank; }
        }
        
        public void FirstIncreaseBank(uint bet)
        {
            if (bet >= 2 * bigblind)
                this.bank += bet;
            else MessageBox.Show("Ставка не может быть меньше двух больших блайдов!", "Подсказка");
        }

        public void OtherIncreaseBank (uint currentBet, uint previousBet)
        {
            if (currentBet >= 2 * previousBet)
                this.bank += currentBet;
            else MessageBox.Show("Рейз должет быть как минимум в два раза больше предыдущей ставки!", "Подсказка");
        }
    }
}
