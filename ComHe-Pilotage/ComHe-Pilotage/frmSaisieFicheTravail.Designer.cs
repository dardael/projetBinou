namespace ComHe_Pilotage {
    partial class frmSaisieFicheTravail {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pmcCreationFicheTravail1 = new ComHe_Pilotage.pmcCreationFicheTravail();
            this.SuspendLayout();
            // 
            // pmcCreationFicheTravail1
            // 
            this.pmcCreationFicheTravail1.ficheTravailCourante = null;
            this.pmcCreationFicheTravail1.Location = new System.Drawing.Point(12, 12);
            this.pmcCreationFicheTravail1.Name = "pmcCreationFicheTravail1";
            this.pmcCreationFicheTravail1.Size = new System.Drawing.Size(316, 87);
            this.pmcCreationFicheTravail1.TabIndex = 0;
            // 
            // frmSaisieFicheTravail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 110);
            this.Controls.Add(this.pmcCreationFicheTravail1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSaisieFicheTravail";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fiche de travail";
            this.ResumeLayout(false);

        }

        #endregion

        private pmcCreationFicheTravail pmcCreationFicheTravail1;
    }
}