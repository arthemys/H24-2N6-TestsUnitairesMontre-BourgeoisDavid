namespace ApplicationMontre
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form
        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtAffichageMontre = new System.Windows.Forms.TextBox();
            this.btnAvancer = new System.Windows.Forms.Button();
            this.tmrHorloge = new System.Windows.Forms.Timer(this.components);
            this.btnDemarrerArreterHorloge = new System.Windows.Forms.Button();
            this.btnInitialiserMontre = new System.Windows.Forms.Button();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAffichageMontre
            // 
            this.txtAffichageMontre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAffichageMontre.Location = new System.Drawing.Point(53, 41);
            this.txtAffichageMontre.Name = "txtAffichageMontre";
            this.txtAffichageMontre.ReadOnly = true;
            this.txtAffichageMontre.Size = new System.Drawing.Size(221, 35);
            this.txtAffichageMontre.TabIndex = 0;
            this.txtAffichageMontre.TabStop = false;
            this.txtAffichageMontre.Text = "0:00:00";
            this.txtAffichageMontre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAvancer
            // 
            this.btnAvancer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvancer.Location = new System.Drawing.Point(52, 83);
            this.btnAvancer.Name = "btnAvancer";
            this.btnAvancer.Size = new System.Drawing.Size(221, 32);
            this.btnAvancer.TabIndex = 1;
            this.btnAvancer.Text = "Avancer d\'une seconde";
            this.btnAvancer.Click += new System.EventHandler(this.btnAvancer_Click);
            // 
            // tmrHorloge
            // 
            this.tmrHorloge.Interval = 1000;
            this.tmrHorloge.Tick += new System.EventHandler(this.btnAvancer_Click);
            // 
            // btnDemarrerArreterHorloge
            // 
            this.btnDemarrerArreterHorloge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemarrerArreterHorloge.Location = new System.Drawing.Point(52, 171);
            this.btnDemarrerArreterHorloge.Name = "btnDemarrerArreterHorloge";
            this.btnDemarrerArreterHorloge.Size = new System.Drawing.Size(221, 32);
            this.btnDemarrerArreterHorloge.TabIndex = 3;
            this.btnDemarrerArreterHorloge.Text = "Démarrer/Arrêter";
            this.btnDemarrerArreterHorloge.Click += new System.EventHandler(this.btnDemarrerArreterHorloge_Click);
            // 
            // btnInitialiserMontre
            // 
            this.btnInitialiserMontre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitialiserMontre.Location = new System.Drawing.Point(52, 127);
            this.btnInitialiserMontre.Name = "btnInitialiserMontre";
            this.btnInitialiserMontre.Size = new System.Drawing.Size(221, 32);
            this.btnInitialiserMontre.TabIndex = 2;
            this.btnInitialiserMontre.Text = "Initialiser à 59:59:59";
            this.btnInitialiserMontre.Click += new System.EventHandler(this.btnInitialiserMontre_Click);
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(329, 24);
            this.mnuPrincipal.TabIndex = 4;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Text = "Fichier";
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(154, 22);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // FrmPrincipal
            // 
            this.AcceptButton = this.btnAvancer;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(329, 224);
            this.Controls.Add(this.btnInitialiserMontre);
            this.Controls.Add(this.btnDemarrerArreterHorloge);
            this.Controls.Add(this.btnAvancer);
            this.Controls.Add(this.txtAffichageMontre);
            this.Controls.Add(this.mnuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExD3 : Montre ";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.TextBox txtAffichageMontre;
        private System.Windows.Forms.Button btnAvancer;
        private System.Windows.Forms.Timer tmrHorloge;
        private System.Windows.Forms.Button btnDemarrerArreterHorloge;
        private System.Windows.Forms.Button btnInitialiserMontre;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
    }
}

