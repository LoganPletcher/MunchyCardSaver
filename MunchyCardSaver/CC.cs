using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunchyCardSaver
{
    public partial class Munch_Card_Saving_CC : Form
    {
        public List<CardType> CT;
        public Munch_Card_Saving_CC(List<CardType> cardtype)
        {
            CT = cardtype;
            InitializeComponent();
            cardtype = CT;
        }

        private void MysteryButton_Click(object sender, EventArgs e)
        {
            CT[0] = CardType.MYSTERY;
            this.Close();
        }

        private void TreasureButton_Click(object sender, EventArgs e)
        {
            CT[0] = CardType.TREASURE;
            this.Close();
        }
    }
}
