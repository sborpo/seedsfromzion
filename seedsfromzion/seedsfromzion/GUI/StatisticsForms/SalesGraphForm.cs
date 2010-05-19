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
        private int selectedFavotitePlantId = -1;

        public SalesGraphFrom(seedsFromZion mainForm)
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

        private void SalesGraphFrom_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);
            this.salesGraphControl_Start(sender, e);
            StatisticsManager.initPlantNames();
            StatisticsManager.initPlantTypes();
        }

        //private void MyContextMenuBuilder(ZedGraphControl control, ContextMenuStrip menuStrip, Point mousePt, ZedGraphControl.ContextMenuObjectState objState)
        //{
        //    foreach (ToolStripMenuItem item in menuStrip.Items)
        //    {
        //        if ((string)item.Tag == "print")
        //        {
        //            item.Click += new System.EventHandler(this.MenuClick_Print);

        //            break;
        //        }
        //    }
        //}

        //protected void MenuClick_Print(object sender, EventArgs e)
        //{
        //    DoPrint();
        //}

        //public void DoPrint()
        //{
        //    // Add a try/catch pair since the users of the control can't catch this one
        //    try
        //    {
        //        PrintDocument pd = PrintDocument;

        //        if (pd != null)
        //        {
        //            //pd.PrintPage += new PrintPageEventHandler( Graph_PrintPage );
        //            PrintDialog pDlg = new PrintDialog();
        //            pDlg.Document = pd;
        //            if (pDlg.ShowDialog() == DialogResult.OK)
        //                pd.Print();
        //        }
        //    }
        //    catch (Exception exception)
        //    {
        //        MessageBox.Show(exception.Message);
        //    }

        //}

        private void salesGraphControl_Start(object sender, EventArgs e)
        {
            GraphPane salesGraphPane = this.salesGraphControl.GraphPane;
            //salesGraphControl.ContextMenuBuilder += new ZedGraphControl.ContextMenuBuilderEventHandler(MyContextMenuBuilder);
            salesGraphPane.Title.Text = "גרף המכירות";
            salesGraphPane.Title.FontSpec.FontColor = Color.Navy;
            salesGraphPane.XAxis.Title.Text = "חודשים";
            salesGraphPane.YAxis.Title.Text = "מספר הצמחים";

            // Set the XAxis to Date type
            salesGraphPane.XAxis.Type = AxisType.DateAsOrdinal;
            salesGraphPane.XAxis.Scale.Format = "yyyy-MMM";
            salesGraphPane.XAxis.Scale.MajorStep = 1;
            salesGraphPane.XAxis.Scale.MajorUnit = DateUnit.Month;
            // tilt the x axis labels to an angle of 65 degrees
            salesGraphPane.XAxis.Scale.FontSpec.Angle = 65;
            salesGraphPane.XAxis.Scale.FontSpec.Size = 9;
            salesGraphPane.XAxis.Scale.IsVisible = false;

            salesGraphPane.YAxis.Type = AxisType.Linear;
            salesGraphPane.YAxis.Scale.FormatAuto = true;
            salesGraphPane.YAxis.Scale.IsVisible = false;

            //set background color
            salesGraphPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 45.0F);
        }

        private void salesGraphControl_Load(string plantName,int plantId)
        {
            GraphPane salesGraphPane = this.salesGraphControl.GraphPane;
            DataTable graphData;
            if (plantId.Equals(-1))
            {
                graphData = StatisticsManager.getSalesGraphValues(plantName);
            }
            else
            {
                graphData = StatisticsManager.getSalesGraphValues(plantId);
            }
            salesGraphPane.CurveList.Clear();
            salesGraphPane.GraphObjList.Clear();
  
            if (graphData.Rows.Count.Equals(0))
            {
                new ErrorWindow("אין מידע עבור צמח וסוג שנבחרו").Show();
                return;
            }

            //set the values of the bars
            Double[] xArray = StatisticsManager.buildArrayFromGraphData<DateTime,double>(graphData, "orderDate");
            Double[] yArray = StatisticsManager.buildArrayFromGraphData<decimal,double>(graphData, "units");
            StatisticsManager.sortData(ref xArray, ref yArray);
            StatisticsManager.filterDates(ref xArray, ref yArray, this.fromDate, this.tillDate);

            //check if there is any data
            if (xArray.Length.Equals(0))
            {
                new ErrorWindow("אין מידע עבור צמח בתאריכים שנבחרו").Show();
                return;
            }

            //create the bar
            BarItem myCurve = salesGraphPane.AddBar("'שם הצמח: " + "'" + plantName, xArray, yArray, Color.Blue);

            // Draw the X tics between the labels instead of at the labels
            salesGraphPane.XAxis.MajorTic.IsBetweenLabels = false;

            // disable the legend
            salesGraphPane.Legend.IsVisible = true;

            // Create TextObj's to provide labels for each bar
            BarItem.CreateBarLabels(salesGraphPane, false, "f0");

            StatisticsManager.rotateBarLables(salesGraphPane);
            

            //set visible scales
            salesGraphPane.XAxis.Scale.IsVisible = true;
            salesGraphPane.YAxis.Scale.IsVisible = true;

            //recalculate graph
            salesGraphPane.AxisChange();
            this.salesGraphControl.Refresh();
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
           
            this.salesGraphControl_Load(plantName, plantId);
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
