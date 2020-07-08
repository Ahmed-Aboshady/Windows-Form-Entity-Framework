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
    public partial class regiseration : Form
    {
        public regiseration()
        {
            InitializeComponent();
        }
        couress db = new couress();
        private void regiseration_Load(object sender, EventArgs e)
        {
            
            List<course> sts = db.courses.ToList();
           
           
            cb_sub.DataSource = sts;
            cb_sub.DisplayMember = "crsname";
            cb_sub.ValueMember = "crsid";
           cb_sub_SelectedIndexChanged(null, null);
        }
    

        private void cb_sub_SelectedIndexChanged(object sender, EventArgs e)
        {
           // int catid = int.Parse(cb_sub.Text);
            //cb_sub.DataSource = db.courses.Where(d => d.crsid == catid).ToList();
           
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string emali = txt_emali.Text;
            int pass = int.Parse(txt_pass.Text);
            string cid = cb_sub.SelectedValue.ToString();
            student s = new student() { name = name, emali = emali, password = pass, cid = int.Parse(cid) };
            db.students.Add(s);
            db.SaveChanges();
            login log = new login();
            log.Show();
         
        }
    }
}
