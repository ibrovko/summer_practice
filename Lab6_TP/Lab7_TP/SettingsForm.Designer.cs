namespace Lab7_TP
{
    partial class SettingsForm
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonColorSelect = new System.Windows.Forms.Button();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMarkerColor = new System.Windows.Forms.Panel();
            this.buttonSelectColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonColorSelect);
            this.panel1.Controls.Add(this.colorPanel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 81);
            this.panel1.TabIndex = 0;
            // 
            // buttonColorSelect
            // 
            this.buttonColorSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColorSelect.Location = new System.Drawing.Point(3, 43);
            this.buttonColorSelect.Name = "buttonColorSelect";
            this.buttonColorSelect.Size = new System.Drawing.Size(111, 21);
            this.buttonColorSelect.TabIndex = 7;
            this.buttonColorSelect.Text = "Color of clock";
            this.buttonColorSelect.UseVisualStyleBackColor = true;
            this.buttonColorSelect.Click += new System.EventHandler(this.buttonClockColorSelect_Click);
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.Black;
            this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorPanel.Location = new System.Drawing.Point(120, 43);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(26, 22);
            this.colorPanel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clock";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelMarkerColor);
            this.panel2.Controls.Add(this.buttonSelectColor);
            this.panel2.Location = new System.Drawing.Point(187, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 81);
            this.panel2.TabIndex = 1;
            // 
            // panelMarkerColor
            // 
            this.panelMarkerColor.BackColor = System.Drawing.Color.Red;
            this.panelMarkerColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMarkerColor.ForeColor = System.Drawing.Color.Red;
            this.panelMarkerColor.Location = new System.Drawing.Point(126, 43);
            this.panelMarkerColor.Name = "panelMarkerColor";
            this.panelMarkerColor.Size = new System.Drawing.Size(22, 22);
            this.panelMarkerColor.TabIndex = 14;
            // 
            // buttonSelectColor
            // 
            this.buttonSelectColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSelectColor.Location = new System.Drawing.Point(6, 43);
            this.buttonSelectColor.Name = "buttonSelectColor";
            this.buttonSelectColor.Size = new System.Drawing.Size(114, 23);
            this.buttonSelectColor.TabIndex = 13;
            this.buttonSelectColor.Text = "Arrow color";
            this.buttonSelectColor.UseVisualStyleBackColor = true;
            this.buttonSelectColor.Click += new System.EventHandler(this.buttonArrowColorSelect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Arrow";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(354, 126);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSelectColor;
        private System.Windows.Forms.Panel panelMarkerColor;
        private System.Windows.Forms.Button buttonColorSelect;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog2;
    }
}