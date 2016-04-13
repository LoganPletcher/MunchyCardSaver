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
    public partial class Mystery_Info : Form
    {
        public List<MysteryCard> MC;
        public Mystery_Info(List<MysteryCard> mc)
        {
            MC = mc;
            InitializeComponent();
        }

        private void ClassType_CheckedChanged(object sender, EventArgs e)
        {
            MC[0].mType = MysteryType.CLASS;
            EventType.Checked = false;
            MonsterType.Checked = false;
        }

        private void EventType_CheckedChanged(object sender, EventArgs e)
        {
            MC[0].mType = MysteryType.EVENT;
            ClassType.Checked = false;
            MonsterType.Checked = false;
        }

        private void MonsterType_CheckedChanged(object sender, EventArgs e)
        {
            MC[0].mType = MysteryType.MONSTER;
            ClassType.Checked = false;
            EventType.Checked = false;
        }

        private void FalseState_CheckedChanged(object sender, EventArgs e)
        {
            TrueState.Checked = false;
            MC[0].State = false;
        }

        private void TrueState_CheckedChanged(object sender, EventArgs e)
        {
            FalseState.Checked = false;
            MC[0].State = true;
        }

        private void CardNameTB_TextChanged(object sender, EventArgs e)
        {
            MC[0].Name = CardNameTB.Text;
        }

        private void PowerTB_TextChanged(object sender, EventArgs e)
        {
            int PowerLevel;
            bool CanConvert = Int32.TryParse(PowerTB.Text, out PowerLevel);
            if (CanConvert)
            {
                MC[0].Power = PowerLevel;
                ErrorTB.Text = "";
            }
            else
                ErrorTB.Text = "Invalid input. Please input a number only.";
        }

        private void DescriptionTB_TextChanged(object sender, EventArgs e)
        {
            MC[0].Description = DescriptionTB.Text;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save_and_Load<MysteryCard> sl = new Save_and_Load<MysteryCard>();
            sl.Save(MC[0]);
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
