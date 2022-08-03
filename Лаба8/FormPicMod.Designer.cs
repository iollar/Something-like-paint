namespace Лаба8
{
    partial class FormPicMod
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numScale = new System.Windows.Forms.NumericUpDown();
            this.btnDiv2 = new System.Windows.Forms.Button();
            this.btnMult2 = new System.Windows.Forms.Button();
            this.lbSize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numScale)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Масштаб";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Размер изображения:";
            // 
            // numScale
            // 
            this.numScale.Enabled = false;
            this.numScale.ImeMode = System.Windows.Forms.ImeMode.On;
            this.numScale.Location = new System.Drawing.Point(71, 104);
            this.numScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numScale.Name = "numScale";
            this.numScale.Size = new System.Drawing.Size(58, 20);
            this.numScale.TabIndex = 2;
            this.numScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numScale.ValueChanged += new System.EventHandler(this.NumScale_ValueChanged);
            // 
            // btnDiv2
            // 
            this.btnDiv2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDiv2.Enabled = false;
            this.btnDiv2.Location = new System.Drawing.Point(121, 34);
            this.btnDiv2.Name = "btnDiv2";
            this.btnDiv2.Size = new System.Drawing.Size(100, 23);
            this.btnDiv2.TabIndex = 3;
            this.btnDiv2.Text = "увеличить х2";
            this.btnDiv2.UseVisualStyleBackColor = false;
            // 
            // btnMult2
            // 
            this.btnMult2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMult2.Enabled = false;
            this.btnMult2.Location = new System.Drawing.Point(15, 34);
            this.btnMult2.Name = "btnMult2";
            this.btnMult2.Size = new System.Drawing.Size(100, 23);
            this.btnMult2.TabIndex = 4;
            this.btnMult2.Text = "уменьшить х2";
            this.btnMult2.UseVisualStyleBackColor = false;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(135, 18);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(0, 13);
            this.lbSize.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кол-во цветов:";
            // 
            // FormPicMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 164);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.btnMult2);
            this.Controls.Add(this.btnDiv2);
            this.Controls.Add(this.numScale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormPicMod";
            this.Text = "Настройки изображения";
            ((System.ComponentModel.ISupportInitialize)(this.numScale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numScale;
        private System.Windows.Forms.Button btnDiv2;
        private System.Windows.Forms.Button btnMult2;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label label3;
    }
}