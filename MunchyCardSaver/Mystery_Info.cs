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
            MC[0].CardType = MysteryType.CURSE;
            MC[0].Description = "This card has no description.";
            MC[0].Name = "";
            MC[0].Power = 0;
            MC[0].Reward = 0;
            InitializeComponent();
        }

        private void CurseType_CheckedChanged(object sender, EventArgs e)
        {
            MC[0].CardType = MysteryType.CURSE;
            MonsterType.Checked = false;
            PowerTB.Text = "";
            MC[0].Power = 0;
            RewardTB.Text = "";
            MC[0].Reward = 0;
            PowerTB.Visible = false;
            PowerTextDisplay.Visible = false;
            RewardTB.Visible = false;
            RewardTextDisplay.Visible = false;
        }

        private void MonsterType_CheckedChanged(object sender, EventArgs e)
        {
            MC[0].CardType = MysteryType.MONSTER;
            CurseType.Checked = false;
            PowerTB.Visible = true;
            PowerTextDisplay.Visible = true;
            RewardTB.Visible = true;
            RewardTextDisplay.Visible = true;
        }

        private void CardNameTB_TextChanged(object sender, EventArgs e)
        {
            MC[0].Name = CardNameTB.Text;
        }

        private void PowerTB_TextChanged(object sender, EventArgs e)
        {
            int RewardAmount;
            bool CanConvertReward = Int32.TryParse(RewardTB.Text, out RewardAmount);
            int PowerLevel;
            bool CanConvertPower = Int32.TryParse(PowerTB.Text, out PowerLevel);
            if (CanConvertPower)
            {
                MC[0].Power = PowerLevel;
                ErrorTB.Text = "";
                if (!CanConvertReward)
                {
                    ErrorTB.Text = "Invalid Reward input. Please input a number only.";
                }
            }
            else
                ErrorTB.Text = "Invalid inputs. Please input a number only.";
        }

        private void DescriptionTB_TextChanged(object sender, EventArgs e)
        {
            if(DescriptionTB.Text == "")
            {
                MC[0].Description = "This card has no description.";
            }
            else
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

        private void RewardTB_TextChanged(object sender, EventArgs e)
        {
            int PowerLevel;
            bool CanConvertPower = Int32.TryParse(PowerTB.Text, out PowerLevel);
            int RewardAmount;
            bool CanConvertReward = Int32.TryParse(RewardTB.Text, out RewardAmount);
            if (CanConvertReward)
            {
                MC[0].Reward = RewardAmount;
                ErrorTB.Text = "";
                if (!CanConvertPower)
                {
                    ErrorTB.Text = "Invalid Power input. Please input a number only.";
                }
            }
            else
                ErrorTB.Text = "Invalid inputs. Please input a number only.";
        }
    }
}
