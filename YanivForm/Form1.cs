using CarInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }
}
