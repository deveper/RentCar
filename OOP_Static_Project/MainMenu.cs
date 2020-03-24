using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOP_Static_Project
{
    public partial class MainMenu : MetroForm
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void cmbCarSelection_SelectedValueChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cmbCarSelection.Text))
            {

            }
            else
            {
                DateTime pickDate = dtPickUp.Value;
                DateTime dropDate = dtDropOf.Value;
                TimeSpan day = dropDate - pickDate;
                int aralik = Convert.ToInt32(day.TotalDays) + 1;
                if (cmbCarSelection.SelectedIndex == 0)
                {
                    int a180 = 250;
                    metroLabel15.Text = (a180 * aralik).ToString() + "TL";
                    metroLabel9.Text = aralik.ToString() + " Gün";
                }
                if (cmbCarSelection.SelectedIndex == 1)
                {
                    int i10 = 150;
                    metroLabel15.Text = (i10 * aralik).ToString() + "TL";
                    
                }
                if (cmbCarSelection.SelectedIndex == 2)
                {
                    int vwPolo = 175;
                    metroLabel15.Text = (vwPolo * aralik).ToString() + "TL";
                   
                }
                if (cmbCarSelection.SelectedIndex == 3)
                {
                    int astra = 200;
                    metroLabel15.Text = (astra * aralik).ToString() + "TL";
                    
                }
                if (cmbCarSelection.SelectedIndex == 4)
                {
                    int a6 = 500;
                    metroLabel15.Text = (a6 * aralik).ToString() + "TL";
                    
                }
                if (cmbCarSelection.SelectedIndex == 5)
                {
                    int kadjar = 300;
                    metroLabel15.Text = (kadjar * aralik).ToString() + "TL";
                    
                }
            }
            int value = cmbCarSelection.SelectedIndex;
            switch (value)
            {
                case 0:
                    pbCarİmage.Image = Properties.Resources.merco;
                    break;
                case 1:
                    pbCarİmage.Image = Properties.Resources.i30;
                    break;
                case 2:
                    pbCarİmage.Image = Properties.Resources.polo;
                    break;
                case 3:
                    pbCarİmage.Image = Properties.Resources.Opel_Astra_K_Sports_Tourer_facelift_2019;
                    break;
                case 4:
                    pbCarİmage.Image = Properties.Resources._2018_2019_Audi_A6;
                    break;
                case 5:
                    pbCarİmage.Image = Properties.Resources._2019renaultkadjar1;
                    break;
                default:
                    break;
            }
            metroLabel12.Visible =true;
            metroLabel12.Text = cmbCarSelection.Text;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            metroLabel11.Visible = true;
            metroLabel14.Visible = true;
            metroLabel11.Text = dtPickUp.Text;
            metroLabel14.Text = dtDropOf.Text;
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            DateTime pickDate = dtPickUp.Value;
            DateTime dropDate = dtDropOf.Value;
            TimeSpan day = dropDate - pickDate;
            int aralik = Convert.ToInt32(day.TotalDays) + 1;
            if (cmbCarSelection.SelectedIndex == 0)
            {
                int a180 = 250;
                metroLabel7.Text = (a180 * aralik).ToString() + "TL";
                metroLabel9.Text = aralik.ToString() + " Gün";
            }
            if (cmbCarSelection.SelectedIndex == 1)
            {
                int i10 = 150;
                metroLabel7.Text = (i10 * aralik).ToString() + "TL";
                metroLabel9.Text = aralik.ToString() + " Gün";
            }
            if (cmbCarSelection.SelectedIndex == 2)
            {
                int vwPolo = 175;
                metroLabel7.Text = (vwPolo * aralik).ToString() + "TL";
                metroLabel9.Text = aralik.ToString() + " Gün";
            }
            if (cmbCarSelection.SelectedIndex == 3)
            {
                int astra = 200;
                metroLabel7.Text = (astra * aralik).ToString() + "TL";
                metroLabel9.Text = aralik.ToString() + " Gün";
            }
            if (cmbCarSelection.SelectedIndex == 4)
            {
                int a6 = 500;
                metroLabel7.Text = (a6 * aralik).ToString() + "TL";
                metroLabel9.Text = aralik.ToString() + " Gün";
            }
            if (cmbCarSelection.SelectedIndex == 5)
            {
                int kadjar = 300;
                metroLabel7.Text = (kadjar * aralik).ToString() + "TL";
                metroLabel9.Text = aralik.ToString() + " Gün";
            }

        }

        private void cmbPickUp_SelectedValueChanged(object sender, EventArgs e)
        {
            metroLabel10.Visible = true;
            metroLabel10.Text = cmbPickUp.Text;
        }

        private void cmbDropOf_SelectedValueChanged(object sender, EventArgs e)
        {
            metroLabel13.Visible = true;
            metroLabel13.Text = cmbDropOf.Text;
        }

        private void dtPickUp_ValueChanged(object sender, EventArgs e)
        {
            metroLabel11.Text = dtPickUp.Text;
        }

        private void dtDropOf_ValueChanged(object sender, EventArgs e)
        {
            metroLabel14.Text = dtDropOf.Text;
        }
    }
}
