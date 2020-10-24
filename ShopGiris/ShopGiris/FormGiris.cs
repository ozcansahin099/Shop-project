using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopGiris
{
    public partial class FormGiris : Form
    {
        ShopEntities1 db;
        
        public FormGiris()
        {
            db=new ShopEntities1();
            InitializeComponent();
         
            
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            #region Validation
            if (txtBoxKullaniciAdi.Text == "")
            {

                MessageBox.Show("Kullanıcı adı girişi zorunludur.");
                return;
            }
            if (txtBoxSifre.Text == "")
            {

                MessageBox.Show("Şifre girişi zorunludur.");
                return;

            }
            #endregion
            
            

            var employee = db.Employees.Where(p => p.UserName == txtBoxKullaniciAdi.Text
                && p.Password ==txtBoxSifre.Text && p.Admin == false).FirstOrDefault();

            var admin = db.Employees.Where(p => p.UserName == txtBoxKullaniciAdi.Text
                && p.Password==txtBoxSifre.Text && p.Admin == true).FirstOrDefault();


            string personel = txtBoxKullaniciAdi.Text;


            if (employee == null && admin == null)
            {
                MessageBox.Show("Müşteri Bulunamadı.");
            }
            else if (employee != null)
            {
                FormPersonel frmp = new FormPersonel();
                frmp.personelAdi = txtBoxKullaniciAdi.Text;
                frmp.Show();
                this.Hide();

            }

            else if (admin != null)
            {

                FormAdmin frm = new FormAdmin();
                frm.Show();
                this.Hide();
            }
        }
    }
}
