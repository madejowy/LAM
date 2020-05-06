namespace LAM
{
    partial class Lam
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.gameControl1 = new LAM.GameControl();
            this.aboutControl1 = new LAM.AboutControl();
            this.SuspendLayout();
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(40, 260);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(120, 80);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "About Game";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(40, 150);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 80);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Magneto", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(213, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(873, 117);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Lose A Million";
            // 
            // gameControl1
            // 
            this.gameControl1.AllQuestions = null;
            this.gameControl1.Correct = 0;
            this.gameControl1.CurrentRound = 0;
            this.gameControl1.Location = new System.Drawing.Point(200, 100);
            this.gameControl1.Money = 0;
            this.gameControl1.Name = "gameControl1";
            this.gameControl1.Size = new System.Drawing.Size(900, 600);
            this.gameControl1.TabIndex = 0;
            this.gameControl1.Trap1 = 0;
            this.gameControl1.Trap2 = 0;
            this.gameControl1.Trap3 = 0;
            this.gameControl1.Trap4 = 0;
            this.gameControl1.Visible = false;
            // 
            // aboutControl1
            // 
            this.aboutControl1.Location = new System.Drawing.Point(200, 100);
            this.aboutControl1.Name = "aboutControl1";
            this.aboutControl1.Size = new System.Drawing.Size(900, 600);
            this.aboutControl1.TabIndex = 6;
            this.aboutControl1.Visible = false;
            // 
            // Lam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gameControl1);
            this.Controls.Add(this.aboutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Lam";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GameControl gameControl1;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnStart;
        private AboutControl aboutControl1;
        private System.Windows.Forms.Label lblName;
    }
}

