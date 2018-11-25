namespace Projet_binou
{
    partial class frmPincipale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPincipale));
            this.tabCtrlPrincipale = new System.Windows.Forms.TabControl();
            this.tabPgRenseignements = new System.Windows.Forms.TabPage();
            this.panRenseignements = new System.Windows.Forms.Panel();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.tabCtrlPrincipale.SuspendLayout();
            this.tabPgRenseignements.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrlPrincipale
            // 
            this.tabCtrlPrincipale.Controls.Add(this.tabPgRenseignements);
            this.tabCtrlPrincipale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlPrincipale.Location = new System.Drawing.Point(0, 0);
            this.tabCtrlPrincipale.Name = "tabCtrlPrincipale";
            this.tabCtrlPrincipale.SelectedIndex = 0;
            this.tabCtrlPrincipale.Size = new System.Drawing.Size(800, 450);
            this.tabCtrlPrincipale.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabCtrlPrincipale.TabIndex = 0;
            // 
            // tabPgRenseignements
            // 
            this.tabPgRenseignements.Controls.Add(this.panRenseignements);
            this.tabPgRenseignements.Location = new System.Drawing.Point(4, 25);
            this.tabPgRenseignements.Name = "tabPgRenseignements";
            this.tabPgRenseignements.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgRenseignements.Size = new System.Drawing.Size(792, 421);
            this.tabPgRenseignements.TabIndex = 1;
            this.tabPgRenseignements.Text = "Renseignements";
            this.tabPgRenseignements.UseVisualStyleBackColor = true;
            // 
            // panRenseignements
            // 
            this.panRenseignements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panRenseignements.Location = new System.Drawing.Point(3, 3);
            this.panRenseignements.Name = "panRenseignements";
            this.panRenseignements.Size = new System.Drawing.Size(786, 415);
            this.panRenseignements.TabIndex = 0;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Fichier";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "Options";
            // 
            // frmPincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabCtrlPrincipale);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "frmPincipale";
            this.Text = "Projet Montagne";
            this.tabCtrlPrincipale.ResumeLayout(false);
            this.tabPgRenseignements.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlPrincipale;
        private System.Windows.Forms.TabPage tabPgRenseignements;
        private System.Windows.Forms.Panel panRenseignements;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
    }
}

