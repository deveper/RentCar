using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
namespace OOP_Static_Project
{
    public partial class menu : MetroForm
    {
        public menu()
        {
            InitializeComponent();
        }
        public static List<User> users = new List<User>();
        public static List<string> passwords = new List<string>();

        private void menu_Load(object sender, EventArgs e)
        {
   
        }

        private void lblUye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp sgn = new SignUp();
            sgn.ShowDialog();

        }

        private void btnFormClose_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (users.Exists(x => x.UserName == txtGiris.Text) && users.Exists(x => x.Password == txtSifre.Text))
            {
                MetroMessageBox.Show(this,"Başarılı Giriş Yaptınız...");
                this.Hide();
                MainMenu mn = new MainMenu();
                mn.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this,"Hatalı Giriş");
                SignUp.temizle(this.Controls);

            }
        }
    }
}
