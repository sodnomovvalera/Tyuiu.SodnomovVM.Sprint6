
namespace Tyuiu.SodnomovVM.Sprint6.Task0.V3
{
    partial class Form1
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
            this.Poyasneniye = new System.Windows.Forms.Label();
            this.textVirazheniye = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.Infa2 = new System.Windows.Forms.Label();
            this.buttonResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Poyasneniye
            // 
            this.Poyasneniye.AutoSize = true;
            this.Poyasneniye.Location = new System.Drawing.Point(12, 9);
            this.Poyasneniye.Name = "Poyasneniye";
            this.Poyasneniye.Size = new System.Drawing.Size(204, 13);
            this.Poyasneniye.TabIndex = 0;
            this.Poyasneniye.Text = "Дано выражение. Посчитать при  x = 3";
            this.Poyasneniye.Click += new System.EventHandler(this.label1_Click);
            // 
            // textVirazheniye
            // 
            this.textVirazheniye.Location = new System.Drawing.Point(248, 6);
            this.textVirazheniye.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.textVirazheniye.Name = "textVirazheniye";
            this.textVirazheniye.Size = new System.Drawing.Size(330, 20);
            this.textVirazheniye.TabIndex = 1;
            this.textVirazheniye.Text = "y(x) = (4x*x*x)/(x*x*x - 1)";
            this.textVirazheniye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(15, 64);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 2;
            // 
            // Infa2
            // 
            this.Infa2.AutoSize = true;
            this.Infa2.Location = new System.Drawing.Point(12, 28);
            this.Infa2.Name = "Infa2";
            this.Infa2.Size = new System.Drawing.Size(62, 13);
            this.Infa2.TabIndex = 3;
            this.Infa2.Text = "Результат:";
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(141, 61);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(75, 23);
            this.buttonResult.TabIndex = 4;
            this.buttonResult.Text = "Посчитать";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 351);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.Infa2);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textVirazheniye);
            this.Controls.Add(this.Poyasneniye);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Poyasneniye;
        private System.Windows.Forms.TextBox textVirazheniye;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label Infa2;
        private System.Windows.Forms.Button buttonResult;
    }
}

