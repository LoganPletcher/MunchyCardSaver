using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunchyCardSaver
{

    public enum CardType
    {
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Munch_Card_Saving_CC(CT));

            Console.ReadLine();
            
        }
    }
}
