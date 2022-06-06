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
    public partial class IViezd : UserControl
    {
        private DB dataBase = DB.getInstance();
        int last_selected = -1;

        public IViezd()
        {
            InitializeComponent();
            
            Viezd test_1 = new Viezd();
            Viezd test_2 = new Viezd();

            test_1.carNum = "AX8000";
            test_1.dateViezd = "2020-05-06";
            test_1.driverId = 1;
            test_1.km = 50;

            test_2.carNum = "AX9000";
            test_2.dateViezd = "2020-07-06";
            test_2.driverId = 2;
            test_2.km = 50;

            dataBase.add(test_1);
            dataBase.add(test_2);

            refresh();
        }

        public void delete()
        {
            int sel = last_selected;
            if ((sel != -1) && (sel < dataGridView1.RowCount))
            {
                Viezd selected_element;
                selected_element = dataBase.getViezd(dataGridView1.Rows[sel].Cells[0].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[sel].Cells[1].Value), dataGridView1.Rows[sel].Cells[2].Value.ToString());
                dataBase.delete(selected_element);
            }
            refresh();
        }
        public void refresh()
        {
            int i = 0;
            DataGridViewComboBoxColumn carNum = (DataGridViewComboBoxColumn)dataGridView1.Columns[2];
            // ToDo: #3 Using ValueMember & DisplayMember to do fancy comboBoxes
            carNum.DataSource = dataBase.AutoSource();
            carNum.DisplayMember = "carNum";
            carNum.ValueMember = "carNum";

            
            DataGridViewComboBoxColumn drColumn = (DataGridViewComboBoxColumn)dataGridView1.Columns[1];

            drColumn.DataSource = dataBase.DriversSource();
            drColumn.DisplayMember = "surname";
            drColumn.ValueMember = "id";

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataBase.ViezdSource();
            dataGridView1.ReadOnly = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            last_selected = e.RowIndex;
            column_s = e.ColumnIndex;
        }
        public void add_new_row()
        {
            dataBase.add(new Viezd());
            refresh();
        }

        public void add()
        {
            int sel = last_selected;
            if (sel != -1)
            {
                Viezd selected_element;
                selected_element = dataBase.getViezd(dataGridView1.Rows[sel].Cells[0].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[sel].Cells[1].Value), dataGridView1.Rows[sel].Cells[2].Value.ToString());
                if (selected_element == null)
                {
                    selected_element = new Viezd();
                    selected_element.carNum = dataGridView1.Rows[sel].Cells[2].Value.ToString();
                    selected_element.driverId = Convert.ToInt32(dataGridView1.Rows[sel].Cells[1].Value);
                    selected_element.dateViezd = dataGridView1.Rows[sel].Cells[0].Value.ToString();
                    dataBase.add(selected_element);
                }
                selected_element.km = Convert.ToInt32(dataGridView1.Rows[sel].Cells[3].Value);
            }
            refresh();
        }
        int column_s = 0;
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        public void sort()
        {
            switch (column_s)
            {
                case 0:
                    dataGridView1.DataSource = dataBase.ViezdSource().OrderBy(a => a.dateViezd).ToList();
                    break;
                case 1:
                    dataGridView1.DataSource = dataBase.ViezdSource().OrderBy(a => a.driverId).ToList();
                    break;
                case 2:
                    dataGridView1.DataSource = dataBase.ViezdSource().OrderBy(a => a.carNum).ToList();
                    break;
                case 3:
                    dataGridView1.DataSource = dataBase.ViezdSource().OrderBy(a => a.km).ToList();
                    break;
            }
        }
    }
}
