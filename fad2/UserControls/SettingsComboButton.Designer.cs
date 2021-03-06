﻿namespace fad2.UI.UserControls
{
    partial class SettingsComboButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SettingKey = new MetroFramework.Controls.MetroLabel();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.MetroToolTip = new MetroFramework.Components.MetroToolTip();
            this.SettingValue = new MetroFramework.Controls.MetroComboBox();
            this.Action = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SettingKey
            // 
            this.SettingKey.Location = new System.Drawing.Point(4, 5);
            this.SettingKey.Name = "SettingKey";
            this.SettingKey.Size = new System.Drawing.Size(223, 23);
            this.SettingKey.TabIndex = 0;
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.BackColor = System.Drawing.Color.Transparent;
            this.WarningLabel.Font = new System.Drawing.Font("Webdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.WarningLabel.Location = new System.Drawing.Point(622, 6);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(36, 26);
            this.WarningLabel.TabIndex = 4;
            this.WarningLabel.Text = "i";
            this.MetroToolTip.SetToolTip(this.WarningLabel, "\r\n");
            // 
            // SettingValue
            // 
            this.SettingValue.DisplayMember = "Value";
            this.SettingValue.FormattingEnabled = true;
            this.SettingValue.ItemHeight = 23;
            this.SettingValue.Items.AddRange(new object[] {
            "eins ",
            "zwei ",
            "drei"});
            this.SettingValue.Location = new System.Drawing.Point(233, 3);
            this.SettingValue.Name = "SettingValue";
            this.SettingValue.Size = new System.Drawing.Size(383, 29);
            this.SettingValue.TabIndex = 5;
            this.SettingValue.ValueMember = "Key";
            this.SettingValue.SelectionChangeCommitted += new System.EventHandler(this.SettingValue_SelectionChangeCommitted);
            // 
            // Action
            // 
            this.Action.Location = new System.Drawing.Point(664, 3);
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(98, 29);
            this.Action.TabIndex = 6;
            this.Action.Text = "GO";
            this.Action.UseVisualStyleBackColor = true;
            // 
            // SettingsComboButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Action);
            this.Controls.Add(this.SettingValue);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.SettingKey);
            this.Name = "SettingsComboButton";
            this.Size = new System.Drawing.Size(765, 37);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroLabel SettingKey;
        private System.Windows.Forms.Label WarningLabel;
        private MetroFramework.Components.MetroToolTip MetroToolTip;
        private MetroFramework.Controls.MetroComboBox SettingValue;
        public System.Windows.Forms.Button Action;
    }
}
