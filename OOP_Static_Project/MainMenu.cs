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
            int value = cmbCarSelection.SelectedIndex;
            switch (value)
            {
                case 0:
                    pbCarİmage.Image = imgCars.Images[3];
                    break;
                case 1:
                    pbCarİmage.Image = imgCars.Images[0];
                    break;
                case 2:
                    pbCarİmage.Image = imgCars.Images[1];
                    break;
                case 3:
                    pbCarİmage.Image = imgCars.Images[2];
                    break;
                case 4:
                    pbCarİmage.Image = imgCars.Images[4];
                    break;
                case 5:
                    pbCarİmage.Image = imgCars.Images[5];
                    break;
                default:

                    break;
            }

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

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
    }
}
