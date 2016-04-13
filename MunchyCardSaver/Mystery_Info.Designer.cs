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
            this.ClassType = new System.Windows.Forms.CheckBox();
            this.EventType = new System.Windows.Forms.CheckBox();
            this.MonsterType = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CardNameTB = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.PowerTB = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.FalseState = new System.Windows.Forms.CheckBox();
            this.TrueState = new System.Windows.Forms.CheckBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClassType
            // 
            this.ClassType.AutoSize = true;
            this.ClassType.Location = new System.Drawing.Point(12, 40);
            this.ClassType.Name = "ClassType";
            this.ClassType.Size = new System.Drawing.Size(60, 17);
            this.ClassType.TabIndex = 1;
            this.ClassType.Text = "CLASS";
            this.ClassType.UseVisualStyleBackColor = true;
            this.ClassType.CheckedChanged += new System.EventHandler(this.ClassType_CheckedChanged);
            // 
            // EventType
            // 
            this.EventType.AutoSize = true;
            this.EventType.Location = new System.Drawing.Point(12, 63);
            this.EventType.Name = "EventType";
            this.EventType.Size = new System.Drawing.Size(62, 17);
            this.EventType.TabIndex = 2;
            this.EventType.Text = "EVENT";
            this.EventType.UseVisualStyleBackColor = true;
            this.EventType.CheckedChanged += new System.EventHandler(this.EventType_CheckedChanged);
            // 
            // MonsterType
            // 
            this.MonsterType.AutoSize = true;
            this.MonsterType.Location = new System.Drawing.Point(12, 86);
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
            this.textBox1.Location = new System.Drawing.Point(12, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 21);
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
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(247, 14);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(51, 14);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Power: ";
            // 
            // PowerTB
            // 
            this.PowerTB.Location = new System.Drawing.Point(294, 14);
            this.PowerTB.Name = "PowerTB";
            this.PowerTB.Size = new System.Drawing.Size(100, 20);
            this.PowerTB.TabIndex = 8;
            this.PowerTB.TextChanged += new System.EventHandler(this.PowerTB_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(247, 38);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(49, 14);
            this.textBox6.TabIndex = 9;
            this.textBox6.Text = "State";
            // 
            // FalseState
            // 
            this.FalseState.AutoSize = true;
            this.FalseState.Location = new System.Drawing.Point(247, 66);
            this.FalseState.Name = "FalseState";
            this.FalseState.Size = new System.Drawing.Size(32, 17);
            this.FalseState.TabIndex = 10;
            this.FalseState.Text = "0";
            this.FalseState.UseVisualStyleBackColor = true;
            this.FalseState.CheckedChanged += new System.EventHandler(this.FalseState_CheckedChanged);
            // 
            // TrueState
            // 
            this.TrueState.AutoSize = true;
            this.TrueState.Location = new System.Drawing.Point(247, 86);
            this.TrueState.Name = "TrueState";
            this.TrueState.Size = new System.Drawing.Size(32, 17);
            this.TrueState.TabIndex = 11;
            this.TrueState.Text = "1";
            this.TrueState.UseVisualStyleBackColor = true;
            this.TrueState.CheckedChanged += new System.EventHandler(this.TrueState_CheckedChanged);
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
            // Mystery_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 563);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.TrueState);
            this.Controls.Add(this.FalseState);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.PowerTB);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.CardNameTB);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MonsterType);
            this.Controls.Add(this.EventType);
            this.Controls.Add(this.ClassType);
            this.Name = "Mystery_Info";
            this.Text = "Munchy Card Saver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ClassType;
        private System.Windows.Forms.CheckBox EventType;
        private System.Windows.Forms.CheckBox MonsterType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox CardNameTB;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox PowerTB;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.CheckBox FalseState;
        private System.Windows.Forms.CheckBox TrueState;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox DescriptionTB;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button BackButton;
    }
}