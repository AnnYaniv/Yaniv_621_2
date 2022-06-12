
namespace YanivForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.DataBase = new System.Windows.Forms.TabControl();
            this.Auto = new System.Windows.Forms.TabPage();
            this.iAuto1 = new CarInterface.IAuto();
            this.Drivers = new System.Windows.Forms.TabPage();
            this.iDrivers1 = new CarInterface.IDrivers();
            this.Viezds = new System.Windows.Forms.TabPage();
            this.iViezd1 = new CarInterface.IViezd();
            this.Sort = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.configControl1 = new CarInterface.ConfigControl();
            this.button7 = new System.Windows.Forms.Button();
            this.ExcelSave = new System.Windows.Forms.SaveFileDialog();
            this.WordSave = new System.Windows.Forms.SaveFileDialog();
            this.button8 = new System.Windows.Forms.Button();
            this.DataBase.SuspendLayout();
            this.Auto.SuspendLayout();
            this.Drivers.SuspendLayout();
            this.Viezds.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(841, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(841, 44);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(756, 12);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "add new row";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(843, 100);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 30);
            this.button4.TabIndex = 6;
            this.button4.Text = "delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DataBase
            // 
            this.DataBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataBase.Controls.Add(this.Auto);
            this.DataBase.Controls.Add(this.Drivers);
            this.DataBase.Controls.Add(this.Viezds);
            this.DataBase.Location = new System.Drawing.Point(12, 12);
            this.DataBase.Name = "DataBase";
            this.DataBase.SelectedIndex = 0;
            this.DataBase.Size = new System.Drawing.Size(705, 502);
            this.DataBase.TabIndex = 7;
            // 
            // Auto
            // 
            this.Auto.Controls.Add(this.iAuto1);
            this.Auto.Location = new System.Drawing.Point(4, 22);
            this.Auto.Name = "Auto";
            this.Auto.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Auto.Size = new System.Drawing.Size(697, 476);
            this.Auto.TabIndex = 0;
            this.Auto.Text = "Car";
            this.Auto.UseVisualStyleBackColor = true;
            // 
            // iAuto1
            // 
            this.iAuto1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iAuto1.Location = new System.Drawing.Point(0, 2);
            this.iAuto1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iAuto1.Name = "iAuto1";
            this.iAuto1.Size = new System.Drawing.Size(695, 472);
            this.iAuto1.TabIndex = 0;
            // 
            // Drivers
            // 
            this.Drivers.Controls.Add(this.iDrivers1);
            this.Drivers.Location = new System.Drawing.Point(4, 22);
            this.Drivers.Name = "Drivers";
            this.Drivers.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Drivers.Size = new System.Drawing.Size(697, 476);
            this.Drivers.TabIndex = 1;
            this.Drivers.Text = "Drivers";
            this.Drivers.UseVisualStyleBackColor = true;
            // 
            // iDrivers1
            // 
            this.iDrivers1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iDrivers1.Location = new System.Drawing.Point(-2, 0);
            this.iDrivers1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iDrivers1.Name = "iDrivers1";
            this.iDrivers1.Size = new System.Drawing.Size(697, 474);
            this.iDrivers1.TabIndex = 0;
            // 
            // Viezds
            // 
            this.Viezds.Controls.Add(this.iViezd1);
            this.Viezds.Location = new System.Drawing.Point(4, 22);
            this.Viezds.Name = "Viezds";
            this.Viezds.Size = new System.Drawing.Size(697, 476);
            this.Viezds.TabIndex = 2;
            this.Viezds.Text = "Travels";
            this.Viezds.UseVisualStyleBackColor = true;
            // 
            // iViezd1
            // 
            this.iViezd1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iViezd1.Location = new System.Drawing.Point(0, 2);
            this.iViezd1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iViezd1.Name = "iViezd1";
            this.iViezd1.Size = new System.Drawing.Size(695, 472);
            this.iViezd1.TabIndex = 0;
            // 
            // Sort
            // 
            this.Sort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Sort.Location = new System.Drawing.Point(756, 44);
            this.Sort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(81, 29);
            this.Sort.TabIndex = 8;
            this.Sort.Text = "Sort";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(756, 150);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 31);
            this.button5.TabIndex = 10;
            this.button5.Text = "Open";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.LightGreen;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(843, 150);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(79, 31);
            this.button6.TabIndex = 11;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // configControl1
            // 
            this.configControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.configControl1.BackColor = System.Drawing.SystemColors.Control;
            this.configControl1.Location = new System.Drawing.Point(744, 280);
            this.configControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.configControl1.Name = "configControl1";
            this.configControl1.Size = new System.Drawing.Size(178, 230);
            this.configControl1.TabIndex = 9;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.Color.Green;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(843, 194);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(79, 30);
            this.button7.TabIndex = 12;
            this.button7.Text = "Excel";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.BackColor = System.Drawing.Color.SteelBlue;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(756, 194);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(79, 30);
            this.button8.TabIndex = 13;
            this.button8.Text = "Word";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 526);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.configControl1);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.DataBase);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Yaniv_621_2";
            this.DataBase.ResumeLayout(false);
            this.Auto.ResumeLayout(false);
            this.Drivers.ResumeLayout(false);
            this.Viezds.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabControl DataBase;
        private System.Windows.Forms.TabPage Auto;
        private CarInterface.IAuto iAuto1;
        private System.Windows.Forms.TabPage Drivers;
        private CarInterface.IDrivers iDrivers1;
        private System.Windows.Forms.TabPage Viezds;
        private CarInterface.IViezd iViezd1;
        private System.Windows.Forms.Button Sort;
        private CarInterface.ConfigControl configControl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.SaveFileDialog ExcelSave;
        private System.Windows.Forms.SaveFileDialog WordSave;
        private System.Windows.Forms.Button button8;
    }
}

