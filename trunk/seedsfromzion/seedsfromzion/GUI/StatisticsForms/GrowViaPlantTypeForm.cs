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
    /// This form is the statistics form for grow percentage via plant type
    /// </summary>
    public partial class GrowViaPlantTypeForm : seedsfromzion.GUI.BaseForm
    {
        private string selectedFavotitePlantName = "";

        /// <summary>
        /// Initializes a new instance of the <see cref="GrowViaPlantTypeForm"/> class.
        /// </summary>
        /// <param name="mainForm">The main form.</param>
        public GrowViaPlantTypeForm(seedsFromZion mainForm)
        {
            InitializeComponent();
            //register for the favorites click event
            mainForm.favoriteClicked += new seedsFromZion.favoriteClickedHandler(mainForm_favoriteClicked);
        }

        /// <summary>
        /// Handles the favorites click event.
        /// </summary>
        /// <param name="plantId">The plant id.</param>
        void mainForm_favoriteClicked(int plantId)
        {   //only if the form is created
            if (this.Created)
            {
                string plantName = StatisticsManager.getNameById(plantId);
                selectedFavotitePlantName = plantName;
                this.plantNameTextBox.Text = plantName;  
            }
        }

        /// <summary>
        /// Handles the Load event of the GrowViaPlantTypeForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void GrowViaPlantTypeForm_Load(object sender, EventArgs e)
        {
            base.BaseForm_Load(sender, e);
            //starts the initialization of the graph control
            this.GrowViaTypeGraphControl_Start(sender, e);
        }

        /// <summary>
        /// Handles the Start event of the GrowViaTypeGraphControl control.
        /// Basic initizalization of the graph.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void GrowViaTypeGraphControl_Start(object sender, EventArgs e)
        {
            GraphPane growGraphPane = this.GrowViaTypeGraphControl.GraphPane;
            //set basic properties
            growGraphPane.Title.Text = "גרף אחוזי הנביטה לפי סוג הצמח";
            growGraphPane.Title.FontSpec.FontColor = Color.Navy;
            growGraphPane.XAxis.Title.Text = "סוג הצמח";
            growGraphPane.YAxis.Title.Text = "אחוזי הנביטה";

            // Set the XAxis to Date type
            growGraphPane.XAxis.Type = AxisType.Text;
            growGraphPane.XAxis.Scale.IsVisible = false;

            // Set the YAxis to Date type
            growGraphPane.YAxis.Type = AxisType.Linear;
            growGraphPane.YAxis.Scale.FormatAuto = true;
            growGraphPane.YAxis.Scale.IsVisible = false;

            //set background color
            growGraphPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 45.0F);
        }

        /// <summary>
        /// Loading the grow via plant type graph.
        /// </summary>
        /// <param name="plantName">Name of the plant.</param>
        private void GrowViaTypeGraphControl_Load(string plantName)
        {
            GraphPane growGraphPane = this.GrowViaTypeGraphControl.GraphPane;
            DataTable graphData = StatisticsManager.getGrowViaTypeGraphValues(plantName);
            
            //set the values of the bars
            String[] xArray = StatisticsManager.buildArrayFromGraphData<string, String>(graphData, "type");
            Double[] yArray = StatisticsManager.buildArrayFromGraphData<double, Double>(graphData, "sproutingPerc");

            if (graphData.Rows.Count.Equals(0))
            {
                new ErrorWindow("אין מידע עבור צמח שנבחר").Show();
                return;
            }

            //create the bar
            BarItem myCurve = growGraphPane.AddBar("'שם הצמח: " + "'" + plantName, null, yArray, Color.Blue);

            // Draw the X tics between the labels instead of at the labels
            growGraphPane.XAxis.MajorTic.IsBetweenLabels = false;

            // Set the XAxis to Date type
            growGraphPane.XAxis.Scale.TextLabels = xArray;

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
            this.GrowViaTypeGraphControl.Refresh();
        }

        /// <summary>
        /// Handles the Click event of the showGraphButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void showGraphButton_Click(object sender, EventArgs e)
        {
            string plantName = this.plantNameTextBox.Text;
            StatisticsManager.resetGraphPane(this.GrowViaTypeGraphControl.GraphPane);
            //check if all data was entered
            if (plantName.Length <= 0)
            {
                new ErrorWindow("שם של הצמח ריק").Show();
                return;
            }

            this.GrowViaTypeGraphControl_Load(plantName);
        }

        /// <summary>
        /// Handles the TextChanged event of the plantNameTextBox control.
        /// Performs autocomplete when text was changed.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void plantNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!selectedFavotitePlantName.Equals(""))
            {
                selectedFavotitePlantName = "";
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
        }

        /// <summary>
        /// Handles the KeyPress event of the plantNameTextBox control.
        /// Ignores all except letters, backspace and delete button.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.KeyPressEventArgs"/> instance containing the event data.</param>
        private void plantNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back) || e.KeyChar.Equals((char)Keys.Delete)))
                e.Handled = true;
        }

    }
}
