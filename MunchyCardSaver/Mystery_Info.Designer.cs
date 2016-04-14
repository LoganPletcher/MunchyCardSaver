namespace MunchyCardSaver
{
    partial class Mystery_Info
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
            this.CurseType = new System.Windows.Forms.CheckBox();
            this.MonsterType = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CardNameTB = new System.Windows.Forms.TextBox();
            this.PowerTextDisplay = new System.Windows.Forms.TextBox();
            this.PowerTB = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ErrorTB = new System.Windows.Forms.TextBox();
            this.RewardTextDisplay = new System.Windows.Forms.TextBox();
            this.RewardTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CurseType
            // 
            this.CurseType.AutoSize = true;
            this.CurseType.Location = new System.Drawing.Point(12, 40);
            this.CurseType.Name = "CurseType";
            this.CurseType.Size = new System.Drawing.Size(63, 17);
            this.CurseType.TabIndex = 2;
            this.CurseType.Text = "CURSE";
            this.CurseType.UseVisualStyleBackColor = true;
            this.CurseType.CheckedChanged += new System.EventHandler(this.CurseType_CheckedChanged);
            // 
            // MonsterType
            // 
            this.MonsterType.AutoSize = true;
            this.MonsterType.Location = new System.Drawing.Point(12, 58);
            this.MonsterType.Name = "MonsterType";
            this.MonsterType.Size = new System.Drawing.Size(80, 17);
            this.MonsterType.TabIndex = 3;
            this.MonsterType.Text = "MONSTER";
            this.MonsterType.UseVisualStyleBackColor = true;
            this.MonsterType.CheckedChanged += new System.EventHandler(this.MonsterType_CheckedChanged);
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
            this.textBox1.Size = new System.Drawing.Size(122, 21);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Mystery Card Type";
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
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Card Name";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CardNameTB
            // 
            this.CardNameTB.Location = new System.Drawing.Point(118, 38);
            this.CardNameTB.Multiline = true;
            this.CardNameTB.Name = "CardNameTB";
            this.CardNameTB.Size = new System.Drawing.Size(122, 65);
            this.CardNameTB.TabIndex = 6;
            this.CardNameTB.TextChanged += new System.EventHandler(this.CardNameTB_TextChanged);
            // 
            // PowerTextDisplay
            // 
            this.PowerTextDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.PowerTextDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PowerTextDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerTextDisplay.Location = new System.Drawing.Point(247, 14);
            this.PowerTextDisplay.Name = "PowerTextDisplay";
            this.PowerTextDisplay.ReadOnly = true;
            this.PowerTextDisplay.Size = new System.Drawing.Size(51, 14);
            this.PowerTextDisplay.TabIndex = 7;
            this.PowerTextDisplay.Text = "Power: ";
            // 
            // PowerTB
            // 
            this.PowerTB.Location = new System.Drawing.Point(294, 14);
            this.PowerTB.Name = "PowerTB";
            this.PowerTB.Size = new System.Drawing.Size(60, 20);
            this.PowerTB.TabIndex = 8;
            this.PowerTB.TextChanged += new System.EventHandler(this.PowerTB_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(342, 90);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 14);
            this.textBox7.TabIndex = 12;
            this.textBox7.Text = "Description";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Location = new System.Drawing.Point(12, 110);
            this.DescriptionTB.Multiline = true;
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(761, 441);
            this.DescriptionTB.TabIndex = 13;
            this.DescriptionTB.TextChanged += new System.EventHandler(this.DescriptionTB_TextChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(485, 27);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(122, 53);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Save Card Info";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(647, 27);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(126, 53);
            this.BackButton.TabIndex = 15;
            this.BackButton.Text = "Back to Card Selection";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ErrorTB
            // 
            this.ErrorTB.BackColor = System.Drawing.SystemColors.Control;
            this.ErrorTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorTB.Location = new System.Drawing.Point(294, 40);
            this.ErrorTB.Multiline = true;
            this.ErrorTB.Name = "ErrorTB";
            this.ErrorTB.ReadOnly = true;
            this.ErrorTB.Size = new System.Drawing.Size(172, 44);
            this.ErrorTB.TabIndex = 16;
            // 
            // RewardTextDisplay
            // 
            this.RewardTextDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.RewardTextDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RewardTextDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RewardTextDisplay.Location = new System.Drawing.Point(360, 15);
            this.RewardTextDisplay.Name = "RewardTextDisplay";
            this.RewardTextDisplay.ReadOnly = true;
            this.RewardTextDisplay.Size = new System.Drawing.Size(59, 14);
            this.RewardTextDisplay.TabIndex = 17;
            this.RewardTextDisplay.Text = "Reward: ";
            // 
            // RewardTB
            // 
            this.RewardTB.Location = new System.Drawing.Point(415, 13);
            this.RewardTB.Name = "RewardTB";
            this.RewardTB.Size = new System.Drawing.Size(60, 20);
            this.RewardTB.TabIndex = 18;
            this.RewardTB.TextChanged += new System.EventHandler(this.RewardTB_TextChanged);
            // 
            // Mystery_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 563);
            this.Controls.Add(this.RewardTB);
            this.Controls.Add(this.RewardTextDisplay);
            this.Controls.Add(this.ErrorTB);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.PowerTB);
            this.Controls.Add(this.PowerTextDisplay);
            this.Controls.Add(this.CardNameTB);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MonsterType);
            this.Controls.Add(this.CurseType);
            this.Name = "Mystery_Info";
            this.Text = "Munchy Card Saver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox CurseType;
        private System.Windows.Forms.CheckBox MonsterType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox CardNameTB;
        private System.Windows.Forms.TextBox PowerTextDisplay;
        private System.Windows.Forms.TextBox PowerTB;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox DescriptionTB;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox ErrorTB;
        private System.Windows.Forms.TextBox RewardTextDisplay;
        private System.Windows.Forms.TextBox RewardTB;
    }
}