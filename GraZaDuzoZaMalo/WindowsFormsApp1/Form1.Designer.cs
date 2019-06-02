namespace WindowsFormsApp1
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
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.ZakresOd = new System.Windows.Forms.Label();
            this.textBoxOd = new System.Windows.Forms.TextBox();
            this.ZakresDo = new System.Windows.Forms.Label();
            this.textBoxDo = new System.Windows.Forms.TextBox();
            this.Losuj = new System.Windows.Forms.Button();
            this.labelLosowanie = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.AccessibleName = "Nowa gra";
            this.buttonNowaGra.Location = new System.Drawing.Point(12, 12);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(75, 23);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            // 
            // ZakresOd
            // 
            this.ZakresOd.AutoSize = true;
            this.ZakresOd.Location = new System.Drawing.Point(25, 26);
            this.ZakresOd.Name = "ZakresOd";
            this.ZakresOd.Size = new System.Drawing.Size(58, 13);
            this.ZakresOd.TabIndex = 1;
            this.ZakresOd.Text = "Zakres od:";
            // 
            // textBoxOd
            // 
            this.textBoxOd.Location = new System.Drawing.Point(89, 26);
            this.textBoxOd.Name = "textBoxOd";
            this.textBoxOd.Size = new System.Drawing.Size(100, 20);
            this.textBoxOd.TabIndex = 2;
            // 
            // ZakresDo
            // 
            this.ZakresDo.AutoSize = true;
            this.ZakresDo.Location = new System.Drawing.Point(25, 58);
            this.ZakresDo.Name = "ZakresDo";
            this.ZakresDo.Size = new System.Drawing.Size(58, 13);
            this.ZakresDo.TabIndex = 3;
            this.ZakresDo.Text = "Zakres od:";
            // 
            // textBoxDo
            // 
            this.textBoxDo.Location = new System.Drawing.Point(89, 58);
            this.textBoxDo.Name = "textBoxDo";
            this.textBoxDo.Size = new System.Drawing.Size(100, 20);
            this.textBoxDo.TabIndex = 4;
            // 
            // Losuj
            // 
            this.Losuj.Location = new System.Drawing.Point(215, 58);
            this.Losuj.Name = "Losuj";
            this.Losuj.Size = new System.Drawing.Size(75, 23);
            this.Losuj.TabIndex = 5;
            this.Losuj.Text = "Wylosuj";
            this.Losuj.UseVisualStyleBackColor = true;
            // 
            // labelLosowanie
            // 
            this.labelLosowanie.AutoSize = true;
            this.labelLosowanie.Location = new System.Drawing.Point(8, 4);
            this.labelLosowanie.Name = "labelLosowanie";
            this.labelLosowanie.Size = new System.Drawing.Size(58, 13);
            this.labelLosowanie.TabIndex = 6;
            this.labelLosowanie.Text = "Losowanie";
            this.labelLosowanie.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelLosowanie);
            this.groupBox1.Controls.Add(this.Losuj);
            this.groupBox1.Controls.Add(this.textBoxDo);
            this.groupBox1.Controls.Add(this.ZakresDo);
            this.groupBox1.Controls.Add(this.textBoxOd);
            this.groupBox1.Controls.Add(this.ZakresOd);
            this.groupBox1.Location = new System.Drawing.Point(4, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 111);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.Label ZakresOd;
        private System.Windows.Forms.TextBox textBoxOd;
        private System.Windows.Forms.Label ZakresDo;
        private System.Windows.Forms.TextBox textBoxDo;
        private System.Windows.Forms.Button Losuj;
        private System.Windows.Forms.Label labelLosowanie;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

