namespace GraGUI
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
            this.groupBoxLosuj = new System.Windows.Forms.GroupBox();
            this.buttonLosuj = new System.Windows.Forms.Button();
            this.textBoxDo = new System.Windows.Forms.TextBox();
            this.labelDo = new System.Windows.Forms.Label();
            this.textBoxOd = new System.Windows.Forms.TextBox();
            this.labelOd = new System.Windows.Forms.Label();
            this.labelStartInfo = new System.Windows.Forms.Label();
            this.labelPropozycja = new System.Windows.Forms.Label();
            this.textBoxCheck = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.groupBoxGra = new System.Windows.Forms.GroupBox();
            this.buttonGiveUp = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelOcena = new System.Windows.Forms.Label();
            this.labelCounter = new System.Windows.Forms.Label();
            this.groupBoxLosuj.SuspendLayout();
            this.groupBoxGra.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(13, 13);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(75, 23);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // groupBoxLosuj
            // 
            this.groupBoxLosuj.Controls.Add(this.buttonLosuj);
            this.groupBoxLosuj.Controls.Add(this.textBoxDo);
            this.groupBoxLosuj.Controls.Add(this.labelDo);
            this.groupBoxLosuj.Controls.Add(this.textBoxOd);
            this.groupBoxLosuj.Controls.Add(this.labelOd);
            this.groupBoxLosuj.Location = new System.Drawing.Point(13, 52);
            this.groupBoxLosuj.Name = "groupBoxLosuj";
            this.groupBoxLosuj.Size = new System.Drawing.Size(302, 100);
            this.groupBoxLosuj.TabIndex = 1;
            this.groupBoxLosuj.TabStop = false;
            this.groupBoxLosuj.Text = "Losowanie";
            this.groupBoxLosuj.Visible = false;
            // 
            // buttonLosuj
            // 
            this.buttonLosuj.Location = new System.Drawing.Point(207, 40);
            this.buttonLosuj.Name = "buttonLosuj";
            this.buttonLosuj.Size = new System.Drawing.Size(75, 23);
            this.buttonLosuj.TabIndex = 2;
            this.buttonLosuj.Text = "Wylosuj";
            this.buttonLosuj.UseVisualStyleBackColor = true;
            this.buttonLosuj.Click += new System.EventHandler(this.buttonLosuj_Click);
            // 
            // textBoxDo
            // 
            this.textBoxDo.Location = new System.Drawing.Point(82, 63);
            this.textBoxDo.Name = "textBoxDo";
            this.textBoxDo.Size = new System.Drawing.Size(100, 20);
            this.textBoxDo.TabIndex = 3;
            // 
            // labelDo
            // 
            this.labelDo.AutoSize = true;
            this.labelDo.Location = new System.Drawing.Point(17, 66);
            this.labelDo.Name = "labelDo";
            this.labelDo.Size = new System.Drawing.Size(58, 13);
            this.labelDo.TabIndex = 2;
            this.labelDo.Text = "Zakres do:";
            // 
            // textBoxOd
            // 
            this.textBoxOd.Location = new System.Drawing.Point(82, 17);
            this.textBoxOd.Name = "textBoxOd";
            this.textBoxOd.Size = new System.Drawing.Size(100, 20);
            this.textBoxOd.TabIndex = 1;
            // 
            // labelOd
            // 
            this.labelOd.AutoSize = true;
            this.labelOd.Location = new System.Drawing.Point(18, 20);
            this.labelOd.Name = "labelOd";
            this.labelOd.Size = new System.Drawing.Size(58, 13);
            this.labelOd.TabIndex = 0;
            this.labelOd.Text = "Zakres od:";
            // 
            // labelStartInfo
            // 
            this.labelStartInfo.AutoSize = true;
            this.labelStartInfo.Location = new System.Drawing.Point(15, 25);
            this.labelStartInfo.Name = "labelStartInfo";
            this.labelStartInfo.Size = new System.Drawing.Size(263, 13);
            this.labelStartInfo.TabIndex = 2;
            this.labelStartInfo.Text = "Wylosowałem liczbę z podanego zakresu, odgadnij ją!";
            // 
            // labelPropozycja
            // 
            this.labelPropozycja.AutoSize = true;
            this.labelPropozycja.Location = new System.Drawing.Point(15, 58);
            this.labelPropozycja.Name = "labelPropozycja";
            this.labelPropozycja.Size = new System.Drawing.Size(91, 13);
            this.labelPropozycja.TabIndex = 3;
            this.labelPropozycja.Text = "Podaj propozycję:";
            // 
            // textBoxCheck
            // 
            this.textBoxCheck.Location = new System.Drawing.Point(112, 55);
            this.textBoxCheck.Name = "textBoxCheck";
            this.textBoxCheck.Size = new System.Drawing.Size(68, 20);
            this.textBoxCheck.TabIndex = 4;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(205, 53);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 5;
            this.buttonCheck.Text = "Sprawdź";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // groupBoxGra
            // 
            this.groupBoxGra.Controls.Add(this.labelCounter);
            this.groupBoxGra.Controls.Add(this.buttonGiveUp);
            this.groupBoxGra.Controls.Add(this.labelScore);
            this.groupBoxGra.Controls.Add(this.labelOcena);
            this.groupBoxGra.Controls.Add(this.buttonCheck);
            this.groupBoxGra.Controls.Add(this.textBoxCheck);
            this.groupBoxGra.Controls.Add(this.labelPropozycja);
            this.groupBoxGra.Controls.Add(this.labelStartInfo);
            this.groupBoxGra.Location = new System.Drawing.Point(15, 165);
            this.groupBoxGra.Name = "groupBoxGra";
            this.groupBoxGra.Size = new System.Drawing.Size(299, 199);
            this.groupBoxGra.TabIndex = 6;
            this.groupBoxGra.TabStop = false;
            this.groupBoxGra.Text = "Gra";
            this.groupBoxGra.Visible = false;
            this.groupBoxGra.Enter += new System.EventHandler(this.groupBoxGra_Enter);
            // 
            // buttonGiveUp
            // 
            this.buttonGiveUp.Location = new System.Drawing.Point(7, 170);
            this.buttonGiveUp.Name = "buttonGiveUp";
            this.buttonGiveUp.Size = new System.Drawing.Size(75, 23);
            this.buttonGiveUp.TabIndex = 0;
            this.buttonGiveUp.Text = "Poddaj się";
            this.buttonGiveUp.Click += new System.EventHandler(this.buttonGiveUp_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(60, 92);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(40, 13);
            this.labelScore.TabIndex = 7;
            this.labelScore.Text = "Wynik:";
            // 
            // labelOcena
            // 
            this.labelOcena.AutoSize = true;
            this.labelOcena.Location = new System.Drawing.Point(82, 92);
            this.labelOcena.Name = "labelOcena";
            this.labelOcena.Size = new System.Drawing.Size(0, 13);
            this.labelOcena.TabIndex = 6;
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.Location = new System.Drawing.Point(16, 121);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(206, 13);
            this.labelCounter.TabIndex = 8;
            this.labelCounter.Text = "Zanim odgadłeś odpowiedź, próbowałeś: ";
            this.labelCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCounter.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 450);
            this.Controls.Add(this.groupBoxGra);
            this.Controls.Add(this.groupBoxLosuj);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxLosuj.ResumeLayout(false);
            this.groupBoxLosuj.PerformLayout();
            this.groupBoxGra.ResumeLayout(false);
            this.groupBoxGra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox groupBoxLosuj;
        private System.Windows.Forms.Button buttonLosuj;
        private System.Windows.Forms.TextBox textBoxDo;
        private System.Windows.Forms.Label labelDo;
        private System.Windows.Forms.TextBox textBoxOd;
        private System.Windows.Forms.Label labelOd;
        private System.Windows.Forms.Label labelStartInfo;
        private System.Windows.Forms.Label labelPropozycja;
        private System.Windows.Forms.TextBox textBoxCheck;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.GroupBox groupBoxGra;
        private System.Windows.Forms.Label labelOcena;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button buttonGiveUp;
        private System.Windows.Forms.Label labelCounter;
    }
}
