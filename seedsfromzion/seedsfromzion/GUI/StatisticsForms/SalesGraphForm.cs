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
            this.fromDate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.fromDate.CustomFormat = "MM/yyyy";
            this.tillDate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.tillDate.CustomFormat = "MM/yyyy";
            //StatisticsManager.initPlantNames();
            //StatisticsManager.initPlantTypes();
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
            salesGraphPane.XAxis.Scale.FontSpec.Angle = 90;
            salesGraphPane.XAxis.Scale.FontSpec.Size = 10;
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
            
            //set the values of the bars
            Double[] xOrig = StatisticsManager.buildArrayFromGraphData<DateTime, double>(graphData, "orderDate");
            Double[] yOrig = StatisticsManager.buildArrayFromGraphData<decimal, double>(graphData, "units");
            Double[] xArray;
            Double[] yArray;
            StatisticsManager.sortData(ref xOrig, ref yOrig);
            StatisticsManager.filterDates(xOrig, yOrig, this.fromDate, this.tillDate, out xArray, out yArray);

            //get predictions
            StatisticsManager.predictForDates(xOrig, yOrig, this.fromDate, this.tillDate, ref xArray, ref yArray);

            //check if there is any data
            if (xArray.Length.Equals(0))
            {
                new ErrorWindow("אין מידע עבור צמח בתאריכים שנבחרו").Show();
                return;
            }

            //create the bar
            BarItem myCurve = salesGraphPane.AddBar("'שם הצמח: " + "'" + plantName, xArray, yArray, Color.Blue);
            
            //prediction
            

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
            StatisticsManager.resetGraphPane(this.salesGraphControl.GraphPane);
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

            if ((this.fromDate.LockUpdateChecked.Equals(true) && this.fromDate.IsEmpty) ||
                (this.tillDate.LockUpdateChecked.Equals(true) && this.tillDate.IsEmpty))
            {
                new ErrorWindow("אנא בחרו תאריכים או בטלו אותם").Show();
                return;
            }

            if(this.fromDate.LockUpdateChecked &&
               this.tillDate.LockUpdateChecked &&
               this.fromDate.Value.CompareTo(this.tillDate.Value) > 0)
            {
                new ErrorWindow("תעריכים בסדר הפוך!").Show();
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
            else
            {
                this.autoCompleteList.Visible = false;
                this.Redraw();
                if (this.plantNameTextBox.Text.Length > 0)
                {
                    DataRow[] rows = StatisticsManager.initPlantNames(this.plantNameTextBox.Text);//NEW

                    if (rows != null && rows.Length > 0)
                    {
                        String[] names = StatisticsManager.buildArrayFromGraphData<string, String>(rows, "name");
                        this.autoCompleteList.Items.Clear();
                        this.autoCompleteList.Items.AddRange(names);
                        this.autoCompleteList.Visible = true;
                    }
                }
            }
        }


        private void autoCompleteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.plantNameTextBox.Text = (String)this.autoCompleteList.SelectedItem;
            this.autoCompleteList.Visible = false;
            this.Redraw();
            this.plantTypeDropBox.Items.Clear();
            this.plantTypeDropBox.EndUpdate();
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
                //DataRow[] rows = StatisticsManager.plantTypes.Select("name LIKE '" + this.plantNameTextBox.Text + "%'");
                StatisticsManager.initPlantTypes(this.plantNameTextBox.Text);//NEW
                DataRow[] rows = StatisticsManager.plantTypes.Select();//NEW
                if (rows.Length > 0)
                {
                    String[] types = StatisticsManager.buildArrayFromGraphData<string, string>(rows, "type");

                    //foreach(string name in names)
                    //{
                    //    .DropDownItems.Add(new DevComponents.DotNetBar.(name));
                    //}
                    this.plantTypeDropBox.Items.AddRange(types);
                }
                this.plantTypeDropBox.EndUpdate();
            }
        }


    }
}
