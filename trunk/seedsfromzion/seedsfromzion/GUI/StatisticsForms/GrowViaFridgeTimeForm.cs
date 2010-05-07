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
    public partial class GrowViaFridgeTimeForm : seedsfromzion.GUI.BaseForm
    {
        public GrowViaFridgeTimeForm()
        {
            InitializeComponent();
        }

        private void GrowViaFridgeTime_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);
            this.GrowViaFridgeGraphControl_Load(sender, e);
        }

        private void GrowViaFridgeGraphControl_Load(object sender, EventArgs e)
        {
            GraphPane growGraphPane = this.GrowViaFridgeGraphControl.GraphPane;
            DataTable graphData = StatisticsManager.getGrowViaFridgeGraphValues();
            growGraphPane.Title.Text = "גרף אחוזי הנביטה לפי זמן שהיה במקרר";
            growGraphPane.XAxis.Title.Text = "זמן שהיה  במקרר";
            growGraphPane.YAxis.Title.Text = "אחוזי הנביטה";

            //set the values of the bars
            PointPairList list = StatisticsManager.buildPairListFromGraphData<DateTime, double>(graphData, "sowingDate", "sproutingPerc");

            //create the bar
            BarItem myCurve = growGraphPane.AddBar("Plant 'Plant'", list, Color.Blue);

            // Draw the X tics between the labels instead of at the labels
            growGraphPane.XAxis.MajorTic.IsBetweenLabels = false;

            // Set the XAxis labels
            //growGraphPane.XAxis.Scale = DateTime;

            // Set the XAxis to Date type
            growGraphPane.XAxis.Type = AxisType.DateAsOrdinal;
            growGraphPane.XAxis.Scale.Format = "yyyy-MMM-dd";

            //set background color
            growGraphPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 45.0F);

            // disable the legend
            growGraphPane.Legend.IsVisible = false;

            // expand the range of the Y axis slightly to accommodate the labels
            //growGraphPane.YAxis.Scale.Max += growGraphPane.YAxis.Scale.MajorStep;

            // Create TextObj's to provide labels for each bar
            BarItem.CreateBarLabels(growGraphPane, false, "f2");

            //recalculate graph
            growGraphPane.AxisChange();
        }
    }
}
