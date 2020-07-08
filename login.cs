using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoursesCenter
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        couress db = new couress();

        private void byn_detalis_Click(object sender, EventArgs e)
        {
            int pass = int.Parse(txt_pass.Text);
            if (txt_name.Text == "admin" &&  pass == 123)
            {
                admin a = new admin();
                a.ShowDialog();

            }
            var user = (from s in db.students where s.name == txt_name.Text select s).First();
            if (user.password ==int.Parse( txt_pass.Text))
            {
                this.Hide();
                profile p = new profile(user.name, user.emali, user.password, user.cid);
                p.ShowDialog();
                
            }
            
            else
                MessageBox.Show("Please Enter a valid user name and password", "Invalid");
        }
    }
}
