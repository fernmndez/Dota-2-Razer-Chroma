namespace Dota_2_Razer
{
    partial class MainForm
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
            this.colorsGroupBox = new System.Windows.Forms.GroupBox();
            this.abilityKeysButton = new System.Windows.Forms.Button();
            this.manaCheckBox = new System.Windows.Forms.CheckBox();
            this.hpCheckBox = new System.Windows.Forms.CheckBox();
            this.dotaColorDialog = new System.Windows.Forms.ColorDialog();
            this.colorsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorsGroupBox
            // 
            this.colorsGroupBox.Controls.Add(this.abilityKeysButton);
            this.colorsGroupBox.Controls.Add(this.manaCheckBox);
            this.colorsGroupBox.Controls.Add(this.hpCheckBox);
            this.colorsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.colorsGroupBox.Name = "colorsGroupBox";
            this.colorsGroupBox.Size = new System.Drawing.Size(397, 266);
            this.colorsGroupBox.TabIndex = 0;
            this.colorsGroupBox.TabStop = false;
            this.colorsGroupBox.Text = "Keys";
            // 
            // abilityKeysButton
            // 
            this.abilityKeysButton.Location = new System.Drawing.Point(6, 66);
            this.abilityKeysButton.Name = "abilityKeysButton";
            this.abilityKeysButton.Size = new System.Drawing.Size(174, 23);
            this.abilityKeysButton.TabIndex = 2;
            this.abilityKeysButton.Text = "Change Ability Keys";
            this.abilityKeysButton.UseVisualStyleBackColor = true;
            this.abilityKeysButton.Click += new System.EventHandler(this.abilityKeysButton_Click);
            // 
            // manaCheckBox
            // 
            this.manaCheckBox.AutoSize = true;
            this.manaCheckBox.Checked = true;
            this.manaCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.manaCheckBox.Location = new System.Drawing.Point(7, 43);
            this.manaCheckBox.Name = "manaCheckBox";
            this.manaCheckBox.Size = new System.Drawing.Size(174, 17);
            this.manaCheckBox.TabIndex = 1;
            this.manaCheckBox.Text = "Use Number Keys as Mana Bar";
            this.manaCheckBox.UseVisualStyleBackColor = true;
            this.manaCheckBox.CheckedChanged += new System.EventHandler(this.manaCheckBox_CheckedChanged);
            // 
            // hpCheckBox
            // 
            this.hpCheckBox.AutoSize = true;
            this.hpCheckBox.Checked = true;
            this.hpCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hpCheckBox.Location = new System.Drawing.Point(7, 20);
            this.hpCheckBox.Name = "hpCheckBox";
            this.hpCheckBox.Size = new System.Drawing.Size(130, 17);
            this.hpCheckBox.TabIndex = 0;
            this.hpCheckBox.Text = "Use F keys as HP Bar";
            this.hpCheckBox.UseVisualStyleBackColor = true;
            this.hpCheckBox.CheckedChanged += new System.EventHandler(this.hpCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 290);
            this.Controls.Add(this.colorsGroupBox);
            this.Name = "MainForm";
            this.Text = "Dota 2 Razer Chroma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.colorsGroupBox.ResumeLayout(false);
            this.colorsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox colorsGroupBox;
        private System.Windows.Forms.ColorDialog dotaColorDialog;
        private System.Windows.Forms.CheckBox manaCheckBox;
        private System.Windows.Forms.CheckBox hpCheckBox;
        private System.Windows.Forms.Button abilityKeysButton;
    }
}

