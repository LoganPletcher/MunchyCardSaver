namespace MunchyCardSaver
{
    partial class Munch_Card_Saving_CC
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
            this.TreasureButton = new System.Windows.Forms.Button();
            this.MysteryButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TreasureButton
            // 
            this.TreasureButton.Location = new System.Drawing.Point(363, 280);
            this.TreasureButton.Name = "TreasureButton";
            this.TreasureButton.Size = new System.Drawing.Size(75, 41);
            this.TreasureButton.TabIndex = 0;
            this.TreasureButton.Text = "Treasure Card";
            this.TreasureButton.UseVisualStyleBackColor = true;
            this.TreasureButton.Click += new System.EventHandler(this.TreasureButton_Click);
            // 
            // MysteryButton
            // 
            this.MysteryButton.Location = new System.Drawing.Point(363, 220);
            this.MysteryButton.Name = "MysteryButton";
            this.MysteryButton.Size = new System.Drawing.Size(75, 41);
            this.MysteryButton.TabIndex = 1;
            this.MysteryButton.Text = "Mystery Card";
            this.MysteryButton.UseVisualStyleBackColor = true;
            this.MysteryButton.Click += new System.EventHandler(this.MysteryButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(222, 78);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(360, 136);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "What kind of card do you want to save?";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(363, 340);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 41);
            this.QuitButton.TabIndex = 3;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // Munch_Card_Saving_CC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 563);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MysteryButton);
            this.Controls.Add(this.TreasureButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Munch_Card_Saving_CC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Munchy Card Saver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TreasureButton;
        private System.Windows.Forms.Button MysteryButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button QuitButton;
    }
}

