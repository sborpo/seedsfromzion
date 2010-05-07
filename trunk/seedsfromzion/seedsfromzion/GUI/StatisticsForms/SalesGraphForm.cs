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
    public partial class SalesGraphFrom : seedsfromzion.GUI.BaseForm
    {
        public SalesGraphFrom()
        {
            InitializeComponent();
        }

        private void SalesGraphFrom_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);
            this.salesGraphControl_Load(sender,e);
        }


        //private T[] getArrayFromDataTableByColumn<S,T>(DataTable dataTable, String columnName)
        //{
        //    T[] array = new T[dataTable.Rows.Count];
        //    for (int i = 0; i < dataTable.Rows.Count; i++)
        //    {
        //        array [i] = (T)TypeDescriptor.GetConverter(typeof(S)).ConvertTo(dataTable.Rows[i][columnName], typeof(T));
                
        //    }
          
        //    return array;
        //}

        private void salesGraphControl_Load(object sender, EventArgs e)
        {
            GraphPane salesGraphPane = this.salesGraphControl.GraphPane;
            DataTable graphData = StatisticsManager.getSalesGraphValues();
            salesGraphPane.Title.Text = "גרף המכירות";
            salesGraphPane.XAxis.Title.Text = "חודשים";
            salesGraphPane.YAxis.Title.Text = "מספר הצמחים";

            //set the values of the bars
            PointPairList list = StatisticsManager.buildPairListFromGraphData<DateTime, decimal>(graphData, "orderDate", "units");

            //create the bar
            BarItem myCurve = salesGraphPane.AddBar("Plant 'Plant'", list, Color.Blue);

            // Draw the X tics between the labels instead of at the labels
            salesGraphPane.XAxis.MajorTic.IsBetweenLabels = false;

            // Set the XAxis labels
            //salesGraphPane.XAxis.Scale = DateTime;

            // Set the XAxis to Date type
            salesGraphPane.XAxis.Type = AxisType.DateAsOrdinal;
            salesGraphPane.XAxis.Scale.Format = "yyyy-MMM";

            //set background color
            salesGraphPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 45.0F);

            // disable the legend
            salesGraphPane.Legend.IsVisible = false;

            // expand the range of the Y axis slightly to accommodate the labels
            //salesGraphPane.YAxis.Scale.Max += salesGraphPane.YAxis.Scale.MajorStep;

            // Create TextObj's to provide labels for each bar
            BarItem.CreateBarLabels(salesGraphPane, false, "f0");

            //recalculate graph
            salesGraphPane.AxisChange();
        }

    }
}
