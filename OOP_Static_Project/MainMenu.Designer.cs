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
            this.components = new System.ComponentModel.Container();
            this.cmbPickUp = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbDropOf = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtPickUp = new MetroFramework.Controls.MetroDateTime();
            this.dtDropOf = new MetroFramework.Controls.MetroDateTime();
            this.cmbCarSelection = new MetroFramework.Controls.MetroComboBox();
            this.imgCars = new System.Windows.Forms.ImageList(this.components);
            this.pbCarİmage = new System.Windows.Forms.PictureBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarİmage)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPickUp
            // 
            this.cmbPickUp.FormattingEnabled = true;
            this.cmbPickUp.ItemHeight = 23;
            this.cmbPickUp.Location = new System.Drawing.Point(134, 116);
            this.cmbPickUp.Name = "cmbPickUp";
            this.cmbPickUp.Size = new System.Drawing.Size(200, 29);
            this.cmbPickUp.TabIndex = 0;
            this.cmbPickUp.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(177, 94);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Pick Up Location";
            this.metroLabel1.Visible = false;
            // 
            // cmbDropOf
            // 
            this.cmbDropOf.FormattingEnabled = true;
            this.cmbDropOf.ItemHeight = 23;
            this.cmbDropOf.Location = new System.Drawing.Point(399, 116);
            this.cmbDropOf.Name = "cmbDropOf";
            this.cmbDropOf.Size = new System.Drawing.Size(210, 29);
            this.cmbDropOf.TabIndex = 0;
            this.cmbDropOf.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(449, 94);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Drop Of Location";
            this.metroLabel2.Visible = false;
            // 
            // dtPickUp
            // 
            this.dtPickUp.Location = new System.Drawing.Point(134, 177);
            this.dtPickUp.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtPickUp.Name = "dtPickUp";
            this.dtPickUp.Size = new System.Drawing.Size(200, 29);
            this.dtPickUp.TabIndex = 2;
            // 
            // dtDropOf
            // 
            this.dtDropOf.Location = new System.Drawing.Point(399, 177);
            this.dtDropOf.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDropOf.Name = "dtDropOf";
            this.dtDropOf.Size = new System.Drawing.Size(210, 29);
            this.dtDropOf.TabIndex = 2;
            // 
            // cmbCarSelection
            // 
            this.cmbCarSelection.FormattingEnabled = true;
            this.cmbCarSelection.ItemHeight = 23;
            this.cmbCarSelection.Items.AddRange(new object[] {
            "A - Mercedes - A180 - Dizel - Otomatik",
            "A - Hyundai - i10 - Benzin - Otomatik",
            "B - VolksWagen - Polo  - Benzin - Otomatik",
            "C - Opel - Astra - Dizel - Otomatik",
            "D - Audi - A6 - Dizel - Otomatik",
            "SUV - Renault - Kadjar - Dizel - Otomatik"});
            this.cmbCarSelection.Location = new System.Drawing.Point(134, 246);
            this.cmbCarSelection.Name = "cmbCarSelection";
            this.cmbCarSelection.Size = new System.Drawing.Size(475, 29);
            this.cmbCarSelection.TabIndex = 0;
            this.cmbCarSelection.UseSelectable = true;
            this.cmbCarSelection.SelectedValueChanged += new System.EventHandler(this.cmbCarSelection_SelectedValueChanged);
            // 
            // imgCars
            // 
            this.imgCars.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pbCarİmage
            // 
            this.pbCarİmage.Location = new System.Drawing.Point(134, 294);
            this.pbCarİmage.Name = "pbCarİmage";
            this.pbCarİmage.Size = new System.Drawing.Size(475, 147);
            this.pbCarİmage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCarİmage.TabIndex = 3;
            this.pbCarİmage.TabStop = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(313, 221);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(86, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Car Selection";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(177, 155);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(68, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Start Date";
            this.metroLabel4.Visible = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(440, 155);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 19);
            this.metroLabel5.TabIndex = 1;
            this.metroLabel5.Text = "End Date";
            this.metroLabel5.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 448);
            this.Controls.Add(this.metroLabel3);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbCarİmage)).EndInit();
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
        private System.Windows.Forms.ImageList imgCars;
        private System.Windows.Forms.PictureBox pbCarİmage;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}