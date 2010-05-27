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
        private int selectedFavotitePlantId = -1;

        public GrowViaSowingDateForm(seedsFromZion mainForm)
        {
            InitializeComponent();
            mainForm.favoriteClicked += new seedsFromZion.favoriteClickedHandler(mainForm_favoriteClicked);
        }

        void mainForm_favoriteClicked(int plantId)
        {
            if (this.Created)
            {
                selectedFavotitePlantId = plantId;
                string plantName = StatisticsManager.getNameById(plantId);
                this.plantNameTextBox.Text = plantName;
            }
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

            // Set the XAxis to Date type
            growGraphPane.XAxis.Type = AxisType.DateAsOrdinal;
            growGraphPane.XAxis.Scale.Format = "yyyy-MMM-dd";
            growGraphPane.XAxis.Scale.MajorStep = 1;
            growGraphPane.XAxis.Scale.MajorUnit = DateUnit.Day;
            // tilt the x axis labels to an angle of 65 degrees
            growGraphPane.XAxis.Scale.FontSpec.Angle = 65;
            growGraphPane.XAxis.Scale.FontSpec.Size = 9;
            growGraphPane.XAxis.Scale.IsVisible = false;

            growGraphPane.YAxis.Type = AxisType.Linear;
            growGraphPane.YAxis.Scale.FormatAuto = true;
            growGraphPane.YAxis.Scale.IsVisible = false;

            //set background color
            growGraphPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 45.0F);
        }

        private void GrowViaSowGraphControl_Load(string plantName, int plantId)
        {
            GraphPane growGraphPane = this.GrowViaSowGraphControl.GraphPane;
            DataTable graphData;
            if (plantId.Equals(-1))
            {
                graphData = StatisticsManager.getGrowViaSowGraphValues(plantName);
            }
            else
            {
                graphData = StatisticsManager.getGrowViaSowGraphValues(plantId);
            }
            growGraphPane.CurveList.Clear();
            growGraphPane.GraphObjList.Clear();
            if (graphData.Rows.Count.Equals(0))
            {
                new ErrorWindow("אין מידע עבור צמח וסוג שנבחרו").Show();
                return;
            }

            //set the values of the bars
            Double[] xArray = StatisticsManager.buildArrayFromGraphData<DateTime,Double>(graphData, "sowingDate");
            Double[] yArray = StatisticsManager.buildArrayFromGraphData<double,Double>(graphData, "sproutingPerc");
            StatisticsManager.sortData(ref xArray, ref yArray);
            StatisticsManager.filterDates(ref xArray, ref yArray, this.fromDate, this.tillDate);

            if (xArray.Length.Equals(0))
            {
                new ErrorWindow("אין מידע עבור צמח בתאריכים שנבחרו").Show();
                return;
            }

            //create the bar
            BarItem myCurve = growGraphPane.AddBar("'שם הצמח: "+ "'" + plantName , xArray, yArray, Color.Blue);

            // Draw the X tics between the labels instead of at the labels
            growGraphPane.XAxis.MajorTic.IsBetweenLabels = false;

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
           
            int plantId = -1;
            if (this.plantTypeDropBox.Enabled.Equals(true))
            {
                if (plantType.Length <= 0)
                {
                    //throw new KeyNotFoundException("פרטים חסרים...");
                    new ErrorWindow("אנא בחרו סוג הצמח").Show();
                    return;
                }
                else
                {
                    plantId = (new InventoryManager()).FindPlant(plantName, plantType[0]);
                    //if no such plant name
                    if (plantId.Equals(-1))
                    {
                        //throw new KeyNotFoundException("הצמח לא נמצא לפי פרטים שהוזנו");
                        new ErrorWindow("הצמח לא נמצא לפי פרטים שהוזנו").Show();
                        return;
                    }
                }
            }

            if ((this.fromDate.LockUpdateChecked.Equals(true) && this.fromDate.IsEmpty) ||
                (this.tillDate.LockUpdateChecked.Equals(true) && this.tillDate.IsEmpty))
            {
                new ErrorWindow("אנא בחרו תאריכים או בטלו אותם").Show();
                return;
            }

            if (this.fromDate.Value.CompareTo(this.tillDate.Value) > 0)
            {
                new ErrorWindow("תעריכים בסדר הפוך!").Show();
                return;
            }

            this.GrowViaSowGraphControl_Load(plantName, plantId);
        }


        private void plantNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (selectedFavotitePlantId > 0)
            {
                plantTypeDropBox_TextChanged(sender, e);
                string plantType = StatisticsManager.getTypeById(selectedFavotitePlantId);
                this.plantTypeDropBox.SelectedIndex = this.plantTypeDropBox.Items.IndexOf(plantType);
                selectedFavotitePlantId = -1;
            }
            else if (this.plantNameTextBox.Text.Length > 0)
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
