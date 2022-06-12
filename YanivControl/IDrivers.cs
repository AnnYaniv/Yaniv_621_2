using CarClassDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarInterface
{
    public partial class IDrivers : UserControl
    {
        private DB dataBase = DB.getInstance();
        int last_selected = -1;

        public DataGridView datagridview
        {
            get
            {
                return dataGridView1;
            }
        }
        public IDrivers()
        {
            InitializeComponent();

            DataGridViewComboBoxColumn ColumnType = (DataGridViewComboBoxColumn)dataGridView1.Columns[7];
            ColumnType.Items.Add(categoryType.A);
            ColumnType.Items.Add(categoryType.B);
            ColumnType.Items.Add(categoryType.C);

            Drivers test_1 = new Drivers();
            Drivers test_2 = new Drivers();

            test_1.id = 1;
            test_1.name = "Alina";
            test_1.surname = "Shevchenko";
            test_1.passportSeries = "UK";
            test_1.passport = 9337774;
            test_1.receipt = "2020-05-31";
            test_1.category = categoryType.C;

            test_2.id = 2;
            test_2.name = "Karina";
            test_2.surname = "Vlasenko";
            test_2.passportSeries = "UK";
            test_2.passport = 9344554;
            test_2.category = categoryType.A;
            dataBase.add(test_1);
            dataBase.add(test_2);

            refresh();
        }

        public int getSelected()
        {
            return last_selected;
        }

        public void delete()
        {
            int sel = getSelected();
            if ((sel != -1) && (sel < dataGridView1.RowCount))
            {
                Drivers selected_element;
                selected_element = dataBase.getDriver(Convert.ToInt32(dataGridView1.Rows[sel].Cells[0].Value));
                dataBase.delete(selected_element);
            }
            refresh();
        }
        public void add()
        {
            int sel = last_selected;
            if (sel != -1)
            {
                Drivers selected_element;
                selected_element = dataBase.getDriver(Convert.ToInt32(dataGridView1.Rows[sel].Cells[0].Value));
                if (selected_element == null)
                {
                    selected_element = new Drivers();
                    selected_element.id = Convert.ToInt32(dataGridView1.Rows[sel].Cells[0].Value);
                    dataBase.add(selected_element);
                }
                if (!String.IsNullOrEmpty(dataGridView1.Rows[sel].Cells[1].Value as String)) selected_element.passportSeries = dataGridView1.Rows[sel].Cells[1].Value.ToString();
                selected_element.passport = Convert.ToInt32(dataGridView1.Rows[sel].Cells[2].Value);
                if (!String.IsNullOrEmpty(dataGridView1.Rows[sel].Cells[3].Value as String)) selected_element.surname = dataGridView1.Rows[sel].Cells[3].Value.ToString();
                if (!String.IsNullOrEmpty(dataGridView1.Rows[sel].Cells[4].Value as String)) selected_element.name = dataGridView1.Rows[sel].Cells[4].Value.ToString();
                if (!String.IsNullOrEmpty(dataGridView1.Rows[sel].Cells[5].Value as String)) selected_element.patronymic = dataGridView1.Rows[sel].Cells[5].Value.ToString();
                if (!String.IsNullOrEmpty(dataGridView1.Rows[sel].Cells[6].Value as String)) selected_element.receipt = dataGridView1.Rows[sel].Cells[6].Value.ToString();
                selected_element.category = (categoryType)dataGridView1.Rows[sel].Cells[7].Value;
            }
            refresh();
        }

        public void add_new(Drivers a)
        {
            dataBase.add(a);
            refresh();
        }
        public void refresh()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataBase.DriversSource();
            dataGridView1.ReadOnly = false;
        }
        int column_s = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            last_selected = e.RowIndex;
            column_s = e.ColumnIndex;
        }
        public void add_new_row()
        {
            Drivers dr = new Drivers();
            dr.id = dataBase.getSize(typeof(Drivers))+1;
            dataBase.add(dr);
            refresh();
        }
        public void sort()
        {
            switch (column_s)
            {
                case 0:
                    dataGridView1.DataSource = dataBase.DriversSource().OrderBy(a => a.id).ToList();
                    break;
                case 1:
                    dataGridView1.DataSource = dataBase.DriversSource().OrderBy(a => a.passportSeries).ToList();
                    break;
                case 2:
                    dataGridView1.DataSource = dataBase.DriversSource().OrderBy(a => a.passport).ToList();
                    break;
                case 3:
                    dataGridView1.DataSource = dataBase.DriversSource().OrderBy(a => a.surname).ToList();
                    break;
                case 4:
                    dataGridView1.DataSource = dataBase.DriversSource().OrderBy(a => a.name).ToList();
                    break;
                case 5:
                    dataGridView1.DataSource = dataBase.DriversSource().OrderBy(a => a.patronymic).ToList();
                    break;
                case 6:
                    dataGridView1.DataSource = dataBase.DriversSource().OrderBy(a => a.receipt).ToList();
                    break;
            }
        }
    }
}
