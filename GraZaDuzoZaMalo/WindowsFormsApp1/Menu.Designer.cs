namespace GraGUI
{
    public partial class Menu
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
            this.ButtonRunGame = new System.Windows.Forms.Button();
            this.ButtonAboutMe = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Za Dużo - Za Mało";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ButtonRunGame
            // 
            this.ButtonRunGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonRunGame.Location = new System.Drawing.Point(65, 109);
            this.ButtonRunGame.Name = "ButtonRunGame";
            this.ButtonRunGame.Size = new System.Drawing.Size(199, 71);
            this.ButtonRunGame.TabIndex = 1;
            this.ButtonRunGame.TabStop = false;
            this.ButtonRunGame.Text = "Uruchom grę";
            this.ButtonRunGame.UseVisualStyleBackColor = true;
            this.ButtonRunGame.Click += new System.EventHandler(this.ButtonRunGame_Click);
            // 
            // ButtonAboutMe
            // 
            this.ButtonAboutMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonAboutMe.Location = new System.Drawing.Point(65, 204);
            this.ButtonAboutMe.Name = "ButtonAboutMe";
            this.ButtonAboutMe.Size = new System.Drawing.Size(199, 71);
            this.ButtonAboutMe.TabIndex = 2;
            this.ButtonAboutMe.TabStop = false;
            this.ButtonAboutMe.Text = "Autorzy";
            this.ButtonAboutMe.UseVisualStyleBackColor = true;
            this.ButtonAboutMe.Click += new System.EventHandler(this.ButtonAboutMe_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonExit.Location = new System.Drawing.Point(65, 318);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(199, 71);
            this.ButtonExit.TabIndex = 3;
            this.ButtonExit.TabStop = false;
            this.ButtonExit.Text = "Wyjdź z gry";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // Menu
            // 
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonAboutMe);
            this.Controls.Add(this.ButtonRunGame);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Sakovsky - Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonRunGame;
        private System.Windows.Forms.Button ButtonAboutMe;
        private System.Windows.Forms.Button ButtonExit;
    }
}