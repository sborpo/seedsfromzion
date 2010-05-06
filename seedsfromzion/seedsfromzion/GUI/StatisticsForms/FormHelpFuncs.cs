using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Data;
using System.Windows.Forms;
using ZedGraph;

namespace seedsfromzion.GUI.StatisticsForms
{
    class FormHelpFuncs
    {
        static public PointPairList buildPairListFromGraphData<X,Y>(DataTable dataTable, String xColumnName, String yColumnName)
        {
            PointPairList list = new PointPairList();
            try
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    Object xValue = dataTable.Rows[i][xColumnName];
                    Y yValue = (Y)dataTable.Rows[i][yColumnName];
                    double doubleYvalue = (double)TypeDescriptor.GetConverter(typeof(Y)).ConvertTo(yValue, typeof(double));
                    if (typeof(X).Equals(typeof(DateTime)))
                    {
                        DateTime date = (DateTime)Convert.ChangeType(xValue, typeof(DateTime));
                        XDate xDate = new XDate(date);
                        list.Add((double)xDate, (double)doubleYvalue);
                    }
                    else
                    {
                        double doubleXvalue = (double)TypeDescriptor.GetConverter(typeof(X)).ConvertTo(xValue, typeof(double));
                        list.Add((double)doubleXvalue, (double)doubleYvalue);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Fuck");
            }

            return list;
        }
    }
}
