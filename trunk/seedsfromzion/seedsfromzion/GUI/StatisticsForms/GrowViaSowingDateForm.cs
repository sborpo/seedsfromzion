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
    public partial class GrowViaSowingDateForm : seedsfromzion.GUI.BaseForm
    {
        public GrowViaSowingDateForm()
        {
            InitializeComponent();
        }

        
        private void GrowViaSowingDateGraph_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);
            this.GrowViaSowGraphControl_Load(sender, e);
        }

        private void GrowViaSowGraphControl_Load(object sender, EventArgs e)
        {
            GraphPane growGraphPane = this.GrowViaSowGraphControl.GraphPane;
            DataTable graphData = StatisticsManager.getGrowViaSowGraphValues();
            growGraphPane.Title.Text = "גרף אחוזי הנביטה לפי תאריך הזריע";
            growGraphPane.XAxis.Title.Text = "תאריך הזריע";
            growGraphPane.YAxis.Title.Text = "אחוזי הנביטה";

            //set the values of the bars
            Double[] xArray = StatisticsManager.buildArrayFromGraphData<DateTime,Double>(graphData, "sowingDate");
            Double[] yArray = StatisticsManager.buildArrayFromGraphData<double,Double>(graphData, "sproutingPerc");
            
            //create the bar
            BarItem myCurve = growGraphPane.AddBar("Plant 'Plant'", xArray, yArray, Color.Blue);

            // Draw the X tics between the labels instead of at the labels
            growGraphPane.XAxis.MajorTic.IsBetweenLabels = false;

            // Set the XAxis to Date type
            growGraphPane.XAxis.Type = AxisType.DateAsOrdinal;
            growGraphPane.XAxis.Scale.Format = "yyyy-MMM-dd";

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
