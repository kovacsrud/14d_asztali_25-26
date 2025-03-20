namespace WinFormsPelda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cimke = new Label();
            gomb = new Button();
            label1 = new Label();
            textBoxSzam1 = new TextBox();
            textBoxSzam2 = new TextBox();
            label2 = new Label();
            labelEredmeny = new Label();
            SuspendLayout();
            // 
            // cimke
            // 
            cimke.AutoSize = true;
            cimke.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            cimke.ForeColor = SystemColors.Desktop;
            cimke.Location = new Point(202, 154);
            cimke.Name = "cimke";
            cimke.Size = new Size(108, 37);
            cimke.TabIndex = 0;
            cimke.Text = "Szám2:";
            // 
            // gomb
            // 
            gomb.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gomb.Location = new Point(340, 376);
            gomb.Name = "gomb";
            gomb.Size = new Size(122, 38);
            gomb.TabIndex = 1;
            gomb.Text = "Gomb";
            gomb.UseVisualStyleBackColor = true;
            gomb.Click += gomb_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(202, 89);
            label1.Name = "label1";
            label1.Size = new Size(108, 37);
            label1.TabIndex = 2;
            label1.Text = "Szám1:";
            // 
            // textBoxSzam1
            // 
            textBoxSzam1.Font = new Font("Segoe UI", 16F);
            textBoxSzam1.Location = new Point(367, 92);
            textBoxSzam1.Name = "textBoxSzam1";
            textBoxSzam1.Size = new Size(223, 36);
            textBoxSzam1.TabIndex = 3;
            // 
            // textBoxSzam2
            // 
            textBoxSzam2.Font = new Font("Segoe UI", 16F);
            textBoxSzam2.Location = new Point(367, 157);
            textBoxSzam2.Name = "textBoxSzam2";
            textBoxSzam2.Size = new Size(223, 36);
            textBoxSzam2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(158, 300);
            label2.Name = "label2";
            label2.Size = new Size(152, 37);
            label2.TabIndex = 5;
            label2.Text = "Eredmény:";
            // 
            // labelEredmeny
            // 
            labelEredmeny.AutoSize = true;
            labelEredmeny.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelEredmeny.ForeColor = SystemColors.Desktop;
            labelEredmeny.Location = new Point(367, 300);
            labelEredmeny.MaximumSize = new Size(223, 0);
            labelEredmeny.MinimumSize = new Size(223, 0);
            labelEredmeny.Name = "labelEredmeny";
            labelEredmeny.Size = new Size(223, 37);
            labelEredmeny.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelEredmeny);
            Controls.Add(label2);
            Controls.Add(textBoxSzam2);
            Controls.Add(textBoxSzam1);
            Controls.Add(label1);
            Controls.Add(gomb);
            Controls.Add(cimke);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cimke;
        private Button gomb;
        private Label label1;
        private TextBox textBoxSzam1;
        private TextBox textBoxSzam2;
        private Label label2;
        private Label labelEredmeny;
    }
}
