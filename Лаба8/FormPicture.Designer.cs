namespace Лаба8
{
    partial class FormPicture
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
            this.pctBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBox
            // 
            this.pctBox.BackColor = System.Drawing.Color.LightGray;
            this.pctBox.Location = new System.Drawing.Point(36, 38);
            this.pctBox.Name = "pctBox";
            this.pctBox.Size = new System.Drawing.Size(50, 50);
            this.pctBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctBox.TabIndex = 0;
            this.pctBox.TabStop = false;
            this.pctBox.Click += new System.EventHandler(this.pctBox_Click);
            this.pctBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PctBox_MouseClick);
            this.pctBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PctFile_MouseDown);
            this.pctBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PctFile_MouseMove);
            this.pctBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PctBox_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(542, 259);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // FormPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pctBox);
            this.Name = "FormPicture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый файл";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FormPicture_Activated);
            this.Deactivate += new System.EventHandler(this.FormPicture_Deactivate);
            this.Shown += new System.EventHandler(this.FormPicture_Shown);
            this.SizeChanged += new System.EventHandler(this.FormPicture_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}