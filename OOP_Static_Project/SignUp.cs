using MetroFramework.Controls;
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
    public partial class SignUp : MetroForm
    {
        public SignUp()
        {
            InitializeComponent();
        }

        
        private void metroTile1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = txtUsrerName.Text;
            user.Password = txtPassword.Text;
            user.Name = txtName.Text;
            user.LastName = txtLastName.Text;
            menu.users.Add(user);
            temizle(this.Controls);
        }
        public static void temizle(Control.ControlCollection ctrl)
        {
            foreach (Control a in ctrl)
            {
                if (a is MetroTextBox)
                {
                    MetroTextBox mtb = (MetroTextBox)a;
                    mtb.Clear();
                }
                //if (a is MetroTile)
                //{
                //    MetroTile mt = (MetroTile)a; sevdeyle deneme
                //    mt.Text =" ";
                //}
                
            }
           
        }

        private void btnFormClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
