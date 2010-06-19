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
    /// This form represents the grow via sowing date graph statistics.
    /// </summary>
    public partial class GrowViaSowingDateForm : seedsfromzion.GUI.BaseForm
    {
        private int selectedFavotitePlantId = -1;

        /// <summary>
        /// Initializes a new instance of the <see cref="GrowViaSowingDateForm"/> class.
        /// </summary>
        /// <param name="mainForm">The main form.</param>
        public GrowViaSowingDateForm(seedsFromZion mainForm)
        {
            InitializeComponent();
            //add handler for favorites clicked event
            mainForm.favoriteClicked += new seedsFromZion.favoriteClickedHandler(mainForm_favoriteClicked);
        }

        /// <summary>
        /// handles the favorites click event.
        /// </summary>
        /// <param name="plantId">The plant id.</param>
        void mainForm_favoriteClicked(int plantId)
        {
            //only if the form is created - load the data
            if (this.Created)
            {
                selectedFavotitePlantId = plantId;
                string plantName = StatisticsManager.getNameById(plantId);
                this.plantNameTextBox.Text = plantName;
            }
        }

        /// <summary>
        /// Handles the Load event of the GrowViaSowingDateGraph control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void GrowViaSowingDateGraph_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);
            //Triggers the initialization of the graph control
            this.GrowViaSowGraphControl_Start(sender, e);
        }

        /// <summary>
        /// Handles the Start event of the GrowViaSowGraphControl control.
        /// Initializes the graph control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void GrowViaSowGraphControl_Start(object sender, EventArgs e)
        {
            GraphPane growGraphPane = this.GrowViaSowGraphControl.GraphPane;
            //set the basic propetries
            growGraphPane.Title.Text = "גרף אחוזי הנביטה לפי תאריך הזריע";
            growGraphPane.Title.FontSpec.FontColor = Color.Navy;
            growGraphPane.XAxis.Title.Text = "תאריך הזריע";
            growGraphPane.YAxis.Title.Text = "אחוזי הנביטה";

            // Set the XAxis to Date type
            growGraphPane.XAxis.Type = AxisType.DateAsOrdinal;
            growGraphPane.XAxis.Scale.Format = "yyyy-MMM-dd";
            growGraphPane.XAxis.Scale.MajorStep = 1;
            growGraphPane.XAxis.Scale.MajorUnit = DateUnit.Day;

            //set the axis labels angle
            growGraphPane.XAxis.Scale.FontSpec.Angle = 90;
            growGraphPane.XAxis.Scale.FontSpec.Size = 10;
            growGraphPane.XAxis.Scale.IsVisible = false;

            // Set the YAxis to Date type
            growGraphPane.YAxis.Type = AxisType.Linear;
            growGraphPane.YAxis.Scale.FormatAuto = true;
            growGraphPane.YAxis.Scale.IsVisible = false;

            //set background color
            growGraphPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 45.0F);
        }

        /// <summary>
        /// Loads the graph control. Performing several checkups of the data.
        /// </summary>
        /// <param name="plantName">Name of the plant.</param>
        /// <param name="plantId">The plant id.</param>
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
            //if no data for the entered plant exists
            if (graphData.Rows.Count.Equals(0))
            {
                new ErrorWindow("אין מידע עבור צמח וסוג שנבחרו").Show();
                return;
            }

            //set the values of the bars
            Double[] xOrig = StatisticsManager.buildArrayFromGraphData<DateTime, Double>(graphData, "sowingDate");
            Double[] yOrig = StatisticsManager.buildArrayFromGraphData<double, Double>(graphData, "sproutingPerc");
            Double[] xArray;
            Double[] yArray;

            //prepare the data
            StatisticsManager.sortData(ref xOrig, ref yOrig);
            StatisticsManager.filterDates(xOrig, yOrig, this.fromDate, this.tillDate, out xArray, out yArray);

            //get predictions
            StatisticsManager.predictForDates(xOrig, yOrig, this.fromDate, this.tillDate, ref xArray, ref yArray);

            //if no data exists after dates filtering and prediction
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
        /// Performs several checkups of the entered data.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void showGraphButton_Click(object sender, EventArgs e)
        {
            string plantName = this.plantNameTextBox.Text;
            string plantType = this.plantTypeDropBox.Text;
            StatisticsManager.resetGraphPane(this.GrowViaSowGraphControl.GraphPane);
            //check if all data was entered
            if (plantName.Length <= 0)
            {
                new ErrorWindow("שם של הצמח ריק").Show();
                return;
            }
           
            int plantId = -1;
            if (this.plantTypeDropBox.Enabled.Equals(true))
            {   //if no type was chosen
                if (plantType.Length <= 0)
                {
                    new ErrorWindow("אנא בחרו סוג הצמח").Show();
                    return;
                }
                else
                {
                    plantId = (new InventoryManager()).FindPlant(plantName, plantType);
                    //if no such plant name
                    if (plantId.Equals(-1))
                    {
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

            if (this.fromDate.LockUpdateChecked &&
               this.tillDate.LockUpdateChecked &&
               this.fromDate.Value.CompareTo(this.tillDate.Value) > 0)
            {
                new ErrorWindow("תעריכים בסדר הפוך!").Show();
                return;
            }

            this.GrowViaSowGraphControl_Load(plantName, plantId);
        }

        /// <summary>
        /// Handles the TextChanged event of the plantNameTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void plantNameTextBox_TextChanged(object sender, EventArgs e)
        {   //if favorites were clicked
            if (selectedFavotitePlantId > 0)
            {
                plantTypeDropBox_DropDown(sender, e);
                string plantType = StatisticsManager.getTypeById(selectedFavotitePlantId);
                this.plantTypeDropBox.SelectedIndex = this.plantTypeDropBox.Items.IndexOf(plantType);
                selectedFavotitePlantId = -1;
            }
            //else the text was entered - execute autocomplete
            else 
            {
                this.autoCompleteList.Visible = false;
                this.Redraw();
                if (this.plantNameTextBox.Text.Length > 0)
                {
                    DataRow[] rows = StatisticsManager.initPlantNames(this.plantNameTextBox.Text);//NEW
                    if ( rows !=null && rows.Length > 0)
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
        /// Filters out everything beside: letters,backspace and delete.
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
            //if plant name was entered
            if (this.plantNameTextBox.Text.Length > 0)
            {
                this.plantTypeDropBox.BeginUpdate();
                //try to load the types
                StatisticsManager.initPlantTypes(this.plantNameTextBox.Text);
                DataRow[] rows = StatisticsManager.plantTypes.Select();
                //if there is any type
                if (rows.Length > 0)
                {
                    String[] types = StatisticsManager.buildArrayFromGraphData<string, string>(rows, "type");
                    //show the types
                    this.plantTypeDropBox.Items.AddRange(types);
                }
                this.plantTypeDropBox.EndUpdate();
            }
        }


    }
}
