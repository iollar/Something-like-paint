using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба8
{
    public partial class FormToolMod : Form
    {
        public FormToolMod()
        {
            InitializeComponent();
           // Location = new Point()
        }

        private void NumSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
                e.Handled = true;
            else if (e.KeyChar == '\u0016')
            {
                if (!int.TryParse(Clipboard.GetText(), out int n))
                {
                    foreach (char c in Clipboard.GetText())
                        if (!char.IsDigit(c))
                            Clipboard.SetText(Clipboard.GetText().Replace(c.ToString(),""));
                }
            }
        }

        private void NumSize_Leave(object sender, EventArgs e)
        {
            //if(!int.TryParse(Clipboard.GetText(), out int n))

        }

        private void LbColor_Click(object sender, EventArgs e)
        {
            clrBorder.ShowDialog();
            (sender as Label).BackColor = clrBorder.Color;
        }

        private void lbColorExchange_Click(object sender, EventArgs e)
        {
            (lbColor1.BackColor, lbColor2.BackColor) = (lbColor2.BackColor, lbColor1.BackColor);
        }

        private void LbPalette_Click(object sender, EventArgs e)
        {
            if ((sender as Label).BackColor != Color.Transparent)
                lbColor1.BackColor = (sender as Label).BackColor;
        }

        private void LbPalette_DoubleClick(object sender, EventArgs e)
        {
            if ((sender as Label).BackColor == Color.Transparent)
                (sender as Label).BackColor = lbColor1.BackColor;
            else
            (sender as Label).BackColor = Color.Transparent;
        }

        bool Clicked;
        private async void LbPalette_MouseClick(object sender, MouseEventArgs e)
        {
            if (Clicked) return;

                Clicked = true;
                await Task.Delay(SystemInformation.DoubleClickTime);
            if (!Clicked) return;
            Clicked = false;
                //if (e.Clicks == 1)
                {
                    if ((sender as Label).BackColor != Color.Transparent)
                        lbColor1.BackColor = (sender as Label).BackColor;
                }
            
        }

        private void LbPalette_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Clicked = false;
                if ((sender as Label).BackColor == Color.Transparent)
                (sender as Label).BackColor = lbColor1.BackColor;
            else
                (sender as Label).BackColor = Color.Transparent;
        }
    }
}//сделать класс для инструмента и настроек
//
