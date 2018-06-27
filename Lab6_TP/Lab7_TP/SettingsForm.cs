using System;
using System.Drawing;
using System.Windows.Forms;


namespace Lab7_TP
{
    public partial class SettingsForm :Form
    {
        Graphics g;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void buttonClockColorSelect_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Setting.ColorOfClock[0] = colorDialog1.Color;
                colorPanel.BackColor = colorDialog1.Color;
            }       
        }

        private void buttonArrowColorSelect_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() != DialogResult.Cancel)
            {
                Setting.ColorOfArrow[0] = colorDialog2.Color;
                panelMarkerColor.BackColor = colorDialog2.Color;
            }
        }    
    }
}