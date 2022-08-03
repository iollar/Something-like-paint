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
    public partial class FormPicMod : Form
    {
        public FormPicMod()
        {
            InitializeComponent();
        }



        private void NumScale_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (((FormPicture)Owner.ActiveMdiChild).ScaleChangedByUser)
                    ((FormPicture)Owner.ActiveMdiChild).ScaleBmp((int)numScale.Value);
            }
            catch (System.NullReferenceException)
            { }
        }

    }
}
