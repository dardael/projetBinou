using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComHe_Objets;
using DevExpress.XtraCharts;

namespace ComHe_Pilotage {
    public partial class pmcAttributsDeSatisfaction : pmcParentUtilisantFicheDeTravail {
        public pmcAttributsDeSatisfaction() {
            InitializeComponent();
            gcAttributsDeSatisfaction.DataSource = new List<AttributDeSatisfaction>();
            chAttributsDeSatisfaction.DataSource = new List<AttributDeSatisfaction>();
        }
        private void repoBtSupprimer_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            AttributDeSatisfaction attributCourant = (AttributDeSatisfaction)gvAttributsDeSatisfaction.GetRow(gvAttributsDeSatisfaction.FocusedRowHandle);
            ficheCourante.attibutsDeSatisfaction.Remove(attributCourant);
            gererChangementFicheCourante();
        }
        protected override void gererChangementFicheCourante() {
            if (fiche != null) {
                populateGridAttributs();
                populateChAttributs();
            }
        }
        private void populateGridAttributs() {
            gcAttributsDeSatisfaction.BeginUpdate();
            try {
                gcAttributsDeSatisfaction.DataSource = ficheCourante.attibutsDeSatisfaction;
            }
            finally {
                gcAttributsDeSatisfaction.EndUpdate();
            }
        }
        private void btAjouter_Click(object sender, EventArgs e) {
            fiche.attibutsDeSatisfaction.Add(new AttributDeSatisfaction());
            gererChangementFicheCourante();
        }
        private void populateChAttributs() {
            chAttributsDeSatisfaction.DataSource = new List<AttributDeSatisfaction>(ficheCourante.attibutsDeSatisfaction);
            chAttributsDeSatisfaction.Refresh();
        }
        private void chAttributsDeSatisfaction_CustomDrawAxisLabel(object sender, DevExpress.XtraCharts.CustomDrawAxisLabelEventArgs e) {
            AxisBase axis = e.Item.Axis;
            try {
                if (axis is AxisX) {
                    string value = (string)e.Item.AxisValue;
                    e.Item.Text = ficheCourante.attibutsDeSatisfaction.Where(attribut => attribut.id.ToString() == value).First().nom;
                }
            }
            catch {
                //gerer erreur 
            }
        }
        private void chAttributsDeSatisfaction_CustomDrawCrosshair(object sender, CustomDrawCrosshairEventArgs e) {
            foreach (CrosshairElementGroup element in e.CrosshairElementGroups) {
                foreach (CrosshairElement elt in element.CrosshairElements) {
                    SeriesPoint currentPoint = elt.SeriesPoint;
                    if (currentPoint.Tag.GetType() == typeof(AttributDeSatisfaction)) {
                        AttributDeSatisfaction rowView = (AttributDeSatisfaction)currentPoint.Tag;
                        string s = (elt.Series.Name == "Satisfaction" ? "Satisfaction: " + rowView.impactSurSatisfaction : "Insatisfaction: " + rowView.impactSurInsatisfactionAAfficher);
                        elt.LabelElement.Text = s;
                        element.HeaderElement.Text = rowView.nom;
                    }
                }
            }
        }

    }
}
