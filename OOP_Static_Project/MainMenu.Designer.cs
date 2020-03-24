namespace OOP_Static_Project
{
    partial class MainMenu
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
            this.cmbPickUp = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbDropOf = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtPickUp = new MetroFramework.Controls.MetroDateTime();
            this.dtDropOf = new MetroFramework.Controls.MetroDateTime();
            this.cmbCarSelection = new MetroFramework.Controls.MetroComboBox();
            this.pbCarİmage = new System.Windows.Forms.PictureBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btnRent = new MetroFramework.Controls.MetroTile();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarİmage)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPickUp
            // 
            this.cmbPickUp.FormattingEnabled = true;
            this.cmbPickUp.ItemHeight = 23;
            this.cmbPickUp.Items.AddRange(new object[] {
            "İstanbul Havalimanı",
            "Maslak ",
            "4. Levent"});
            this.cmbPickUp.Location = new System.Drawing.Point(99, 63);
            this.cmbPickUp.Name = "cmbPickUp";
            this.cmbPickUp.Size = new System.Drawing.Size(247, 29);
            this.cmbPickUp.TabIndex = 0;
            this.cmbPickUp.UseSelectable = true;
            this.cmbPickUp.SelectedValueChanged += new System.EventHandler(this.cmbPickUp_SelectedValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(165, 41);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Pick Up Location";
            // 
            // cmbDropOf
            // 
            this.cmbDropOf.FormattingEnabled = true;
            this.cmbDropOf.ItemHeight = 23;
            this.cmbDropOf.Items.AddRange(new object[] {
            "İstanbul Havalimanı",
            "Maslak ",
            "4. Levent"});
            this.cmbDropOf.Location = new System.Drawing.Point(407, 63);
            this.cmbDropOf.Name = "cmbDropOf";
            this.cmbDropOf.Size = new System.Drawing.Size(250, 29);
            this.cmbDropOf.TabIndex = 0;
            this.cmbDropOf.UseSelectable = true;
            this.cmbDropOf.SelectedValueChanged += new System.EventHandler(this.cmbDropOf_SelectedValueChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(462, 41);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Drop Of Location";
            // 
            // dtPickUp
            // 
            this.dtPickUp.Location = new System.Drawing.Point(99, 127);
            this.dtPickUp.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtPickUp.Name = "dtPickUp";
            this.dtPickUp.Size = new System.Drawing.Size(247, 29);
            this.dtPickUp.TabIndex = 2;
            this.dtPickUp.ValueChanged += new System.EventHandler(this.dtPickUp_ValueChanged);
            // 
            // dtDropOf
            // 
            this.dtDropOf.Location = new System.Drawing.Point(410, 127);
            this.dtDropOf.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDropOf.Name = "dtDropOf";
            this.dtDropOf.Size = new System.Drawing.Size(250, 29);
            this.dtDropOf.TabIndex = 2;
            this.dtDropOf.ValueChanged += new System.EventHandler(this.dtDropOf_ValueChanged);
            // 
            // cmbCarSelection
            // 
            this.cmbCarSelection.FormattingEnabled = true;
            this.cmbCarSelection.ItemHeight = 23;
            this.cmbCarSelection.Items.AddRange(new object[] {
            "A - Mercedes - A180 - Dizel - Otomatik",
            "A - Hyundai - i30 - Benzin - Otomatik",
            "B - VolksWagen - Polo  - Benzin - Otomatik",
            "C - Opel - Astra - Dizel - Otomatik",
            "D - Audi - A6 - Dizel - Otomatik",
            "SUV - Renault - Kadjar - Dizel - Otomatik"});
            this.cmbCarSelection.Location = new System.Drawing.Point(99, 191);
            this.cmbCarSelection.Name = "cmbCarSelection";
            this.cmbCarSelection.Size = new System.Drawing.Size(561, 29);
            this.cmbCarSelection.TabIndex = 0;
            this.cmbCarSelection.UseSelectable = true;
            this.cmbCarSelection.SelectedValueChanged += new System.EventHandler(this.cmbCarSelection_SelectedValueChanged);
            // 
            // pbCarİmage
            // 
            this.pbCarİmage.Location = new System.Drawing.Point(99, 238);
            this.pbCarİmage.Name = "pbCarİmage";
            this.pbCarİmage.Size = new System.Drawing.Size(226, 226);
            this.pbCarİmage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCarİmage.TabIndex = 3;
            this.pbCarİmage.TabStop = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(334, 169);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(86, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Car Selection";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(179, 105);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(68, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Start Date";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(494, 105);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 19);
            this.metroLabel5.TabIndex = 1;
            this.metroLabel5.Text = "End Date";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(276, 11);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(81, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Total Coast:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(359, 11);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(153, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Please complate all field";
            // 
            // btnRent
            // 
            this.btnRent.ActiveControl = null;
            this.btnRent.Location = new System.Drawing.Point(99, 485);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(561, 39);
            this.btnRent.TabIndex = 7;
            this.btnRent.Text = "RENT";
            this.btnRent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRent.UseSelectable = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(379, 238);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(76, 19);
            this.metroLabel8.TabIndex = 8;
            this.metroLabel8.Text = "Total Days:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(462, 238);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(153, 19);
            this.metroLabel9.TabIndex = 9;
            this.metroLabel9.Text = "Please complate all field";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Silver;
            this.metroPanel1.Controls.Add(this.metroLabel17);
            this.metroPanel1.Controls.Add(this.metroLabel16);
            this.metroPanel1.Controls.Add(this.metroLabel15);
            this.metroPanel1.Controls.Add(this.metroLabel14);
            this.metroPanel1.Controls.Add(this.metroLabel13);
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(331, 260);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(329, 204);
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.Silver;
            this.metroLabel10.Location = new System.Drawing.Point(19, 38);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(88, 19);
            this.metroLabel10.TabIndex = 2;
            this.metroLabel10.Text = "metroLabel10";
            this.metroLabel10.UseCustomBackColor = true;
            this.metroLabel10.Visible = false;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.Silver;
            this.metroLabel11.Location = new System.Drawing.Point(19, 70);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(86, 19);
            this.metroLabel11.TabIndex = 3;
            this.metroLabel11.Text = "metroLabel11";
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.Visible = false;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.Silver;
            this.metroLabel12.Location = new System.Drawing.Point(19, 114);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(88, 19);
            this.metroLabel12.TabIndex = 4;
            this.metroLabel12.Text = "metroLabel12";
            this.metroLabel12.UseCustomBackColor = true;
            this.metroLabel12.Visible = false;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.Color.Silver;
            this.metroLabel13.Location = new System.Drawing.Point(182, 38);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(88, 19);
            this.metroLabel13.TabIndex = 5;
            this.metroLabel13.Text = "metroLabel13";
            this.metroLabel13.UseCustomBackColor = true;
            this.metroLabel13.Visible = false;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.BackColor = System.Drawing.Color.Silver;
            this.metroLabel14.Location = new System.Drawing.Point(182, 70);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(88, 19);
            this.metroLabel14.TabIndex = 6;
            this.metroLabel14.Text = "metroLabel14";
            this.metroLabel14.UseCustomBackColor = true;
            this.metroLabel14.Visible = false;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.BackColor = System.Drawing.Color.Silver;
            this.metroLabel15.Location = new System.Drawing.Point(148, 167);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(33, 19);
            this.metroLabel15.TabIndex = 7;
            this.metroLabel15.Text = "0 TL";
            this.metroLabel15.UseCustomBackColor = true;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.metroLabel16.Location = new System.Drawing.Point(19, 9);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(130, 19);
            this.metroLabel16.TabIndex = 11;
            this.metroLabel16.Text = "Pick Up Informations";
            this.metroLabel16.UseCustomBackColor = true;
            this.metroLabel16.UseCustomForeColor = true;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.BackColor = System.Drawing.Color.Silver;
            this.metroLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.metroLabel17.Location = new System.Drawing.Point(182, 9);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(139, 19);
            this.metroLabel17.TabIndex = 11;
            this.metroLabel17.Text = "Drop Off Informations";
            this.metroLabel17.UseCustomBackColor = true;
            this.metroLabel17.UseCustomForeColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 537);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.pbCarİmage);
            this.Controls.Add(this.dtDropOf);
            this.Controls.Add(this.dtPickUp);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cmbDropOf);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbCarSelection);
            this.Controls.Add(this.cmbPickUp);
            this.Name = "MainMenu";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCarİmage)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbPickUp;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbDropOf;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime dtPickUp;
        private MetroFramework.Controls.MetroDateTime dtDropOf;
        private MetroFramework.Controls.MetroComboBox cmbCarSelection;
        private System.Windows.Forms.PictureBox pbCarİmage;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTile btnRent;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel16;
    }
}