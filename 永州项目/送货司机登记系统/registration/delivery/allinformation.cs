using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SpeechLib;

namespace delivery
{
    public partial class allinformation : Form
    {
        private static Add add;
        dal da = new dal();
        public allinformation()
        {
            Sunisoft.IrisSkin.SkinEngine skin = new Sunisoft.IrisSkin.SkinEngine();
            skin.SkinFile = "Wave.ssk";
            skin.Active = true;
            InitializeComponent();
            DataTable dt = da.registrationInfo();
            dataGridView1.DataSource = dt;
        }

        private void btnquery_Click(object sender, EventArgs e)
        {
            DataTable dt = da.registrationInfo(dateTimePicker1.Value, dateTimePicker2.Value);
            dataGridView1.DataSource = dt;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                add.Show();
                add.Focus();
            }
            catch
            {
                add = new Add();
                add.Show();
            }
        }
    }
}
