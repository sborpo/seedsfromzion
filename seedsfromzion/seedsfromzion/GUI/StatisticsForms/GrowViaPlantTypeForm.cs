using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

using seedsfromzion.Managers;

namespace seedsfromzion.GUI.StatisticsForms
{
    public partial class GrowViaPlantTypeForm : seedsfromzion.GUI.BaseForm
    {
        public GrowViaPlantTypeForm(seedsFromZion mainForm)
        {
            InitializeComponent();
            mainForm.favoriteClicked += new seedsFromZion.favoriteClickedHandler(mainForm_favoriteClicked);
        }

        void mainForm_favoriteClicked(int plantId)
        {
            if (this.Created)
            {
                string plantName = StatisticsManager.getNameById(plantId);
                this.plantNameTextBox.Text = plantName;
            }
        }

        private void GrowViaPlantTypeForm_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);
            this.GrowViaTypeGraphControl_Start(sender, e);
            StatisticsManager.initPlantNames();
        }

        private void GrowViaTypeGraphControl_Start(object sender, EventArgs e)
        {
            GraphPane growGraphPane = this.GrowViaTypeGraphControl.GraphPane;
            growGraphPane.Title.Text = "גרף אחוזי הנביטה לפי סוג הצמח";
            growGraphPane.Title.FontSpec.FontColor = Color.Navy;
            growGraphPane.XAxis.Title.Text = "סוג הצמח";
            growGraphPane.YAxis.Title.Text = "אחוזי הנביטה";

            // Set the XAxis to Date type
            growGraphPane.XAxis.Type = AxisType.Text;
            growGraphPane.XAxis.Scale.IsVisible = false;

            growGraphPane.YAxis.Type = AxisType.Linear;
            growGraphPane.YAxis.Scale.FormatAuto = true;
            growGraphPane.YAxis.Scale.IsVisible = false;

            //set background color
            growGraphPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 45.0F);
        }

        private void GrowViaTypeGraphControl_Load(string plantName)
        {
            GraphPane growGraphPane = this.GrowViaTypeGraphControl.GraphPane;
            DataTable graphData = StatisticsManager.getGrowViaTypeGraphValues(plantName);
            growGraphPane.CurveList.Clear();
            growGraphPane.GraphObjList.Clear();
            //set the values of the bars
            String[] xArray = StatisticsManager.buildArrayFromGraphData<string, String>(graphData, "type");
            Double[] yArray = StatisticsManager.buildArrayFromGraphData<double, Double>(graphData, "sproutingPerc");

            if (graphData.Rows.Count.Equals(0))
            {
                new ErrorWindow("אין מידע עבור צמח שנבחר").Show();
                return;
            }

            //create the bar
            BarItem myCurve = growGraphPane.AddBar("'שם הצמח: " + "'" + plantName, null, yArray, Color.Blue);

            // Draw the X tics between the labels instead of at the labels
            growGraphPane.XAxis.MajorTic.IsBetweenLabels = false;

            // Set the XAxis to Date type
            growGraphPane.XAxis.Scale.TextLabels = xArray;

            // disable the legend
            growGraphPane.Legend.IsVisible = true;

            // Create TextObj's to provide labels for each bar
            BarItem.CreateBarLabels(growGraphPane, false, "f2");

            StatisticsManager.rotateBarLables(growGraphPane);

            //set visible scales
            growGraphPane.XAxis.Scale.IsVisible = true;
            growGraphPane.YAxis.Scale.IsVisible = true;

            //recalculate graph
            growGraphPane.AxisChange();
            this.GrowViaTypeGraphControl.Refresh();
        }


        private void showGraphButton_Click(object sender, EventArgs e)
        {
            string plantName = this.plantNameTextBox.Text;

            //check if all data was entered
            if (plantName.Length <= 0)
            {
                new ErrorWindow("שם של הצמח ריק").Show();
                return;
            }

            this.GrowViaTypeGraphControl_Load(plantName);
        }


        private void plantNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.plantNameTextBox.Text.Length > 0)
                {
                    DataRow[] rows = StatisticsManager.plantNames.Select("name LIKE '" + this.plantNameTextBox.Text + "%'");
                    if (rows.Length > 0)
                    {
                        String[] names = StatisticsManager.buildArrayFromGraphData<string, String>(rows, "name");

                        this.plantNameTextBox.AutoCompleteCustomSource.AddRange(names);
                        this.plantNameTextBox.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void plantNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back) || e.KeyChar.Equals((char)Keys.Delete)))
                e.Handled = true;
        }

    }
}
