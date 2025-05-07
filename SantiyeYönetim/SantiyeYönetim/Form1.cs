using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; 



namespace SantiyeYönetim
{
    public partial class Form1: Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);







        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 25, 25));
            PnlNav.Height = BtnDashboard.Height;
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
         //   BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Ana Sayfa";
            this.PnlFormLoader.Controls.Clear();
            frmDashboard frm = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnDashboard.Height;
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Ana Sayfa";
            this.PnlFormLoader.Controls.Clear();
            frmDashboard frm = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm);
            frm.Show();


        }

        private void BtnAnalytics_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnProje.Height;
            PnlNav.Top = BtnProje.Top;
            BtnProje.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Proje Yönetimi";
            this.PnlFormLoader.Controls.Clear();
            FrmProjects frm = new FrmProjects() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void BtnCalendar_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnMaterial.Height;
            PnlNav.Top = BtnMaterial.Top;
            BtnMaterial.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Malzeme Yönetimi";
            this.PnlFormLoader.Controls.Clear();
            FrmMaterial frm = new FrmMaterial() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void BtnContact_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnEmployee.Height;
            PnlNav.Top = BtnEmployee.Top;
            BtnEmployee.BackColor = Color.FromArgb(46, 51, 73);


            lblTitle.Text = "Personel Listesi";
            this.PnlFormLoader.Controls.Clear();
            FrmEmployee frm = new FrmEmployee() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnSettings.Height;
            PnlNav.Top = BtnSettings.Top;
            BtnSettings.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Settings";
            this.PnlFormLoader.Controls.Clear();
            FrmSettings frm = new FrmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm);
            frm.Show();

        }


        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnAnalytics_Leave(object sender, EventArgs e)
        {
            BtnProje.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnCalendar_Leave(object sender, EventArgs e)
        {
            BtnMaterial.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnContact_Leave(object sender, EventArgs e)
        {
            BtnEmployee.BackColor = Color.FromArgb(24, 30, 54);
        }
      


        private void BtnSettings_Leave(object sender, EventArgs e)
        {
            BtnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnHarcama_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnAttendance.Height;
            PnlNav.Top = BtnAttendance.Top;
            BtnAttendance.BackColor = Color.FromArgb(46, 51, 73);
            
            lblTitle.Text = "Günlük Puantaj";
            this.PnlFormLoader.Controls.Clear();
            FrmAttendance frm = new FrmAttendance() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void BtnDokuman_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnDokuman.Height;
            PnlNav.Top = BtnDokuman.Top;
            BtnDokuman.BackColor = Color.FromArgb(46, 51, 73);
            
            lblTitle.Text = "Görevlendirme";
            this.PnlFormLoader.Controls.Clear();
            FrmDokuman frm = new FrmDokuman() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void BtnHarcama_Leave_1(object sender, EventArgs e)
        {
            BtnAttendance.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void BtnDokuman_Leave_1(object sender, EventArgs e)
        {
            BtnDokuman.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
