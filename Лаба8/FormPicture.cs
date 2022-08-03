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
    public partial class FormPicture : Form
    {
        public FormPicture()
        {
            InitializeComponent();
        }
        public FormPicture(string fileName)
        {
            InitializeComponent();
            Bmp = new Bitmap(Image.FromFile(fileName));
            BmpSave = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pctBox.Image = Bmp;
        }
        public FormPicture(int width, int height)
        {
            InitializeComponent();
            Bmp = new Bitmap(width, height);
            BmpSave = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pctBox.Image = Bmp;
        }
        public bool ScaleChangedByUser = true;

        Bitmap Bmp, BmpSave;
        Point PrevPoint;

        Graphics G;
        string ToolName;
        int ToolSize;
        Color ToolColor1, ToolColor2;
        bool ToolUseBmpSaveResalt;
        int OldScale = 1;
        bool CheckCircuit, CheckFill;

        public void ScaleBmp(int newScale)
        {
            Bitmap bmp = new Bitmap(Bmp.Width / OldScale * newScale, Bmp.Height / OldScale * newScale);
            for (int x = 0; x < Bmp.Width; x += OldScale)
                for (int y = 0; y < Bmp.Height; y += OldScale)
                {
                    Color color = Bmp.GetPixel(x, y);
                    for (int x1 = 0; x1 < newScale; x1++)
                        for (int y1 = 0; y1 < newScale; y1++)
                            bmp.SetPixel(x1 + newScale * x / OldScale, y1 + newScale * y / OldScale, color);
                }
            OldScale = newScale;
            Bmp = (Bitmap)bmp.Clone();
            pctBox.Image = Bmp;
        }

        private void PctFile_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PrevPoint = e.Location;

                G = Graphics.FromImage(Bmp);
                ToolName = ((Form1)MdiParent).FormTools.ActiveControl.Name;
                ToolColor1 = ((Form1)MdiParent).FormToolMod.Controls["lbColor1"].BackColor;
                ToolSize = int.Parse(((Form1)MdiParent).FormToolMod.Controls["numSize"].Text) * OldScale;
                

                ToolUseBmpSaveResalt = ToolUseBmpSave();
                if (ToolUseBmpSaveResalt)
                {
                    BmpSave = (Bitmap)Bmp.Clone();
                    ToolColor2 = ((Form1)MdiParent).FormToolMod.Controls["lbColor2"].BackColor;
                    CheckCircuit = (((Form1)MdiParent).FormToolMod.Controls["checkCircuit"] as CheckBox).Checked;
                    CheckFill = (((Form1)MdiParent).FormToolMod.Controls["checkFill"] as CheckBox).Checked;
                }
                else
                    ToolsNotUsingBmpSave(e.Location);

            }


        }
        private void PctFile_MouseMove(object sender, MouseEventArgs e)
        {
            ((Form1)MdiParent).Controls["lbX"].Text = $"X: {e.X}";
            ((Form1)MdiParent).Controls["lbY"].Text = $"Y: {e.Y}";
            if (e.Button == MouseButtons.Left)
            {
                if (ToolUseBmpSaveResalt)
                {
                    Bmp = (Bitmap)BmpSave.Clone();
                    G = Graphics.FromImage(Bmp);
                    ToolsUsingBmpSave(e.Location);
                }
                else
                    ToolsNotUsingBmpSave(e.Location);
            }
        }

        private void PctBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ToolUseBmpSaveResalt)
                {
                    ToolsUsingBmpSave(e.Location);
                }
                else
                    ToolsNotUsingBmpSave(e.Location);
            }
        }

        private void ToolsUsingBmpSave(Point point)
        {
            switch (ToolName)
            {
                case "btnEllipse":
                    {
                        if(CheckFill)
                            G.FillEllipse(new SolidBrush(ToolColor2), ForRectOrEllipsDrawing(point));
                        if (CheckCircuit)
                            G.DrawEllipse(new Pen(ToolColor1, ToolSize), ForRectOrEllipsDrawing(point));
                        
                        break;
                    }
                case "btnRectangle":
                    {
                        if (CheckFill)
                            G.FillRectangle(new SolidBrush(ToolColor2), ForRectOrEllipsDrawing(point));
                        if (CheckCircuit)
                            G.DrawRectangle(new Pen(ToolColor1, ToolSize), ForRectOrEllipsDrawing(point));
                        break;
                    }
                case "btnLine":
                    {
                        G.DrawLine(new Pen(ToolColor1, ToolSize), point, PrevPoint);
                        break;
                    }
                case "btnTest":
                    {
                        if (pctBox.Size.Width > point.X && pctBox.Size.Height > point.Y)
                        {
                            G.FillEllipse(new SolidBrush(ToolColor1), point.X - ToolSize / 2, point.Y - ToolSize / 2, ToolSize, ToolSize);
                            G.DrawLine(new Pen(ToolColor1, ToolSize), PrevPoint, point);
                        }
                        PrevPoint = point;
                        break;
                    }
            }
            pctBox.Image = Bmp;
           // pictureBox1.Image = BmpSave;//
        }

        private void ToolsNotUsingBmpSave(Point point)
         {
            switch (ToolName)
            {
                case "btnPencil":
                    {
                        G.FillEllipse(new SolidBrush(ToolColor1), point.X - ToolSize / 2, point.Y - ToolSize / 2, ToolSize, ToolSize);
                        G.DrawLine(new Pen(ToolColor1, ToolSize), PrevPoint, point);
                        break;
                    }
                case "btnRubber":
                    {
                        //ToolColor1 = Bmp.GetPixel(point.X,point.Y);
                        /*SolidBrush*/ //Pen rubber = new Pen(ToolColor1,ToolSize);
                                       //rubber.Ma
                                       //Color.FromArgb(0,0,0,0)
                        ToolColor1 = Bmp.GetPixel(point.X, point.Y);
                        G.FillEllipse(new SolidBrush(ToolColor1), point.X - ToolSize / 2, point.Y - ToolSize / 2, ToolSize, ToolSize);
                        //G.DrawLine(new Pen(ToolColor1, ToolSize), PrevPoint, point);
                        Bmp.MakeTransparent(ToolColor1);
                        break;
                    }
                
            }
            pctBox.Image = Bmp;
            PrevPoint = point;
            // pctBox.In
        }

        private void Fill (int x,int y, Color oldColor)
        {
            //G.FillPolygon(new SolidBrush(ToolColor1), new Point[] { new Point(10, 10), new Point(10, 50), new Point(50, 10) });
            
            
           Bmp.SetPixel(x, y, ToolColor2);
            //pctBox.Image = Bmp;//эта строка ради эксперемента, позже ее шадо удалить
            if (Bmp.GetPixel(x+1,y).ToArgb()==oldColor.ToArgb())
                Fill(x + 1, y, oldColor);
            if (Bmp.GetPixel(x - 1, y).ToArgb() == oldColor.ToArgb())
                Fill(x - 1, y, oldColor);
            if (Bmp.GetPixel(x, y+1).ToArgb() == oldColor.ToArgb())
                Fill(x, y + 1, oldColor);
            if (Bmp.GetPixel(x , y-1).ToArgb() == oldColor.ToArgb())
                Fill(x, y - 1, oldColor);
        }

        private void FormPicture_Activated(object sender, EventArgs e)
        {
            foreach (Control c in ((Form1)MdiParent).FormPicMod.Controls)
                c.Enabled = true;
            ((NumericUpDown)((Form1)MdiParent).FormPicMod.Controls["numScale"]).Value = OldScale;
            ScaleChangedByUser = true;
        }
        private void FormPicture_Deactivate(object sender, EventArgs e)
        {
            foreach (Control c in ((Form1)MdiParent).FormPicMod.Controls)
                c.Enabled = false;
            ScaleChangedByUser = false;
            ((NumericUpDown)((Form1)MdiParent).FormPicMod.Controls["numScale"]).Value = 1;
        }
        private void FormPicture_Shown(object sender, EventArgs e)
        {
            pctBox.Location = new Point(ClientSize.Width / 2 - Bmp.Width / 2, ClientSize.Height / 2 - Bmp.Height / 2);
        }
        private async void PctBox_MouseClick(object sender, MouseEventArgs e)
        {
            int z=0;//
            //System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
           //timer.Start();
            if (ToolName == "btnFill")
            {
                Color oldColor = Bmp.GetPixel(e.X, e.Y);
                if (oldColor.ToArgb() != ToolColor1.ToArgb())
                {
                    List<Point> points = new List<Point>() { new Point(e.X, e.Y) };
                    while (points.Count() > 0)
                    {
                        List<Point> newPoints = new List<Point>();
                        foreach (Point p in points)
                        {

                            if (p.X + 1 < Bmp.Width && Bmp.GetPixel(p.X + 1, p.Y).ToArgb() == oldColor.ToArgb())
                            {
                                Bmp.SetPixel(p.X + 1, p.Y, ToolColor1);
                                newPoints.Add(new Point(p.X + 1, p.Y));
                            }
                            if (p.X - 1 >= 0 && Bmp.GetPixel(p.X - 1, p.Y).ToArgb() == oldColor.ToArgb())
                            {
                                Bmp.SetPixel(p.X - 1, p.Y, ToolColor1);
                                newPoints.Add(new Point(p.X - 1, p.Y));
                            }
                            if (p.Y + 1 < Bmp.Height && Bmp.GetPixel(p.X, p.Y + 1).ToArgb() == oldColor.ToArgb())
                            {
                                Bmp.SetPixel(p.X, p.Y + 1, ToolColor1);
                                newPoints.Add(new Point(p.X, p.Y + 1));
                            }
                            if (p.Y - 1 >= 0 && Bmp.GetPixel(p.X, p.Y - 1).ToArgb() == oldColor.ToArgb())
                            {
                                Bmp.SetPixel(p.X, p.Y - 1, ToolColor1);
                                newPoints.Add(new Point(p.X, p.Y - 1));
                            }
                            
                        }
                        /*z++;
                        if (z % 10 == 0)
                        {
                            Random color = new Random();
                            ToolColor1 = Color.FromArgb(225, color.Next(0, 225), color.Next(0, 225), color.Next(0, 225));
                        }
                        await Task.Delay(1);
                        pctBox.Image = Bmp;*/ //креативный вариант заливки со сменой цвета
                        newPoints = newPoints.Distinct().ToList();
                        points.Clear();
                        points.AddRange(newPoints);
                    }
                }
            }
            pctBox.Image = Bmp;
          // timer.Stop();
         // MessageBox.Show($"Время затраченное на заливку: {timer.ElapsedMilliseconds.ToString()} мс");
        }

        private void pctBox_Click(object sender, EventArgs e)
        {

        }

        private void FormPicture_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                foreach (Control c in ((Form1)MdiParent).FormPicMod.Controls)
                    c.Enabled = false;
                ScaleChangedByUser = false;
                ((NumericUpDown)((Form1)MdiParent).FormPicMod.Controls["numScale"]).Value = 1;
            }
            else
            {
                try
                {
                    foreach (Control c in ((Form1)MdiParent).FormPicMod.Controls)
                        c.Enabled = true;
                    ((NumericUpDown)((Form1)MdiParent).FormPicMod.Controls["numScale"]).Value = OldScale;
                    ScaleChangedByUser = true;
                }
                catch(System.NullReferenceException)
                { ; }
            }
        }

        private Rectangle ForRectOrEllipsDrawing(Point point)
        {
            int x1, x2, y1, y2;
            if (point.X >= PrevPoint.X)
            {
                x1 = PrevPoint.X;
                x2 = point.X - PrevPoint.X;
            }
            else
            {
                x1 = point.X;
                x2 = PrevPoint.X - point.X;
            }
            if (point.Y >= PrevPoint.Y)
            {
                y1 = PrevPoint.Y;
                y2 = point.Y - PrevPoint.Y;
            }
            else
            {
                y1 = point.Y;
                y2 = PrevPoint.Y - point.Y;
            }
            return new Rectangle(x1-ToolSize/2, y1-ToolSize/2, x2+ToolSize, y2+ToolSize);
        }
        private bool ToolUseBmpSave()
        {
            
            if (new List<string>() { "btnPencil", "btnRubber","btnFill"}.Contains(ToolName))
                return false;
            else
                return true;
        }




        //форма 1 хранит все сведения об активном инструменте и его настройках
    }
}
