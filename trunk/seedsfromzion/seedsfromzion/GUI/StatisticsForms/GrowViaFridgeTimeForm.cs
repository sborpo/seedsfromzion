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
            Double[] xArray = StatisticsManager.buildArrayFromGraphData<decimal,Double>(graphData, "fridgeTime");
            Double[] yArray = StatisticsManager.buildArrayFromGraphData<double,Double>(graphData, "sproutingPerc");

            Double[] xSortedArray = (Double[])xArray.Clone();
            Array.Sort<double>(xSortedArray);
            Double[] ySortedArray = new Double[yArray.Length];
            for (int i = 0; i < xArray.Length; i++)
            {
                int index = Array.IndexOf<double>(xArray, xSortedArray[i]);
                ySortedArray[i] = yArray[index];
            }
            //create the bar
            //BarItem myCurve = growGraphPane.AddBar("Plant 'Plant'", xArray, yArray, Color.Blue);

            // Draw the X tics between the labels instead of at the labels
            growGraphPane.XAxis.MajorTic.IsBetweenLabels = false;

            // Add a curve
            LineItem curve = growGraphPane.AddCurve("Plant 'plant'", xSortedArray, ySortedArray, Color.Blue, SymbolType.Circle);
            curve.Line.Width = 2.0F;
            curve.Line.IsAntiAlias = true;
            // activate the cardinal spline smoothing
            curve.Line.IsSmooth = true;
            curve.Line.SmoothTension = 0.1F;
            curve.Symbol.Fill = new Fill(Color.White);
            curve.Symbol.Size = 7;

            //set background color
            growGraphPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 45.0F);

            // disable the legend
            growGraphPane.Legend.IsVisible = false;

            // Create TextObj's to provide labels for each bar
            //BarItem.CreateBarLabels(growGraphPane, false, "f2");

            // Offset Y space between point and label
            // NOTE:  This offset is in Y scale units, so it depends on your actual data
            const double yOffset = 0.1;
            const int xOffset = 0;

            // Loop to add text labels to the points
            for (int i = 0; i < yArray.Length; i++)
            {
                // Get the pointpair
                PointPair pt = curve.Points[i];

                string str = "(" + pt.X.ToString("f0") + " , " + pt.Y.ToString("f2") + ")";
                // Create a text label from the Y data value
                TextObj text = new TextObj(str, pt.X - xOffset, pt.Y + yOffset,
                    CoordType.AxisXYScale, AlignH.Left, AlignV.Center);
                text.ZOrder = ZOrder.A_InFront;
                // Hide the border and the fill
                text.FontSpec.Border.IsVisible = false;
                text.FontSpec.Fill.IsVisible = false;
                //text.FontSpec.Fill = new Fill( Color.FromArgb( 100, Color.White ) );
                // Rotate the text to 90 degrees
                text.FontSpec.Angle = 0;

                growGraphPane.GraphObjList.Add(text);
            }

            // Leave some extra space on top for the labels to fit within the chart rect
            //growGraphPane.YAxis.Scale.MaxGrace = 0.2;

            //recalculate graph
            growGraphPane.AxisChange();
        }
    }
}
