namespace IskontoHesaplamaUyg
{

    public partial class Form1 : Form
    {
        Hesaplama hsp = new Hesaplama();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            txtListe.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbKdv.Items.Add("%1");
            cbKdv.Items.Add("%8");
            cbKdv.Items.Add("%10");
            cbKdv.Items.Add("%18");
            cbKdv.Items.Add("%20");

        }

        private void btnIskontolu_Click(object sender, EventArgs e)
        {

            try
            {
                double listeFiyati = Convert.ToDouble(txtListe.Text);
                double i1 = Convert.ToDouble(txtIsk1.Text);
                double i2 = string.IsNullOrWhiteSpace(txtIsk2.Text) ? 0 : Convert.ToDouble(txtIsk2.Text);
                double i3 = string.IsNullOrWhiteSpace(txtIsk3.Text) ? 0 : Convert.ToDouble(txtIsk3.Text);


                double indirimliFiyat = hsp.IskontoHesapla(listeFiyati, i1, i2, i3);


                MessageBox.Show(btnIskontolu.Text = $"Ýndirimli Fiyat: {indirimliFiyat:C}");
                txtIskontolu.Text = indirimliFiyat.ToString();

                txtListe.Clear();
                txtIsk1.Clear();
                txtIsk2.Clear();
                txtIsk3.Clear();



            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir sayý giriniz.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluþtu: {ex.Message}");
            }

        }

        private void btKdvli_Click(object sender, EventArgs e)
        {
            try
            {
                double urunFiyati = Convert.ToDouble(txtIskontolu.Text);

                double kdvOrani = 0;
                //string secilenKdv = cbKdv.SelectedItem.ToString();


                switch (cbKdv.Text)
                {
                    case "%1":
                        kdvOrani = 1;
                        break;
                    case "%8":
                        kdvOrani = 8;
                        break;
                    case "%10":
                        kdvOrani = 10;
                        break;
                    case "%18":
                        kdvOrani = 18;
                        break;
                    case "%20":
                        kdvOrani = 20;
                        break;
                    default:
                        MessageBox.Show("Lütfen bir KDV oraný seçin.");
                        return;
                }


                double kdvDahil = hsp.KdvliHesapla(urunFiyati, kdvOrani);


                MessageBox.Show($"KDV Dahil Fiyat: {kdvDahil:C}");
                txtIskontolu.Clear();
                cbKdv.Text = "";

            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir sayý giriniz.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluþtu: {ex.Message}");
            }
        }
    }
}
