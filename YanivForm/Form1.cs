using CarClassDB.Entity;
using CarInterface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace YanivForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void refresh_all()
        {
            iAuto1.refresh();
            iDrivers1.refresh();
            iViezd1.refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selTab = DataBase.SelectedTab.Name;
            switch (selTab)
            {
                case "Auto":
                    iAuto1.add();
                    break;

                case "Drivers":
                    iDrivers1.add();
                    break;
                case "Viezds":
                    iViezd1.add();
                    break;
            }
            refresh_all();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selTab = DataBase.SelectedTab.Name;
            switch (selTab)
            {
                case "Auto":
                    iAuto1.refresh();
                    break;

                case "Drivers":
                    iDrivers1.refresh();
                    break;
                case "Viezds":
                    iViezd1.refresh();
                    break;
            }
            refresh_all();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string selTab = DataBase.SelectedTab.Name;
            switch (selTab)
            {
                case "Auto":
                    iAuto1.add_new_row();
                    break;

                case "Drivers":
                    iDrivers1.add_new_row();
                    break;
                case "Viezds":
                    iViezd1.add_new_row();
                    break;
            }
            refresh_all();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string selTab = DataBase.SelectedTab.Name;
            switch (selTab)
            {
                case "Auto":
                    iAuto1.delete();
                    break;

                case "Drivers":
                    iDrivers1.delete();
                    break;
                case "Viezds":
                    iViezd1.delete();
                    break;
            }
            refresh_all();
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            string selTab = DataBase.SelectedTab.Name;
            switch (selTab)
            {
                case "Auto":
                    iAuto1.sort();
                    break;

                case "Drivers":
                    iDrivers1.sort();
                    break;
                case "Viezds":
                    iViezd1.sort();
                    break;
            }
            refresh_all();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //save
            saveFileDialog1.Title = "Save file";
            saveFileDialog1.FileName = "serialize";
            saveFileDialog1.Filter = "data files|*.dat|JSON files|*.json|XML files|*.xml";
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                DBSerializer.write(saveFileDialog1.FileName,DB.getInstance().toEntList());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //open
            openFileDialog1.Title = "Open serialized";
            openFileDialog1.FileName = "just_file";
            openFileDialog1.Filter = "data files (*.dat)|*.dat|JSON files(*.json)|*.json|XML files(*.xml)|*.xml";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                DB.getInstance().SeparateList(DBSerializer.read(filePath));
                refresh_all();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            WordSave.Filter = "File Word (*.docx)|*.docx";
            WordSave.FileName = "just_word";
            WordSave.Title = "Save Word";
            WordSave.InitialDirectory = Environment.CurrentDirectory;
            /*if (WordSave.ShowDialog() == DialogResult.OK)
            {
                string filePath = WordSave.FileName;
            }*/
            DataTable[] dt = { GetDataTableFromDGV(iAuto1.datagridview, "Auto"), GetDataTableFromDGV(iViezd1.datagridview, "Viezd"), GetDataTableFromDGV(iDrivers1.datagridview, "Driver") };
            ToOffice.toWord(dt, "D:\\qwerty.docx");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            ExcelSave.Filter  = "File Excel (*.xlsx)|*.xlsx";
            ExcelSave.FileName = "just_table";
            ExcelSave.Title = "Save Excel";
            ExcelSave.InitialDirectory = Environment.CurrentDirectory;

            if (ExcelSave.ShowDialog() == DialogResult.OK)
            {
                string filePath = ExcelSave.FileName;
                DataTable[] dt = { GetDataTableFromDGV(iAuto1.datagridview, "Auto"), GetDataTableFromDGV(iViezd1.datagridview, "Viezd"), GetDataTableFromDGV(iDrivers1.datagridview, "Driver") };
                ToOffice.toExcel(dt, filePath);
            }
        }
        private DataTable GetDataTableFromDGV(DataGridView dgv,string name)
        {
            DataTable dt = new DataTable();
            dt.TableName = name;
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dt.Columns.Add();
                dt.Columns[dt.Columns.Count - 1].ColumnName = dgv.Columns[i].HeaderText;
            }

            for (int i = 0; i < dgv.RowCount; i++)
                dt.Rows.Add();

            for (int i = 0; i < dgv.RowCount; i++)
                for (int j = 0; j < dgv.Columns.Count; j++)
                    dt.Rows[i][j] = dgv[j, i].Value;
                
            
            return dt;
        }

        
    }
}
