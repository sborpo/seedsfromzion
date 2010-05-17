using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using seedsfromzion.Managers;
using seedsfromzion.DataAccess;

namespace seedsfromzion.GUI.InventoryForms
{
    public partial class InventoryReports : seedsfromzion.GUI.BaseForm
    {
        public InventoryReports()
        {
            InitializeComponent();
            comboBoxEx1.SelectedIndex = 0;
            checkBoxX1.Checked = true;
            checkBoxX2.Checked = true;
            checkBoxX3.Checked = true;
        }

        public void buttonX1_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            if ((!checkBoxX1.Checked) && (!checkBoxX2.Checked) && (!checkBoxX3.Checked))
            {
                new ErrorWindow("לא נבחרו דוחות להצגה");
                return;
            }
            if (checkBoxX1.Checked)
            {
                generateFridgeStatus(r);
            }
            if (checkBoxX2.Checked)
            {
                generateFieldStatus(r);
            }
            if (checkBoxX3.Checked)
            {
                generateWarehouseStatus(r);
            }
            r.ReportColor = (comboBoxEx1.SelectedIndex == 0) ? Report.ReportStyle.Color : Report.ReportStyle.BlackWhite;
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = @"c:\";
            dialog.Filter = "HTML File (*.html) |*.html";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                r.save(dialog.FileName);
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = "iexplore";
                proc.StartInfo.Arguments =dialog.FileName;
                proc.Start();
            }
        }

        private void generateWarehouseStatus(Report r)
        {
            InventoryManager manager = new InventoryManager();
            DataTable table = manager.getFinishedStorageTable();
            table.Columns[0].ColumnName = "מזהה הצמח";
            table.Columns[1].ColumnName = "שם הצמח";
            table.Columns[2].ColumnName = "סוג הצמח";
            table.Columns[3].ColumnName = "מספר מחסן";
            table.Columns[4].ColumnName = "יחידות";
            table.Columns[5].ColumnName = "מיקום במחסן";
            InventoryStatus(r, "מצב המחסנים", table);

        }

        private void generateFieldStatus(Report r)
        {
            InventoryManager manager = new InventoryManager();
            DataTable table = manager.getFieldTable();
            table.Columns[0].ColumnName = "מזהה הצמח";
            table.Columns[1].ColumnName = "שם הצמח";
            table.Columns[2].ColumnName = "סוג הצמח";
            table.Columns[3].ColumnName = "תאריך הגעה למקרר";
            table.Columns[4].ColumnName = "תאריך זריעה";
            table.Columns[5].ColumnName = "יחידות";
            table.Columns[6].ColumnName = "מיקום בשדה";
            InventoryStatus(r, "מצב השדה", table);

            
        }

        private void generateFridgeStatus(Report r)
        {
            InventoryManager manager = new InventoryManager();
            DataTable table=manager.getFridgeTable();
            table.Columns[0].ColumnName = "מזהה הצמח";
            table.Columns[1].ColumnName = "שם הצמח";
            table.Columns[2].ColumnName = "סוג הצמח";
            table.Columns[3].ColumnName = "תאריך הגעה למקרר";
            table.Columns[4].ColumnName = "יחידות";
            table.Columns[5].ColumnName = "מיקום במקרר";
            InventoryStatus(r, "מצב המקרר", table);

        }

        private void InventoryStatus(Report r, string headingStr, DataTable inventory)
        {
            HtmlTable htmlTable = new HtmlTable(inventory);
            htmlTable.align(HtmlAlign.center);
            r.append(new HtmlEndLine(4));
            HtmlHeading heading = new HtmlHeading(headingStr);
            heading.align(HtmlAlign.center);
            r.append(heading);
            r.append(new HtmlEndLine(2));
            r.append(htmlTable);
            r.append(new HtmlEndLine(2));
        }
    }
}
