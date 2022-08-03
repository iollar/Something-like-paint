namespace Лаба8
{
    partial class FormTools
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
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRubber = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnPencil = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTriangle
            // 
            this.btnTriangle.BackColor = System.Drawing.Color.White;
            this.btnTriangle.Enabled = false;
            this.btnTriangle.Location = new System.Drawing.Point(3, 410);
            this.btnTriangle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(50, 50);
            this.btnTriangle.TabIndex = 4;
            this.btnTriangle.Text = "треугольник";
            this.btnTriangle.UseVisualStyleBackColor = false;
            this.btnTriangle.Click += new System.EventHandler(this.BtnRubber_Click);
            this.btnTriangle.Enter += new System.EventHandler(this.BtnTool_Enter);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.White;
            this.btnTest.Location = new System.Drawing.Point(3, 352);
            this.btnTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(50, 50);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "button6";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.BtnRubber_Click);
            this.btnTest.Enter += new System.EventHandler(this.BtnTool_Enter);
            // 
            // btnFill
            // 
            this.btnFill.BackColor = System.Drawing.Color.White;
            this.btnFill.Location = new System.Drawing.Point(3, 294);
            this.btnFill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(50, 50);
            this.btnFill.TabIndex = 8;
            this.btnFill.Text = "заливка";
            this.btnFill.UseVisualStyleBackColor = false;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(3, 468);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 9;
            this.button2.Text = "треугольник";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.White;
            this.btnLine.Image = global::Лаба8.Properties.Resources.Прямая;
            this.btnLine.Location = new System.Drawing.Point(3, 62);
            this.btnLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(50, 50);
            this.btnLine.TabIndex = 7;
            this.btnLine.UseVisualStyleBackColor = false;
            // 
            // btnRubber
            // 
            this.btnRubber.BackColor = System.Drawing.Color.White;
            this.btnRubber.Image = global::Лаба8.Properties.Resources.ластик;
            this.btnRubber.Location = new System.Drawing.Point(3, 236);
            this.btnRubber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRubber.Name = "btnRubber";
            this.btnRubber.Size = new System.Drawing.Size(50, 50);
            this.btnRubber.TabIndex = 5;
            this.btnRubber.UseVisualStyleBackColor = false;
            this.btnRubber.Click += new System.EventHandler(this.BtnRubber_Click);
            this.btnRubber.Enter += new System.EventHandler(this.BtnTool_Enter);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.White;
            this.btnRectangle.Image = global::Лаба8.Properties.Resources.прямоугольник_;
            this.btnRectangle.Location = new System.Drawing.Point(3, 178);
            this.btnRectangle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(50, 50);
            this.btnRectangle.TabIndex = 3;
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.BtnRubber_Click);
            this.btnRectangle.Enter += new System.EventHandler(this.BtnTool_Enter);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackColor = System.Drawing.Color.White;
            this.btnEllipse.Image = global::Лаба8.Properties.Resources.элипс;
            this.btnEllipse.Location = new System.Drawing.Point(3, 120);
            this.btnEllipse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(50, 50);
            this.btnEllipse.TabIndex = 2;
            this.btnEllipse.UseVisualStyleBackColor = false;
            this.btnEllipse.Click += new System.EventHandler(this.BtnRubber_Click);
            this.btnEllipse.Enter += new System.EventHandler(this.BtnTool_Enter);
            // 
            // btnPencil
            // 
            this.btnPencil.BackColor = System.Drawing.Color.White;
            this.btnPencil.Image = global::Лаба8.Properties.Resources.карандаш32;
            this.btnPencil.Location = new System.Drawing.Point(3, 4);
            this.btnPencil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(50, 50);
            this.btnPencil.TabIndex = 1;
            this.btnPencil.UseVisualStyleBackColor = false;
            this.btnPencil.Click += new System.EventHandler(this.BtnRubber_Click);
            this.btnPencil.Enter += new System.EventHandler(this.BtnTool_Enter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnRubber, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnPencil, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnLine, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnEllipse, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnTest, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnRectangle, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnTriangle, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnFill, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(57, 662);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // FormTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(120, 673);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Инструменты";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPencil;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnRubber;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}