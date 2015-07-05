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
            skin.SkinFile = "MP10.ssk";
            skin.Active = true;
            InitializeComponent();
            getDataGridView();
        }

        private void btnquery_Click(object sender, EventArgs e)
        {
            DataTable dt = da.registrationInfo(dateTimePicker1.Value, dateTimePicker2.Value);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            add = new Add(0,this);
            add.Owner = this;
            add.ShowDialog();   
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.RowHeadersWidth = 60;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int j = i + 1;
                dataGridView1.Rows[i].HeaderCell.Value = j.ToString();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             /*判断点击行标题与列标题*/
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                /*传员工工号过去*/
                int  id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Add add = new Add(id,this);
                add.Show();
            }
        }

        public void getDataGridView()
        {
            DataTable dt = new DataTable();
            dt=da.registrationInfo("");
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;
        }   
    }
}
