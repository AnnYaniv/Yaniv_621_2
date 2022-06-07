using CarClassDB.Entity;
using CarInterface;
using System;
using System.Collections.Generic;
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
            openFileDialog1.Filter = "data files (*.dat)|*.dat|JSON files(*.json)|*.json|XML files(*.xml)|*.xml";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
               
                List<Entity> to_Serialize;
                to_Serialize = DBSerializer.read(filePath);

                DB.getInstance().SeparateList(to_Serialize);
                refresh_all();
            }
        }
    }
}
