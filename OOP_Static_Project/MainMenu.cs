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
    }
}
