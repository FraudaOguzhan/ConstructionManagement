using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SantiyeYönetim
{
    public partial class FrmMaterial: Form
    {
        public FrmMaterial()
        {
            InitializeComponent();
        }

        SantiyeEntities1 Entities1 = new SantiyeEntities1();

        private void BtnList_Click(object sender, EventArgs e)
        {
            var malzemeler = Entities1.Tbl_Materials.ToList();
            dataGridView1.DataSource = malzemeler;
            MessageBox.Show("Malzemeler Listelendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Tbl_Materials t = new Tbl_Materials();
            t.MaterialName = TxtMaterialName.Text;
            t.Unit = TxtUnit.Text;
            t.UnitPrice = Convert.ToDecimal(TxtPrice.Text);
            t.StockQuantity = Convert.ToDecimal(TxtStock.Text);
            Entities1.Tbl_Materials.Add(t);
            Entities1.SaveChanges();
            MessageBox.Show("Malzeme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var malzemeler = Entities1.Tbl_Materials.ToList();



        }

        private void FrmMaterial_Load(object sender, EventArgs e)
        {
            var context = new SantiyeEntities1();
            int TopLamStok = (int)context.Tbl_Materials.Sum(m => m.StockQuantity ?? 0);
            label6.Text = TopLamStok.ToString();

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var malzeme = Entities1.Tbl_Materials.Find(x);
            if ( malzeme != null )
            {
                Entities1.Tbl_Materials.Remove(malzeme);
                Entities1.SaveChanges();
                MessageBox.Show("Malzeme Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int malzemeID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["MaterialID"].Value);
            var project = Entities1.Tbl_Materials.Find(malzemeID);
            if (malzemeID != null)
            {
                TxtID.Text = project.MaterialID.ToString();
                TxtMaterialName.Text = project.MaterialName.ToString();
                TxtUnit.Text = project.Unit.ToString();
                TxtPrice.Text = project.UnitPrice.ToString();
                TxtStock.Text = project.StockQuantity.ToString();

            }
            else
            {
                MessageBox.Show("Proje Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var malzeme = Entities1.Tbl_Materials.Find(x);

                if (malzeme != null)
                {
                    malzeme.MaterialName = TxtMaterialName.Text;
                    malzeme.Unit = TxtUnit.Text;
                    malzeme.UnitPrice = Convert.ToDecimal(TxtPrice.Text);
                    malzeme.StockQuantity = Convert.ToDecimal(TxtStock.Text);

                    Entities1.SaveChanges();
                    MessageBox.Show("Malzeme Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Malzeme bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Sayısal alanlara geçerli bir değer giriniz.\nHata: " + ex.Message, "Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Bir nesneye erişmeye çalışırken hata oluştu.\nHata: " + ex.Message, "Null Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
