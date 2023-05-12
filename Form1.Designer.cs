namespace HanoiTowers
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.animace = new System.Windows.Forms.Timer(this.components);
            this.lblSouradniceCervena = new System.Windows.Forms.Label();
            this.lblSouradniceOranzova = new System.Windows.Forms.Label();
            this.lblSouradniceZelena = new System.Windows.Forms.Label();
            this.btnPlayAnim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // animace
            // 
            this.animace.Interval = 10;
            this.animace.Tick += new System.EventHandler(this.animace_Tick);
            // 
            // lblSouradniceCervena
            // 
            this.lblSouradniceCervena.AutoSize = true;
            this.lblSouradniceCervena.Location = new System.Drawing.Point(659, 9);
            this.lblSouradniceCervena.Name = "lblSouradniceCervena";
            this.lblSouradniceCervena.Size = new System.Drawing.Size(98, 13);
            this.lblSouradniceCervena.TabIndex = 0;
            this.lblSouradniceCervena.Text = "Červený blok: [X;Y]";
            // 
            // lblSouradniceOranzova
            // 
            this.lblSouradniceOranzova.AutoSize = true;
            this.lblSouradniceOranzova.Location = new System.Drawing.Point(653, 22);
            this.lblSouradniceOranzova.Name = "lblSouradniceOranzova";
            this.lblSouradniceOranzova.Size = new System.Drawing.Size(104, 13);
            this.lblSouradniceOranzova.TabIndex = 1;
            this.lblSouradniceOranzova.Text = "Oranžový blok: [X;Y]";
            // 
            // lblSouradniceZelena
            // 
            this.lblSouradniceZelena.AutoSize = true;
            this.lblSouradniceZelena.Location = new System.Drawing.Point(666, 35);
            this.lblSouradniceZelena.Name = "lblSouradniceZelena";
            this.lblSouradniceZelena.Size = new System.Drawing.Size(91, 13);
            this.lblSouradniceZelena.TabIndex = 2;
            this.lblSouradniceZelena.Text = "Zelený blok: [X;Y]";
            // 
            // btnPlayAnim
            // 
            this.btnPlayAnim.Location = new System.Drawing.Point(690, 415);
            this.btnPlayAnim.Name = "btnPlayAnim";
            this.btnPlayAnim.Size = new System.Drawing.Size(98, 23);
            this.btnPlayAnim.TabIndex = 3;
            this.btnPlayAnim.Text = "Přehraj animaci";
            this.btnPlayAnim.UseVisualStyleBackColor = true;
            this.btnPlayAnim.Click += new System.EventHandler(this.btnPlayAnim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlayAnim);
            this.Controls.Add(this.lblSouradniceZelena);
            this.Controls.Add(this.lblSouradniceOranzova);
            this.Controls.Add(this.lblSouradniceCervena);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Hanoi Towers";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer animace;
        private System.Windows.Forms.Label lblSouradniceCervena;
        private System.Windows.Forms.Label lblSouradniceOranzova;
        private System.Windows.Forms.Label lblSouradniceZelena;
        private System.Windows.Forms.Button btnPlayAnim;
    }
}

