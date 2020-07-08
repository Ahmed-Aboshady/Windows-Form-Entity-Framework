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
    public partial class profile : Form
    {
        couress db = new couress();
        public string name { get; set; }
        public string email { get; set; }
        public int password { get; set; }
        public int cid { get; set; }

        public profile(string name,string email,int password,int cid)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.cid =cid ;
            InitializeComponent();
        }
       
        private void profile_Load(object sender, EventArgs e)
        {
            lbl_name.Text = name;
            lbl_emali.Text = email;
            lbl_pass.Text = password.ToString();
            lbl_cousre.Text = cid.ToString();

        }
    }
}
