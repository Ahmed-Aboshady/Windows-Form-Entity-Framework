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
    public partial class admin : Form
    {
        couress c = new couress();
        public admin()
        {
            InitializeComponent();
        }
        
        private void admin_Load(object sender, EventArgs e)
        {
            couress db = new couress();
            List<course> sts = db.courses.ToList();
           dataGridView1.DataSource = sts;
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            string name = txt_name.Text;
            int dur = int.Parse(txt_dur.Text);
            course s = new course() { crsid = id, crsname = name, duration = dur};
            c.courses.Add(s);
            c.SaveChanges();
            MessageBox.Show("Done");
            dataGridView1.DataSource = c.courses.ToList();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            var cos = (from s in c.courses where s.crsid == id select s).First();
            c.courses.Remove(cos);
            c.SaveChanges();
            MessageBox.Show("Done Delete");
            dataGridView1.DataSource = c.courses.ToList();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            var cos = (from s in c.courses where s.crsid == id select s).First();
            cos.crsname = txt_name.Text;
            cos.duration = int.Parse(txt_dur.Text);
            c.SaveChanges();
            MessageBox.Show("update Done");
            dataGridView1.DataSource = c.courses.ToList();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            var cos = (from s in c.courses where s.crsid == id select s).First();
            txt_name.Text = cos.crsname;
            txt_dur.Text = cos.duration.ToString();
            
        }
    }
}
