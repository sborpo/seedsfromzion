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
            this.GrowViaSowGraphControl_Start(sender, e);
            StatisticsManager.initPlantNames();
            StatisticsManager.initPlantTypes();
        }

        private void GrowViaSowGraphControl_Start(object sender, EventArgs e)
        {
            GraphPane growGraphPane = this.GrowViaSowGraphControl.GraphPane;
            growGraphPane.Title.Text = "גרף אחוזי הנביטה לפי תאריך הזריע";
            growGraphPane.Title.FontSpec.FontColor = Color.Navy;
            growGraphPane.XAxis.Title.Text = "תאריך הזריע";
            growGraphPane.YAxis.Title.Text = "אחוזי הנביטה";

            //set background color
            growGraphPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 45.0F);
        }

        private void GrowViaSowGraphControl_Load(object sender, EventArgs e)
        {
            GraphPane growGraphPane = this.GrowViaSowGraphControl.GraphPane;
            DataTable graphData = StatisticsManager.getGrowViaSowGraphValues();

            //set the values of the bars
            Double[] xArray = StatisticsManager.buildArrayFromGraphData<DateTime,Double>(graphData, "sowingDate");
            Double[] yArray = StatisticsManager.buildArrayFromGraphData<double,Double>(graphData, "sproutingPerc");

            if (xArray.Length.Equals(0))
            {
                throw new Exception("Zero length data was received");
            }

            //create the bar
            BarItem myCurve = growGraphPane.AddBar("Plant 'Plant'", xArray, yArray, Color.Blue);

            // Draw the X tics between the labels instead of at the labels
            growGraphPane.XAxis.MajorTic.IsBetweenLabels = false;

            // Set the XAxis to Date type
            growGraphPane.XAxis.Type = AxisType.DateAsOrdinal;
            growGraphPane.XAxis.Scale.Format = "yyyy-MMM-dd";

            // disable the legend
            growGraphPane.Legend.IsVisible = false;

            // Create TextObj's to provide labels for each bar
            BarItem.CreateBarLabels(growGraphPane, false, "f2");
         

            //recalculate graph
            growGraphPane.AxisChange();
            this.GrowViaSowGraphControl.Refresh();
        }

        private void isChosenTypeCHBX_CheckedChanged(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.Controls.CheckBoxX myCHBX = sender as DevComponents.DotNetBar.Controls.CheckBoxX;
            if (myCHBX.Checked.Equals(false))
            {
                this.plantTypeDropBox.Enabled = false;
            }
            else
            {
                this.plantTypeDropBox.Enabled = true;
            }
        }

        private void showGraphButton_Click(object sender, EventArgs e)
        {
            string plantName = this.plantNameTextBox.Text;
            string plantType = this.plantTypeDropBox.Text;

            //check if all data was entered
            if (plantName.Length <= 0)
            {
                new ErrorWindow("שם של הצמח ריק").Show();
                return;
            }
            if (isChosenTypeCHBX.Enabled && plantType.Length <= 0)
            {
                //throw new KeyNotFoundException("פרטים חסרים...");
                new ErrorWindow("אנא בחרו סוג הצמח").Show();
                return;
            }

            int plantId = (new InventoryManager()).FindPlant(plantName, plantType[0]);

            //if no such plant name
            if (plantId.Equals(-1))
            {
                //throw new KeyNotFoundException("הצמח לא נמצא לפי פרטים שהוזנו");
                new ErrorWindow("הצמח לא נמצא לפי פרטים שהוזנו").Show();
                return;
            }


            //this.salesGraphControl_Load(plantId);
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

        private void plantTypeDropBox_TextChanged(object sender, EventArgs e)
        {
            //MAYBE TO IMPLEMENT THE CHOISE OF THE APPROPRIATE TYPE
            this.plantTypeDropBox.Items.Clear();
            if (this.plantNameTextBox.Text.Length > 0)
            {
                this.plantTypeDropBox.BeginUpdate();
                DataRow[] rows = StatisticsManager.plantTypes.Select("name LIKE '" + this.plantNameTextBox.Text + "%'");
                if (rows.Length > 0)
                {
                    String[] names = StatisticsManager.buildArrayFromGraphData<string, String>(rows, "type");

                    //foreach(string name in names)
                    //{
                    //    .DropDownItems.Add(new DevComponents.DotNetBar.(name));
                    //}
                    this.plantTypeDropBox.Items.AddRange(names);
                }
                this.plantTypeDropBox.EndUpdate();
            }
        }


    }
}
