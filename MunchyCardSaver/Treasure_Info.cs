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
    public partial class Treasure_Info : Form
    {
        public List<TreasureCard> TC = new List<TreasureCard>();

        public Treasure_Info(List<TreasureCard> tc)
        {
            TC = tc;
            TC[0].CardType = TreasureType.DEFAULT;
            TC[0].Description = "This card has no description.";
            TC[0].Gold = 0;
            TC[0].Name = "";
            TC[0].Power = 0;
            InitializeComponent();
        }

        private void EquipmentType_CheckedChanged(object sender, EventArgs e)
        {
            DefaultType.Checked = false;
            TC[0].CardType = TreasureType.EQUIPMENT;
        }

        private void DefaultType_CheckedChanged(object sender, EventArgs e)
        {
            EquipmentType.Checked = false;
            TC[0].CardType = TreasureType.DEFAULT;
        }

        private void CardNameTB_TextChanged(object sender, EventArgs e)
        {
            TC[0].Name = CardNameTB.Text;
        }

        private void GoldTB_TextChanged(object sender, EventArgs e)
        {
            int PowerLevel;
            bool CanConvertPower = Int32.TryParse(PowerTB.Text, out PowerLevel);
            int GoldAmount;
            bool CanConvertGold = Int32.TryParse(GoldTB.Text, out GoldAmount);
            if (CanConvertGold)
            {
                TC[0].Gold = GoldAmount;
                ErrorTB.Text = "";
                if (!CanConvertPower)
                {
                    ErrorTB.Text = "Invalid Power input. Please input a number only.";
                }
            }
            else
                ErrorTB.Text = "Invalid inputs. Please input a number only.";
        }

        private void DescriptionTB_TextChanged(object sender, EventArgs e)
        {
            if (DescriptionTB.Text == "")
            {
                TC[0].Description = "This card has no description.";
            }
            else
                TC[0].Description = DescriptionTB.Text;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Save_and_Load<TreasureCard> sl = new Save_and_Load<TreasureCard>();
            sl.Save(TC[0]);
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PowerTB_TextChanged(object sender, EventArgs e)
        {
            int GoldAmount;
            bool CanConvertGold = Int32.TryParse(GoldTB.Text, out GoldAmount);
            int PowerLevel;
            bool CanConvertPower = Int32.TryParse(PowerTB.Text, out PowerLevel);
            if (CanConvertPower)
            {
                TC[0].Power = PowerLevel;
                ErrorTB.Text = "";
                if (!CanConvertGold)
                {
                    ErrorTB.Text = "Invalid Gold input. Please input a number only.";
                }
            }
            else
                ErrorTB.Text = "Invalid inputs. Please input a number only.";
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            Save_and_Load<TreasureCard> sl = new Save_and_Load<TreasureCard>();
            TC[0] = sl.Load();
            if (TC[0].CardType == TreasureType.DEFAULT)
            {
                DefaultType.Checked = true;
                EquipmentType.Checked = false;
            }
            else
            {
                DefaultType.Checked = false;
                EquipmentType.Checked = true;
            }
            PowerTB.Text = TC[0].Power.ToString();
            GoldTB.Text = TC[0].Gold.ToString();
            CardNameTB.Text = TC[0].Name;
            DescriptionTB.Text = TC[0].Description;
        }
    }
}
