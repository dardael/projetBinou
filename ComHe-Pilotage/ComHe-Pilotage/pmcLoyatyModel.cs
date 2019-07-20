namespace ComHe_Pilotage {
    using ComHe_Metier;
    using ComHe_Objets;
    using DevExpress.XtraCharts;
    using DevExpress.XtraDiagram.Utils;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    public partial class pmcLoyatyModel : pmcParentUtilisantFicheDeTravail {
        public pmcLoyatyModel() {
            InitializeComponent();
            chLoyaltyModel.RegisterSummaryFunction(
            name: "CERTAINEMENT",
            displayName: "Certainement",
            resultScaleType: ScaleType.Numerical,
            resultDimension: 1,
            argumentDescriptions: new SummaryFunctionArgumentDescription[] {
                    new SummaryFunctionArgumentDescription("noteSatisfaction", ScaleType.Numerical)
            },
            function: calculerCertainement
            );

            chLoyaltyModel.Series[0].SummaryFunction = "CERTAINEMENT([noteSatisfaction])";
        }

        protected override void gererChangementFicheCourante() {
            if (fiche != null && (fiche.loyaltyModel == null || fiche.loyaltyModel.Count == 0)) {
                fiche.loyaltyModel = LoyaltyModelBO.getLoyaltyModel();
            }
            populateGrid();
            populateCh();
        }

        private void populateGrid() {
            grLoyaltyModel.BeginUpdate();
            try {
                grLoyaltyModel.DataSource = ficheCourante.loyaltyModel;
            }
            finally {
                grLoyaltyModel.EndUpdate();

            }
        }

        private void populateCh() {
            chLoyaltyModel.DataSource = ficheCourante.loyaltyModel;
            chLoyaltyModel.Refresh();
        }

        private void grLoyaltyModel_EditValueChanged(object sender, DevExpress.XtraPivotGrid.EditValueChangedEventArgs e) {
            fiche.loyaltyModel.Where(delegate (ItemLoyaltyModel x) {
                return x.noteLoyaute == e.RowFieldIndex && x.noteSatisfaction == e.ColumnIndex;
            }).First().nbPersonnes = (Decimal.ToInt32((decimal)e.Editor.EditValue));
            grLoyaltyModel.RefreshData();
        }

        private static SeriesPoint[] calculerCertainement(Series series, object argument, string[] functionArguments, DataSourceValues[] values, object[] colors) {
            int noteSatisfaction = Convert.ToInt32((double)argument);
            List<ItemLoyaltyModel> valeursConcernees = values.Select(delegate (DataSourceValues x) {
                return (ItemLoyaltyModel)x.First().Value;
            }).Where(delegate (ItemLoyaltyModel x) {
                return x.noteSatisfaction == noteSatisfaction;
            }).ToList();
            double diviseur = valeursConcernees.Sum(delegate (ItemLoyaltyModel x) {
                return x.nbPersonnes;
            });
            double valeur = diviseur > 0 ? (valeursConcernees.Where(delegate (ItemLoyaltyModel x) {
                return x.noteLoyaute > 8;
            }).Sum(delegate (ItemLoyaltyModel x) {
                return x.nbPersonnes;
            }) / diviseur) * 100 : 0;

            // Return the result.  
            return new SeriesPoint[] {
        new SeriesPoint(argument, valeur)
    };
        }
    }
}
