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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public FormTools FormTools = new FormTools();
        public FormToolMod FormToolMod = new FormToolMod();
        public FormPicMod FormPicMod= new FormPicMod();
        public FormPicture FormPic;//= new FormPicture();

        private void Form1_Shown(object sender, EventArgs e)
        {
            //FormSettings.Parent = this;
            //FormTools.Parent = this;
            FormTools.Location = new Point(Location.X + 15, Location.Y + 90);
            FormToolMod.Location = new Point(Location.X + Size.Width - FormToolMod.Size.Width - 15, Location.Y + 90);
            FormPicMod.Location = new Point(Location.X + Size.Width - FormToolMod.Size.Width - 15, Location.Y + 90);
            FormToolMod.Show(this);
            FormTools.Show(this);
            FormPicMod.Show(this);
            ((NumericUpDown)FormPicMod.Controls["numScale"]).Value = 5;
        }

        private void СоздатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewPicCreate NewPicSize = new FormNewPicCreate();
            if (NewPicSize.ShowDialog() == DialogResult.OK)
            {
                FormPic = new FormPicture(int.Parse(NewPicSize.Controls["numWidth"].Text), int.Parse(NewPicSize.Controls["numHeight"].Text));
                FormPic.Text = "Новый файл";
                FormPic.MdiParent = this;
                FormPic.Show();
            }
        }
        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "BMP|*.bmp|PNG|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.CheckPathExists)
                {
                    FormPic = new FormPicture(openFileDialog.FileName);
                    FormPic.Text = openFileDialog.FileName;
                    FormPic.MdiParent = this;
                    FormPic.Show();
                }
                // (ActiveMdiChild.Controls["pctBox"] as PictureBox).Image = Image.FromFile(openFileDialog.FileName); //sdfghjkl;lkhf
            }
        }

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Length>0)
            {
                saveFileDialog.FileName = ActiveMdiChild.Text;
                saveFileDialog.Filter = "BMP|*.bmp|PNG|*.png";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    (ActiveMdiChild.Controls["pctBox"] as PictureBox).Image.Save(saveFileDialog.FileName);
                }
            }
        }

    }
}
