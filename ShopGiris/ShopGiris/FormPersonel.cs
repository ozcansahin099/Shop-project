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
    public partial class FormPersonel : Form
    {
        ShopEntities1 _db;
        public FormPersonel()
        {
            InitializeComponent();
            _db = new ShopEntities1();
            SatisGoster();
        }
        public string personelAdi { get; set; }

        private void FormPersonel_Load(object sender, EventArgs e)
        {
            GeriIadeUrunler();
            MessageBox.Show(personelAdi);
        }

        private void btnSatisListesineEkle_Click(object sender, EventArgs e)
        {
            #region Validation

            if (string.IsNullOrWhiteSpace(txtBarkodNo.Text))
            {
                MessageBox.Show("Lütfen barkod numarası giriniz");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSatisAdedi.Text))
            {
                MessageBox.Show("Lütfen satış adedini giriniz.");
                return;
            }

            #endregion
            int barkodno = Convert.ToInt32(txtBarkodNo.Text);
            var product=_db.Products.Where(p=>p.Barcode==barkodno).FirstOrDefault();

            //var employee =_db.Employees.Where(p => p.UserName == txtBoxKullaniciAdi.Text
            //    && p.Password ==txtBoxSifre.Text && p.Admin == false).FirstOrDefault();
            
            
            Sale sales = new Sale()
            {
              ProductID=product.ProductID,
              Quantity=Convert.ToInt32(txtSatisAdedi.Text),
              EmployeesID=Convert.ToInt32(personelAdi),
              
            };
            _db.Sales.Add(sales);
            ShopGiris.WinFormHelpers.KontrolluKaydet(_db);
            SatisGoster();
        }
        private void SatisGoster() {
            lsvUrunGoster.Items.Clear();

            var sales = _db.Sales.ToList();
            foreach (var item in sales)
            {
                string[] degerler = new string[7]{
              item.SalesID.ToString(),
              item.Product.ProductName,
              item.Product.Category.CategoryName,
              item.Product.Barcode.ToString(),
              item.Product.SellPrice.ToString(),
              item.Product.Stock.ToString(),
              item.Quantity.ToString(),
              };
                ListViewItem viewItem = new ListViewItem(degerler);
                viewItem.Tag = item;
                lsvUrunGoster.Items.Add(viewItem);
            }

        }
        private void btnSatisListesindenUrunSil_Click(object sender, EventArgs e)
        {
            #region Validation
            if (lsvUrunGoster.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Silme işlemi öncesinde bir ürün seçmeniz gerekmektedir.");
                return;
            }
            #endregion
            var item = lsvUrunGoster.SelectedItems[0];
            Sale sales = (Sale)item.Tag;
            _db.Sales.Remove(sales);
            ShopGiris.WinFormHelpers.KontrolluKaydet(_db);
            SatisGoster();

        }
        
        private void btnKasayiKapat_Click(object sender, EventArgs e)
        {
            tabControlPersonel.Enabled = false;
            
        }
        private void btnYaptigimSatislar_Click(object sender, EventArgs e)
        {

             
            var sales = from s in _db.Sales
                        join p in _db.Products on s.ProductID equals p.ProductID
                        join em in _db.Employees on s.EmployeesID equals em.EmployeesID
                        where em.UserName==personelAdi
                        select new
                        {
                            s.SalesID,
                            em.Name,
                            p.ProductName,
                            p.Category.CategoryName,
                            p.Barcode,
                            p.SellPrice,
                            p.Stock,
                            s.Quantity,
                        };
             dtgvYaptigimSatislar.DataSource = sales.ToList();
        }

        private void btnİadeEt_Click(object sender, EventArgs e)
        {
            #region Validation
            if (string.IsNullOrWhiteSpace(txtSatisID.Text))
            {
                MessageBox.Show("Lütfen bir satış ID si giriniz.");
                return;
            }
            #endregion
            

            int satisNo=Convert.ToInt32(txtSatisID.Text);
            var sales = _db.Sales.Where(s => s.SalesID == satisNo).FirstOrDefault();
            ReturnProduct returnProduts = new ReturnProduct()
            {
                SalesID = Convert.ToInt32(txtSatisID.Text),
                ReturnPrice=sales.Product.SellPrice,
            };

            _db.ReturnProducts.Add(returnProduts);
            ShopGiris.WinFormHelpers.KontrolluKaydet(_db);

            GeriIadeUrunler();
            
        }
        private void GeriIadeUrunler() {

            
            var returnSales = from r in _db.ReturnProducts
                        join s in _db.Sales on r.SalesID equals s.SalesID
                        join p in _db.Products on s.ProductID equals p.ProductID
                        select new
                        {
                            s.SalesID,
                            p.ProductName,
                            p.Category.CategoryName,
                            p.Barcode,
                            p.SellPrice,
                            p.Stock,
                            s.Quantity,
                        };
            dtgvUrunIadeGoster.DataSource = returnSales.ToList();
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            #region Validation
            string hata = "";


            if (string.IsNullOrWhiteSpace(txtEskiSifre.Text))
            {
                hata += "Eski şifre boş girilemez.\n";
            }
            if (string.IsNullOrWhiteSpace(txtYeniSifre.Text))
            {
                hata += "yeni şifre boş girilemez.\n";
            }
            if (string.IsNullOrWhiteSpace(txtYeniSifreTekrari.Text))
            {
                hata += "yeni şifre tekrarı boş girilemez.\n";
            }
            if (txtYeniSifreTekrari.Text != txtYeniSifre.Text)
            {
                hata += "yeni şifre tekrarı ile uyuşmuyor.Lütfen doğru yazınız.\n";
            }
            if (hata.Length > 0)
            {
                MessageBox.Show(hata);
                return;
            }
            #endregion
            

            var SifresiDegisecekPersonel = _db.Employees.Where(p => p.Password == txtEskiSifre.Text && p.UserName ==personelAdi).FirstOrDefault();
            SifresiDegisecekPersonel.Password =txtYeniSifreTekrari.Text;


            ShopGiris.WinFormHelpers.KontrolluKaydet(_db);
            
        }

        
        
    }
}

