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
        private int selectedFavotitePlantId = -1;

        public GrowViaFridgeTimeForm(seedsFromZion mainForm)
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

        private void GrowViaFridgeTime_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);
            this.GrowViaFridgeGraphControl_Start(sender, e);
            //StatisticsManager.initPlantNames();
            //StatisticsManager.initPlantTypes();
        }

        private void GrowViaFridgeGraphControl_Start(object sender, EventArgs e)
        {
            GraphPane growGraphPane = this.GrowViaFridgeGraphControl.GraphPane;
            growGraphPane.Title.Text = "גרף אחוזי הנביטה לפי זמן שהיה במקרר";
            growGraphPane.Title.FontSpec.FontColor = Color.Navy;
            growGraphPane.XAxis.Title.Text = "זמן שהיה  במקרר";
            growGraphPane.YAxis.Title.Text = "אחוזי הנביטה";

            // Set the XAxis to Date type
            growGraphPane.XAxis.Type = AxisType.Linear;
            growGraphPane.XAxis.Scale.IsVisible = false;

            growGraphPane.YAxis.Type = AxisType.Linear;
            growGraphPane.YAxis.Scale.FormatAuto = true;
            growGraphPane.YAxis.Scale.IsVisible = false;

            //set background color
            growGraphPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 45.0F);

        }

        private void GrowViaFridgeGraphControl_Load(string plantName, int plantId)
        {
            GraphPane growGraphPane = this.GrowViaFridgeGraphControl.GraphPane;
            DataTable graphData;
            if (plantId.Equals(-1))
            {
                graphData = StatisticsManager.getGrowViaFridgeGraphValues(plantName);
            }
            else
            {
                graphData = StatisticsManager.getGrowViaFridgeGraphValues(plantId);
            }
            
            //set the values of the bars
            Double[] xArray = StatisticsManager.buildArrayFromGraphData<decimal,Double>(graphData, "fridgeTime");
            Double[] yArray = StatisticsManager.buildArrayFromGraphData<double,Double>(graphData, "sproutingPerc");

            if (graphData.Rows.Count.Equals(0))
            {
                new ErrorWindow("אין מידע עבור צמח וסוג שנבחרו").Show();
                return;
            }

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
            LineItem curve = growGraphPane.AddCurve("'שם הצמח: " + "'" + plantName, xSortedArray, ySortedArray, Color.Blue, SymbolType.Circle);
            curve.Line.Width = 2.0F;
            curve.Line.IsAntiAlias = true;
            // activate the cardinal spline smoothing
            curve.Line.IsSmooth = true;
            curve.Line.SmoothTension = 0.1F;
            curve.Symbol.Fill = new Fill(Color.Honeydew);
            curve.Symbol.Size = 7;

            // disable the legend
            growGraphPane.Legend.IsVisible = true;

            // Create TextObj's to provide labels for each bar
            //BarItem.CreateBarLabels(growGraphPane, false, "f2");

            // Offset Y space between point and label
            // NOTE:  This offset is in Y scale units, so it depends on your actual data
            const double yOffset = 0;
            const int xOffset = 0;

            // Loop to add text labels to the points
            for (int i = 0; i < yArray.Length; i++)
            {
                // Get the pointpair
                PointPair pt = curve.Points[i];

                string str = "(" + pt.X.ToString("f0") + " , " + pt.Y.ToString("f2") + ")";
                // Create a text label from the Y data value
                TextObj text = new TextObj(str, pt.X + xOffset, pt.Y + yOffset,
                    CoordType.AxisXYScale, AlignH.Left, AlignV.Bottom);
                text.ZOrder = ZOrder.A_InFront;
                text.FontSpec.Size = 8;
                // Hide the border and the fill
                text.FontSpec.Border.IsVisible = false;
                text.FontSpec.Fill.IsVisible = false;
                //text.FontSpec.Fill = new Fill( Color.FromArgb( 100, Color.GreenYellow ) );
                // Rotate the text to 90 degrees
                text.FontSpec.Angle = 0;

                growGraphPane.GraphObjList.Add(text);
            }

            // Leave some extra space on top for the labels to fit within the chart rect
            //growGraphPane.YAxis.Scale.MaxGrace = 0.2;

            //set visible scales
            growGraphPane.XAxis.Scale.IsVisible = true;
            growGraphPane.YAxis.Scale.IsVisible = true;

            //recalculate graph
            growGraphPane.AxisChange();
            this.GrowViaFridgeGraphControl.Refresh();
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
            StatisticsManager.resetGraphPane(this.GrowViaFridgeGraphControl.GraphPane);
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
                    plantId = (new InventoryManager()).FindPlant(plantName, plantType);
                    //if no such plant name
                    if (plantId.Equals(-1))
                    {
                        //throw new KeyNotFoundException("הצמח לא נמצא לפי פרטים שהוזנו");
                        new ErrorWindow("הצמח לא נמצא לפי פרטים שהוזנו").Show();
                        return;
                    }
                }
            }
            this.GrowViaFridgeGraphControl_Load(plantName,plantId);
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
                //DataRow[] rows = StatisticsManager.plantNames.Select("name LIKE '" + this.plantNameTextBox.Text + "%'");
                StatisticsManager.initPlantNames(this.plantNameTextBox.Text);//NEW
                if (StatisticsManager.plantNames != null)
                {
                    DataRow[] rows = StatisticsManager.plantNames.Select();//NEW
                    if (rows.Length > 0)
                    {
                        String[] names = StatisticsManager.buildArrayFromGraphData<string, String>(rows, "name");
                        this.plantNameTextBox.AutoCompleteCustomSource.Clear();
                        this.plantNameTextBox.AutoCompleteCustomSource.AddRange(names);
                        this.plantNameTextBox.Refresh();
                    }
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
            this.plantTypeDropBox.Items.Clear();
            if (this.plantNameTextBox.Text.Length > 0)
            {
                this.plantTypeDropBox.BeginUpdate();
                //DataRow[] rows = StatisticsManager.plantTypes.Select("name LIKE '" + this.plantNameTextBox.Text + "%'");
                StatisticsManager.initPlantTypes(this.plantNameTextBox.Text);//NEW
                DataRow[] rows = StatisticsManager.plantTypes.Select();//NEW
                if (rows.Length > 0)
                {
                    String[] names = StatisticsManager.buildArrayFromGraphData<string, String>(rows, "type");
                    this.plantTypeDropBox.Items.AddRange(names);
                }
                this.plantTypeDropBox.EndUpdate();
            }
        }


    }
}
