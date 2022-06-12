using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarClassDB;

namespace CarInterface
{
    public partial class IAuto: UserControl
    {
        private DB dataBase = DB.getInstance();

        int last_selected = -1;
        int column_s = 0;
        public DB carDB
        {
            get
            {
                return dataBase;
            }
        }

        public DataGridView datagridview
        {
            get
            {
                return dataGridView1;
            }
        }

        public IAuto()
        {
            InitializeComponent();

            DataGridViewComboBoxColumn ColumnType = (DataGridViewComboBoxColumn) dataGridView1.Columns[2];
            
            ColumnType.Items.Add(carType.BUS);
            ColumnType.Items.Add(carType.FREIGHTCAR);
            ColumnType.Items.Add(carType.PASSANGERCAR);

            Auto test_1 = new Auto();
            Auto test_2 = new Auto();
            test_1.carNum = "AX8000";
            test_1.brand = "Audi";
            test_1.date = 2020;
            test_1.fuelConsumption = 50;
            test_1.power = 200;
            test_1.type = carType.PASSANGERCAR;


            test_2.carNum = "AX9000";
            test_2.brand = "SOMEBUS";
            test_2.date = 2021;
            test_2.fuelConsumption = 70;
            test_2.power = 200;
            test_2.type = carType.BUS;

            dataBase.add(test_1);
            dataBase.add(test_2);

            refresh();
        }
        public int getSelected()
        {
            return last_selected;
        }

        public void add()
        {
            int sel = last_selected;
            if (sel != -1)
            {
                Auto selected_element;
                selected_element = dataBase.getAuto(dataGridView1.Rows[sel].Cells[0].Value.ToString());
                if(selected_element == null)
                {
                    selected_element = new Auto();
                    selected_element.carNum = dataGridView1.Rows[sel].Cells[0].Value.ToString();
                    dataBase.add(selected_element);
                }
                if(!String.IsNullOrEmpty(dataGridView1.Rows[sel].Cells[1].Value as String)) selected_element.brand = dataGridView1.Rows[sel].Cells[1].Value.ToString() ;
                selected_element.type = (carType) dataGridView1.Rows[sel].Cells[2].Value;
                selected_element.date = Convert.ToInt32(dataGridView1.Rows[sel].Cells[3].Value);
                selected_element.power = Convert.ToInt32(dataGridView1.Rows[sel].Cells[4].Value);
                selected_element.fuelConsumption = Convert.ToInt32(dataGridView1.Rows[sel].Cells[5].Value);
            }
            refresh();
        }

        public void add_new(Auto a)
        {
            dataBase.add(a);
            refresh();
        }
        
        public void delete()
        {
            int sel = getSelected();
            if ((sel != -1)&&(sel<dataGridView1.RowCount))
            {
                Auto selected_element;
                selected_element = dataBase.getAuto(dataGridView1.Rows[sel].Cells[0].Value.ToString());
                dataBase.delete(selected_element);
            }
            refresh();
        }

        public void refresh()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataBase.AutoSource();
            dataGridView1.ReadOnly = false;
        }

        public void clear()
        {
            int s = dataGridView1.Rows.Count;
            for (int i = 0; i < s-1; i++)
            {
                dataGridView1.Rows.RemoveAt(i);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            last_selected = e.RowIndex;
            column_s = e.ColumnIndex;
        }

        public void add_new_row()
        {
            dataBase.add(new Auto());
            refresh();
        }
        public void sort()
        {
            switch (column_s)
            {
                case 0:
                    dataGridView1.DataSource = dataBase.AutoSource().OrderBy(a => a.carNum).ToList();
                    break;
                case 1:
                    dataGridView1.DataSource = dataBase.AutoSource().OrderBy(a => a.brand).ToList();
                    break;
                case 3:
                    dataGridView1.DataSource = dataBase.AutoSource().OrderBy(a => a.date).ToList();
                    break;
                case 4:
                    dataGridView1.DataSource = dataBase.AutoSource().OrderBy(a => a.power).ToList();
                    break;
                case 5:
                    dataGridView1.DataSource = dataBase.AutoSource().OrderBy(a => a.fuelConsumption).ToList();
                    break;
            }           
        }
    }
}
