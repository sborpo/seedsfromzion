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
        public GrowViaPlantTypeForm()
        {
            InitializeComponent();
        }

        private void GrowViaPlantTypeForm_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);
            this.GrowViaTypeGraphControl_Load(sender, e);
        }

        private void GrowViaTypeGraphControl_Load(object sender, EventArgs e)
        {
            GraphPane growGraphPane = this.GrowViaTypeGraphControl.GraphPane;
            DataTable graphData = StatisticsManager.getGrowViaTypeGraphValues();
            growGraphPane.Title.Text = "גרף אחוזי הנביטה לפי סוג הצמח";
            growGraphPane.XAxis.Title.Text = "סוג הצמח";
            growGraphPane.YAxis.Title.Text = "אחוזי הנביטה";

            //set the values of the bars
            String[] xArray = StatisticsManager.buildArrayFromGraphData<string,String>(graphData, "type");
            Double[] yArray = StatisticsManager.buildArrayFromGraphData<double,Double>(graphData,"sproutingPerc");

            for (int i = 0; i < xArray.Length; i++)
            {
                string type = xArray[i];
                if (StatisticsManager.plantTypes.ContainsKey(type))
                {
                    xArray[i] = StatisticsManager.plantTypes[type];
                }
                else
                {
                    throw new Exception("No such type entrie in dictionary: " + type);
                }

            }

            //create the bar
            BarItem myCurve = growGraphPane.AddBar("Plant 'Plant'", null,yArray, Color.Blue);

            // Draw the X tics between the labels instead of at the labels
            growGraphPane.XAxis.MajorTic.IsBetweenLabels = false;

            // Set the XAxis to Date type
            growGraphPane.XAxis.Type = AxisType.Text;
            growGraphPane.XAxis.Scale.TextLabels = xArray;

            //set background color
            growGraphPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 45.0F);

            // disable the legend
            growGraphPane.Legend.IsVisible = false;

            // Create TextObj's to provide labels for each bar
            BarItem.CreateBarLabels(growGraphPane, false, "f2");

            //recalculate graph
            growGraphPane.AxisChange();
        }

    }
}
