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
    /// <summary>
    /// This form is representing sales graph statistics.
    /// </summary>
    public partial class SalesGraphFrom : seedsfromzion.GUI.BaseForm
    {
        private int selectedFavotitePlantId = -1;

        /// <summary>
        /// Initializes a new instance of the <see cref="SalesGraphFrom"/> class.
        /// </summary>
        /// <param name="mainForm">The main form - is the parent form.</param>
        public SalesGraphFrom(seedsFromZion mainForm)
        {
            InitializeComponent();
            //add a new handler for the favorites click event.
            mainForm.favoriteClicked += new seedsFromZion.favoriteClickedHandler(mainForm_favoriteClicked);
        }

        /// <summary>
        /// Favorites clicked event handler.
        /// </summary>
        /// <param name="plantId">The plant id.</param>
        void mainForm_favoriteClicked(int plantId)
        {   //if the form is created - load the plant data
            if (this.Created)
            {
                selectedFavotitePlantId = plantId;
                string plantName = StatisticsManager.getNameById(plantId);
                this.plantNameTextBox.Text = plantName;
            }
        }

        /// <summary>
        /// Handles the Load event of the SalesGraphFrom control.
        /// Performs some custom initializations.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void SalesGraphFrom_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);
            this.salesGraphControl_Start(sender, e);
            this.fromDate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.fromDate.CustomFormat = "MM/yyyy";
            this.tillDate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.tillDate.CustomFormat = "MM/yyyy";
        }

        /// <summary>
        /// Handles the Start event of the salesGraphControl control.
        /// Initializes the graph control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void salesGraphControl_Start(object sender, EventArgs e)
        {
            GraphPane salesGraphPane = this.salesGraphControl.GraphPane;
            //define propetries
            salesGraphPane.Title.Text = "גרף המכירות";
            salesGraphPane.Title.FontSpec.FontColor = Color.Navy;
            salesGraphPane.XAxis.Title.Text = "חודשים";
            salesGraphPane.YAxis.Title.Text = "מספר הצמחים";

            // Set the XAxis to Date type
            salesGraphPane.XAxis.Type = AxisType.DateAsOrdinal;
            salesGraphPane.XAxis.Scale.Format = "yyyy-MMM";
            salesGraphPane.XAxis.Scale.MajorStep = 1;
            salesGraphPane.XAxis.Scale.MajorUnit = DateUnit.Month;
            //set angles for the axis labels
            salesGraphPane.XAxis.Scale.FontSpec.Angle = 90;
            salesGraphPane.XAxis.Scale.FontSpec.Size = 10;
            salesGraphPane.XAxis.Scale.IsVisible = false;
            // Set the YAxis to Date type
            salesGraphPane.YAxis.Type = AxisType.Linear;
            salesGraphPane.YAxis.Scale.FormatAuto = true;
            salesGraphPane.YAxis.Scale.IsVisible = false;

            //set background color
            salesGraphPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 45.0F);
        }

        /// <summary>
        /// Loads the graph control for a specific plant name and plant id.
        /// </summary>
        /// <param name="plantName">Name of the plant.</param>
        /// <param name="plantId">The plant id.</param>
        private void salesGraphControl_Load(string plantName,int plantId)
        {
            GraphPane salesGraphPane = this.salesGraphControl.GraphPane;
            DataTable graphData;
            //get the graph data by id or name
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
            //dort and filter the data.
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

        /// <summary>
        /// Handles the CheckedChanged event of the isChosenTypeCHBX control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the showGraphButton control.
        /// Performs several checkups for validity of entered data.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
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


        /// <summary>
        /// Handles the TextChanged event of the plantNameTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void plantNameTextBox_TextChanged(object sender, EventArgs e)
        {
            //if favorites has been selected
            if (selectedFavotitePlantId > 0)
            {
                plantTypeDropBox_DropDown(sender, e);
                string plantType = StatisticsManager.getTypeById(selectedFavotitePlantId);
                this.plantTypeDropBox.SelectedIndex = this.plantTypeDropBox.Items.IndexOf(plantType);
                selectedFavotitePlantId = -1;
            }
            //else - text was entered by user - enable autocomplete
            else
            {
                this.autoCompleteList.Visible = false;
                this.Redraw();
                if (this.plantNameTextBox.Text.Length > 0)
                {
                    DataRow[] rows = StatisticsManager.initPlantNames(this.plantNameTextBox.Text);

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


        /// <summary>
        /// Handles the SelectedIndexChanged event of the autoCompleteList control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void autoCompleteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.plantNameTextBox.Text = (String)this.autoCompleteList.SelectedItem;
            this.autoCompleteList.Visible = false;
            this.Redraw();
            this.plantTypeDropBox.Items.Clear();
            this.plantTypeDropBox.EndUpdate();
        }

        /// <summary>
        /// Handles the KeyPress event of the plantNameTextBox control.
        /// Accepts only letters, backspace and the delete button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.KeyPressEventArgs"/> instance containing the event data.</param>
        private void plantNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back) || e.KeyChar.Equals((char)Keys.Delete)))
                e.Handled = true;
        }

        /// <summary>
        /// Handles the DropDown event of the plantTypeDropBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void plantTypeDropBox_DropDown(object sender, EventArgs e)
        {
            this.plantTypeDropBox.Items.Clear();
            if (this.plantNameTextBox.Text.Length > 0)
            {
                this.plantTypeDropBox.BeginUpdate();
                StatisticsManager.initPlantTypes(this.plantNameTextBox.Text);
                DataRow[] rows = StatisticsManager.plantTypes.Select();
                if (rows.Length > 0)
                {
                    String[] types = StatisticsManager.buildArrayFromGraphData<string, string>(rows, "type");
                    this.plantTypeDropBox.Items.AddRange(types);
                }
                this.plantTypeDropBox.EndUpdate();
            }
        }
    }
}
