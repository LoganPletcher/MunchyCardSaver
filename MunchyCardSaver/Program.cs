using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunchyCardSaver
{

    public enum CardType
    {
        init,
        none,
        MYSTERY,
        TREASURE,
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<CardType> CT = new List<CardType>();
            CT.Add(new CardType());
            List<MysteryCard> MC = new List<MysteryCard>();
            MC.Add(new MysteryCard());
            List<TreasureCard> TC = new List<TreasureCard>();
            TC.Add(new TreasureCard());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (CT[0] != CardType.none)
            {
                Application.Run(new Munch_Card_Saving_CC(CT));
                if (CT[0] == CardType.MYSTERY)
                {
                    MC[0] = new MysteryCard();
                    Application.Run(new Mystery_Info(MC));
                }
                if (CT[0] == CardType.TREASURE)
                {
                    TC[0] = new TreasureCard();
                    Application.Run(new Treasure_Info(TC));
                }
            }
        }
    }
}
