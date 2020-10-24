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
    public partial class FormAdmin : Form
    {
       
        ShopEntities1 _db;
        public FormAdmin()
        {
            
            InitializeComponent();
            _db = new ShopEntities1();
            

            
        }
        
        private void FormAdmin_Load(object sender, EventArgs e)
        {

            
            PersonelGoster();
            KategoriGoster();
            UrunKategorisiEkleme();
            UrunEklemeKisitlari();
            UrunGoster();
            UrunGuncellemeKisitlari();
            UrunKategorisiGuncelleme();
            txtPersonelIDGüncelle.KeyPress+= ShopGiris.WinFormHelpers.TamSayiyaIzinVer;
            txtKategoriKoduGüncelle.KeyPress+= ShopGiris.WinFormHelpers.TamSayiyaIzinVer;
            PersonelKullaniciAdiGoster();
            PersonelKullaniciAdiGosterSifreIcin();
           
        }
       
        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
             bool personelinStatusu = false;
             //RdbStatuPersonel.Checked=true;
            #region Validation
            string hata = "";

            
            if (string.IsNullOrWhiteSpace(txtPersonelAd.Text))
            {
                hata += "Personel adı boş girilemez.\n";
            }
            if (string.IsNullOrWhiteSpace(txtPersonelSoyad.Text))
            {
                hata += "Personel soyadı boş girilemez.\n";
            }
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                hata += "Kullanıcı adı boş girilemez.\n";
            }
            if (string.IsNullOrWhiteSpace(txtPersonelSifre.Text))
            {
                hata += "Şifre boş girilemez.\n";
            }
            
            if (RdbSatatuAdmin.Checked == false && RdbStatuPersonel.Checked == false)
            {
                hata += "Lütfen bir personel statüsü seçiniz.\n";
            }
            if (hata.Length > 0)
            {
                MessageBox.Show(hata);
                return;
            }
            if (RdbStatuPersonel.Checked)
            {
                personelinStatusu = false;
            }
            if (RdbSatatuAdmin.Checked)
            {
                personelinStatusu = true;
            }



            #endregion

            Employee employee=new Employee()
            {
             
             Name=txtPersonelAd.Text,
             Surname=txtPersonelSoyad.Text,
             UserName=txtKullaniciAdi.Text,
             Password=txtPersonelSifre.Text,
             Admin=personelinStatusu
            };
            
            _db.Employees.Add(employee);
            ShopGiris.WinFormHelpers.KontrolluKaydet(_db);
            PersonelGoster();
        }
        private void btnPersonelSil_Click(object sender, EventArgs e)
        {

            #region Validation
            if ( lsvPersoneller.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Silme işlemi öncesinde bir ürün seçmeniz gerekmektedir.");
                return;
            }
            #endregion
            var item = lsvPersoneller.SelectedItems[0];
            Employee employee = (Employee)item.Tag;
            _db.Employees.Remove(employee);
            ShopGiris.WinFormHelpers.KontrolluKaydet(_db);
            PersonelGoster();

            
        }
        private void btnPersonelDüzenle_Click(object sender, EventArgs e)
        {
            #region Validation
            
            string hata = "";

          
            if (string.IsNullOrWhiteSpace(txtPersonelIDGüncelle.Text))
            {
                hata="Personel ID sini lütfen giriniz..";
                
            }
            if (string.IsNullOrWhiteSpace(txtPersonelAdGüncelle.Text))
            {
                hata="Personel adını lütfen giriniz..";
                
            }
            if (string.IsNullOrWhiteSpace(txtPersonelSoyadGüncelle.Text))
            {
                hata="Personel soyadını lütfen giriniz..";
                
            }
            if (string.IsNullOrWhiteSpace(txtPersonelKullaniciAdGüncelle.Text))
            {
                hata="Personel kullanıcı adını lütfen giriniz..";
                
            }
            if (string.IsNullOrWhiteSpace(txtPersonelSifreGüncelle.Text))
            {
                hata="Personel şifresini lütfen giriniz..";

            } 
            
            if (hata.Length > 0)
            {
                MessageBox.Show(hata);
                return;
            }
            #endregion
            int PersonelID=Convert.ToInt32(txtPersonelIDGüncelle.Text);
            
             var GuncellenecekPersonel = _db.Employees.Where(p => p.EmployeesID == PersonelID).FirstOrDefault();

             if (GuncellenecekPersonel == null)
             {
                 MessageBox.Show("Bu ID de bir personel yoktur.");
                 return;
             }
            GuncellenecekPersonel.Name = txtPersonelAdGüncelle.Text;
            GuncellenecekPersonel.Surname = txtPersonelSoyadGüncelle.Text;
            GuncellenecekPersonel.UserName = txtPersonelKullaniciAdGüncelle.Text;
            GuncellenecekPersonel.Password = txtPersonelSifreGüncelle.Text;
             
            
            ShopGiris.WinFormHelpers.KontrolluKaydet(_db);
            PersonelGoster();
        }
        private void PersonelGoster()
        {

            lsvPersoneller.Items.Clear();
            var employees = _db.Employees.ToList();
            foreach (var item in employees)
            {
                string[] degerler = new string[5]
                {
                    item.EmployeesID.ToString(),
                    item.Name,
                    item.Surname,
                    item.UserName,
                    item.Password,
                    
                };
                ListViewItem viewItem = new ListViewItem(degerler);
                viewItem.Tag = item;
                lsvPersoneller.Items.Add(viewItem);
            }

        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            #region Validation
            string hata = "";
           if (string.IsNullOrWhiteSpace(txtKategoriAdi.Text))
            {
                hata += "Kategori adı boş girilemez.\n";
                MessageBox.Show(hata);
                return;
            }
            #endregion
           Category category = new Category()
            {
            CategoryName=txtKategoriAdi.Text
            };
            _db.Categories.Add(category);
            ShopGiris.WinFormHelpers.KontrolluKaydet(_db);
            KategoriGoster();

        }
        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            
            if (lsvKategoriGoruntuleme.SelectedIndices.Count==0)
            {
                MessageBox.Show("Silme işlemi öncesinde bir kategori seçmeniz gerekmektedir.");
                return;
            }
            var item = lsvKategoriGoruntuleme.SelectedItems[0];
           
            Category category = (Category)item.Tag;
            _db.Categories.Remove(category);
            ShopGiris.WinFormHelpers.KontrolluKaydet(_db);
            KategoriGoster();
        }
        private void KategoriGoster() {

            lsvKategoriGoruntuleme.Items.Clear();
            var categories = _db.Categories.ToList();
            foreach (var item in categories)
            {
                string[] degerler = new string[2]
                {
                    item.CategoryID.ToString(),
                    item.CategoryName,
                   
                    
                };
                ListViewItem viewItem = new ListViewItem(degerler);
                viewItem.Tag = item;
                lsvKategoriGoruntuleme.Items.Add(viewItem);
            }
        
        }
        private void btnKategoriDuzenle_Click(object sender, EventArgs e)
        {
            #region Validation
            if (string.IsNullOrWhiteSpace(txtKategoriKoduGüncelle.Text))
            {
                MessageBox.Show(" kategori kodunu  lütfen giriniz..");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtKategoriAdiGüncelle.Text))
            {
                MessageBox.Show("Kategori adini lütfen giriniz..");
                return;
            }
            #endregion
            int KategoryID = Convert.ToInt32(txtKategoriKoduGüncelle.Text);
            var GuncellenecekKategori = _db.Categories.Where(c=>c.CategoryID==KategoryID).FirstOrDefault();

            if (GuncellenecekKategori == null)
            {
                MessageBox.Show("Bu ID de güncellenecek kategori yoktur.");
                return;
            }
            GuncellenecekKategori.CategoryName = txtKategoriAdiGüncelle.Text;
            ShopGiris.WinFormHelpers.KontrolluKaydet(_db);
            KategoriGoster();
            
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            #region Validation
             string hata = "";

            
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text))
            {
                hata += "Urun adı boş girilemez.\n";
            }
            if (string.IsNullOrWhiteSpace(txtUrunBarkod.Text))
            {
                hata += "Barkod boş girilemez.\n";
            }
            if (string.IsNullOrWhiteSpace(txtUrunAlisFiyati.Text))
            {
                hata += "Alış fiyatı boş girilemez.\n";
            }
            if (string.IsNullOrWhiteSpace(txtUrunSatisFiyati.Text))
            {
                hata += "Satış fiyatı boş girilemez.\n";
            }
            if (string.IsNullOrWhiteSpace(txtUrunStok.Text))
            {
                hata += "Stok boş girilemez.\n";
            }
            
            if (hata.Length > 0)
            {
                MessageBox.Show(hata);
                return;
            }
            #endregion
            Product product = new Product() 
            {
              ProductName=txtUrunAdi.Text,
              Barcode=Convert.ToInt32(txtUrunBarkod.Text),
              BuyPrice=Convert.ToDecimal(txtUrunAlisFiyati.Text),
              SellPrice=Convert.ToDecimal(txtUrunSatisFiyati.Text),
              Stock=Convert.ToInt32(txtUrunStok.Text),
              Category=(Category)cmbUrunKategori.SelectedItem
              
            };
            _db.Products.Add(product);
            ShopGiris.WinFormHelpers.KontrolluKaydet(_db);
            UrunGoster();


        }
        private void UrunEklemeKisitlari() {

            txtUrunBarkod.KeyPress+=ShopGiris.WinFormHelpers.TamSayiyaIzinVer;
            txtUrunAlisFiyati.KeyPress+= ShopGiris.WinFormHelpers.OndalikliSayiyaIzinVer;
            txtUrunSatisFiyati.KeyPress += ShopGiris.WinFormHelpers.OndalikliSayiyaIzinVer;
            txtUrunStok.KeyPress += ShopGiris.WinFormHelpers.TamSayiyaIzinVer;
        }
        private void UrunKategorisiEkleme() {

            var categoriler = _db.Categories.ToList();
            cmbUrunKategori.DisplayMember = "CategoryName";
            cmbUrunKategori.ValueMember = "CategoryID";
            cmbUrunKategori.DataSource = categoriler;
            cmbUrunKategori.SelectedIndex = -1;
        }
        private void UrunGoster()
        {
            KategoriGoster();
            lsvUrunGoster.Items.Clear();
             var products = _db.Products.ToList();
                
            foreach (var item in products)
            {
                

                string[] degerler = new string[7]
                {
                    item.ProductID.ToString(),
                    item.ProductName,
                    item.CategoryID.ToString()==null ? "boş bırakılmış" :item.Category.CategoryName,
                    item.Barcode.ToString(),
                    item.BuyPrice.ToString(),
                    item.SellPrice.ToString(),
                    item.Stock.ToString()
                    
                };
                ListViewItem viewItem = new ListViewItem(degerler);
                viewItem.Tag = item;
                 lsvUrunGoster.Items.Add(viewItem);
            }
          
            
            
        }
        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            
            if (lsvUrunGoster.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Silme işlemi öncesinde bir ürün seçmeniz gerekmektedir.");
                return;
            }
            var item = lsvUrunGoster.SelectedItems[0];

            //var product = from p in _db.Products
            //              join c in _db.Categories on p.CategoryID equals c.CategoryID
            //              select p;

            Product product = (Product)item.Tag;

            _db.Products.Remove(product);
            ShopGiris.WinFormHelpers.KontrolluKaydet(_db);
            UrunGoster();
            
        }
        private void UrunGuncellemeKisitlari() {
            txtUrunBarkodGuncelle.KeyPress += ShopGiris.WinFormHelpers.TamSayiyaIzinVer;
            txtUrunAlisFiyatiGuncelle.KeyPress += ShopGiris.WinFormHelpers.OndalikliSayiyaIzinVer;
            txtUrunSatisFiyatiGuncelle.KeyPress += ShopGiris.WinFormHelpers.OndalikliSayiyaIzinVer;
            txtUrunStokGuncelle.KeyPress += ShopGiris.WinFormHelpers.TamSayiyaIzinVer;
        }
        private void btnUrunDuzenle_Click(object sender, EventArgs e)
        {
            
            #region Validation
            if (string.IsNullOrWhiteSpace(txtUrunKodGuncelle.Text))
            {
                MessageBox.Show(" Urun kodunu  lütfen giriniz..");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUrunAdGuncelle.Text))
            {
                MessageBox.Show("Urun adini lütfen giriniz..");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUrunBarkodGuncelle.Text))
            {
                MessageBox.Show("Urun barkodunu lütfen giriniz..");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUrunAlisFiyatiGuncelle.Text))
            {
                MessageBox.Show("Urun alış fiyatını lütfen giriniz..");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUrunSatisFiyatiGuncelle.Text))
            {
                MessageBox.Show("Urun satış fiyatını lütfen giriniz..");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUrunStokGuncelle.Text))
            {
                MessageBox.Show("Urun stoğunu lütfen giriniz..");
                return;
            }
            #endregion

            int UrunID = Convert.ToInt32(txtUrunKodGuncelle.Text);
            var GuncellenecekUrun = _db.Products.Where(p => p.ProductID==UrunID).FirstOrDefault();

            if (GuncellenecekUrun == null) {

                MessageBox.Show("Bu ID de güncellenecek ürün bulunmamaktadır.");
                return;
            }
            GuncellenecekUrun.ProductName = txtUrunAdGuncelle.Text;
            GuncellenecekUrun.Barcode = Convert.ToInt32(txtUrunBarkodGuncelle.Text);
            GuncellenecekUrun.BuyPrice = Convert.ToDecimal(txtUrunAlisFiyatiGuncelle.Text);
            GuncellenecekUrun.SellPrice = Convert.ToDecimal(txtUrunSatisFiyatiGuncelle.Text);
            GuncellenecekUrun.Stock = Convert.ToInt32(txtUrunStokGuncelle.Text);
            GuncellenecekUrun.Category = (Category)cmbUrunKategori.SelectedItem;
            ShopGiris.WinFormHelpers.KontrolluKaydet(_db);
            UrunGoster();
        }
        private void UrunKategorisiGuncelleme()
        {
            
            var categoriler = _db.Categories.ToList();
             cmbUrunKategoriGuncelle.DisplayMember = "CategoryName";
             cmbUrunKategoriGuncelle.ValueMember = "CategoryID";
             cmbUrunKategoriGuncelle.DataSource  = categoriler;
             cmbUrunKategoriGuncelle.SelectedIndex = -1;
        }
        private void tabControlAdmin_Click(object sender, EventArgs e)
        {
            UrunGoster();
            UrunKategorisiGuncelleme();
        }

        private void btnPersonelSatislari_Click(object sender, EventArgs e)
        {
             var PersonelSatislari=from s in _db.Sales
                                             join em in _db.Employees on s.EmployeesID equals em.EmployeesID
                                             join p in _db.Products on s.ProductID equals p.ProductID
                                             select new
                                             {
                                                 p.ProductName,
                                                 em.Name,
                                                 s.Quantity
                                             };
            
            dtvSiparisRaporlama.DataSource = PersonelSatislari.ToList();
        }
        private void btn_PersonelSatislariKullanici_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbPersonelKullaniciAdiSecim.Text))
            {
                MessageBox.Show("Lütfen bir kullanıcı seçiniz.");
                return;
            }
            
            var PersonelSatislariKullanici = from s in _db.Sales
                                              join em in _db.Employees on s.EmployeesID equals em.EmployeesID
                                              join p in _db.Products on s.ProductID equals p.ProductID
                                              where p.ProductName==cmbPersonelKullaniciAdiSecim.Text
                                              select new
                                              {
                                                  p.ProductName,
                                                  em.Name,
                                                  s.Quantity,
                                              };

            if (PersonelSatislariKullanici == null)
            {
                MessageBox.Show("Seçtiğiniz personel ile ilgili herhangi bir satış bulunmamaktadır.");
                return;
            }
           
            dtvPersonelSatislariKullanici.DataSource = PersonelSatislariKullanici.ToList();
          
        }
        private void PersonelKullaniciAdiGoster()
        {

            var employees = _db.Employees.ToList();
            cmbPersonelKullaniciAdiSecim.DisplayMember = "Name";
            cmbPersonelKullaniciAdiSecim.ValueMember = "EmployeesID";
            cmbPersonelKullaniciAdiSecim.DataSource = employees;
            cmbPersonelKullaniciAdiSecim.SelectedIndex = -1;  
        }
        private void PersonelKullaniciAdiGosterSifreIcin() {
            var employees = _db.Employees.ToList();
            cmbPersonelSifre.DisplayMember = "Name";
            cmbPersonelSifre.ValueMember = "EmployeesID";
            cmbPersonelSifre.DataSource= employees;
            cmbPersonelSifre.SelectedIndex = -1;
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
            if (string.IsNullOrWhiteSpace(cmbPersonelSifre.Text))
            {
                hata += "Lütfen bir personel seçiniz.\n";
            }
            if (hata.Length > 0)
            {
                MessageBox.Show(hata);
                return;
            }
            #endregion
           // int PersonelID = Convert.ToInt32(txtPersonelIDGüncelle.Text);

            var SifresiDegisecekPersonel = _db.Employees.Where(p => p.Password==txtEskiSifre.Text       &&p.Name==cmbPersonelSifre.Text).FirstOrDefault();
            SifresiDegisecekPersonel.Password = txtYeniSifre.Text;
           

            ShopGiris.WinFormHelpers.KontrolluKaydet(_db);
            PersonelGoster();

        }

       
        
     

        }
    
    }
