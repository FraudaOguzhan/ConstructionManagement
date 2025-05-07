using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SantiyeYönetim
{
    public partial class FrmProjects: Form
    {
        public FrmProjects()
        {
            InitializeComponent();
        }
        SantiyeEntities1 Entities1 = new SantiyeEntities1();
        private void BtnList_Click(object sender, EventArgs e)
        {
            
            var projeler = Entities1.Tbl_Projects.ToList();
            dataGridView1.DataSource = projeler;


        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Tbl_Projects t = new Tbl_Projects();
            t.ProjectName = TxtProjectName.Text;
            t.Location = TxtLocation.Text;
            t.StartDate = dateTimePicker1.Value;
            t.Status = textDurum.Text;
            t.Budget = Convert.ToDecimal(TxtBudget.Text);
            Entities1.Tbl_Projects.Add(t);
            Entities1.SaveChanges();
            MessageBox.Show("Proje Eklendi");




        }

        private void FrmProjects_Load(object sender, EventArgs e)
        {
            dateTimePicker1.BackColor = Color.FromArgb(37, 42, 64);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtID.Text);
            var projeler = Entities1.Tbl_Projects.Find(x);
            Entities1.Tbl_Projects.Remove(projeler);
            Entities1.SaveChanges();
            MessageBox.Show("Proje Silindi");



        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                
                int x = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var projeler = Entities1.Tbl_Projects.Find(x);
                if ( x != null )
                { 
                    projeler.ProjectName = TxtProjectName.Text;
                    projeler.Location = TxtLocation.Text;
                    projeler.StartDate = dateTimePicker1.Value;
                    projeler.Status = textDurum.Text;
                    projeler.Budget = Convert.ToDecimal(TxtBudget.Text);
                    Entities1.SaveChanges();
                    MessageBox.Show("Proje Güncellendi");
                }

                else
                {
                    MessageBox.Show("Proje Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {  MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int projectId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ProjectID"].Value);
            var project = Entities1.Tbl_Projects.Find(projectId);
            if ( projectId != null)
            {
                TxtID.Text = project.ProjectID.ToString();
                TxtProjectName.Text = project.ProjectName;
                TxtLocation.Text = project.Location;
                dateTimePicker1.Value = (DateTime)project.StartDate;
                textDurum.Text = project.Status;
                TxtBudget.Text = project.Budget.ToString();
                
               
            }
            else
            {
                MessageBox.Show("Proje Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
