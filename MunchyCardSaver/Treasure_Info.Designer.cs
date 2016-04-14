namespace MunchyCardSaver
{
    partial class Treasure_Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DefaultType = new System.Windows.Forms.CheckBox();
            this.EquipmentType = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CardNameTB = new System.Windows.Forms.TextBox();
            this.ErrorTB = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.GoldTB = new System.Windows.Forms.TextBox();
            this.Gold = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.PowerTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(2, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(126, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Treasure Card Type";
            // 
            // DefaultType
            // 
            this.DefaultType.AutoSize = true;
            this.DefaultType.Location = new System.Drawing.Point(12, 63);
            this.DefaultType.Name = "DefaultType";
            this.DefaultType.Size = new System.Drawing.Size(75, 17);
            this.DefaultType.TabIndex = 4;
            this.DefaultType.Text = "DEFAULT";
            this.DefaultType.UseVisualStyleBackColor = true;
            this.DefaultType.CheckedChanged += new System.EventHandler(this.DefaultType_CheckedChanged);
            // 
            // EquipmentType
            // 
            this.EquipmentType.AutoSize = true;
            this.EquipmentType.Location = new System.Drawing.Point(12, 40);
            this.EquipmentType.Name = "EquipmentType";
            this.EquipmentType.Size = new System.Drawing.Size(90, 17);
            this.EquipmentType.TabIndex = 3;
            this.EquipmentType.Text = "EQUIPMENT";
            this.EquipmentType.UseVisualStyleBackColor = true;
            this.EquipmentType.CheckedChanged += new System.EventHandler(this.EquipmentType_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(128, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 14);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Card Name";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CardNameTB
            // 
            this.CardNameTB.Location = new System.Drawing.Point(118, 38);
            this.CardNameTB.Multiline = true;
            this.CardNameTB.Name = "CardNameTB";
            this.CardNameTB.Size = new System.Drawing.Size(122, 65);
            this.CardNameTB.TabIndex = 7;
            this.CardNameTB.TextChanged += new System.EventHandler(this.CardNameTB_TextChanged);
            // 
            // ErrorTB
            // 
            this.ErrorTB.BackColor = System.Drawing.SystemColors.Control;
            this.ErrorTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorTB.Location = new System.Drawing.Point(294, 39);
            this.ErrorTB.Multiline = true;
            this.ErrorTB.Name = "ErrorTB";
            this.ErrorTB.ReadOnly = true;
            this.ErrorTB.Size = new System.Drawing.Size(172, 44);
            this.ErrorTB.TabIndex = 26;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(647, 26);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(126, 53);
            this.BackButton.TabIndex = 25;
            this.BackButton.Text = "Back to Card Selection";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(485, 26);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(122, 53);
            this.SaveButton.TabIndex = 24;
            this.SaveButton.Text = "Save Card Info";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Location = new System.Drawing.Point(12, 109);
            this.DescriptionTB.Multiline = true;
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(761, 441);
            this.DescriptionTB.TabIndex = 23;
            this.DescriptionTB.TextChanged += new System.EventHandler(this.DescriptionTB_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(342, 89);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 14);
            this.textBox7.TabIndex = 22;
            this.textBox7.Text = "Description";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GoldTB
            // 
            this.GoldTB.Location = new System.Drawing.Point(285, 13);
            this.GoldTB.Name = "GoldTB";
            this.GoldTB.Size = new System.Drawing.Size(73, 20);
            this.GoldTB.TabIndex = 18;
            this.GoldTB.TextChanged += new System.EventHandler(this.GoldTB_TextChanged);
            // 
            // Gold
            // 
            this.Gold.BackColor = System.Drawing.SystemColors.Control;
            this.Gold.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Gold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gold.Location = new System.Drawing.Point(247, 13);
            this.Gold.Name = "Gold";
            this.Gold.ReadOnly = true;
            this.Gold.Size = new System.Drawing.Size(51, 14);
            this.Gold.TabIndex = 17;
            this.Gold.Text = "Gold: ";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(364, 14);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(50, 14);
            this.textBox3.TabIndex = 27;
            this.textBox3.Text = "Power: ";
            // 
            // PowerTB
            // 
            this.PowerTB.Location = new System.Drawing.Point(411, 12);
            this.PowerTB.Name = "PowerTB";
            this.PowerTB.Size = new System.Drawing.Size(73, 20);
            this.PowerTB.TabIndex = 28;
            this.PowerTB.TextChanged += new System.EventHandler(this.PowerTB_TextChanged);
            // 
            // Treasure_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.PowerTB);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ErrorTB);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.GoldTB);
            this.Controls.Add(this.Gold);
            this.Controls.Add(this.CardNameTB);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.DefaultType);
            this.Controls.Add(this.EquipmentType);
            this.Controls.Add(this.textBox1);
            this.Name = "Treasure_Info";
            this.Text = "Treasure_Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox DefaultType;
        private System.Windows.Forms.CheckBox EquipmentType;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox CardNameTB;
        private System.Windows.Forms.TextBox ErrorTB;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox DescriptionTB;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox GoldTB;
        private System.Windows.Forms.TextBox Gold;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox PowerTB;
    }
}