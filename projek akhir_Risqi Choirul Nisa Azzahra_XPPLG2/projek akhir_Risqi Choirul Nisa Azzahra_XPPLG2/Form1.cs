namespace projek_akhir_Risqi_Choirul_Nisa_Azzahra_XPPLG2
{
    public partial class Form1 : Form
    {
        // ===== VARIABEL & TIPE DATA =====
        private string[] daftarFilm = { "Totoro", "Spirited Away", "Ponyo", "Howl's Moving Castle" };
        private int[] hargaTiket = { 50000, 40000, 35000 }; // VIP, Reguler, Ekonomi
        private string[] jenisKursi = { "VIP", "Reguler", "Ekonomi" };
        private const int MINIMAL_TIKET_DISKON = 5;
        private int totalTransaksiHariIni = 0;
        private int jumlahPelanggan = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inisialisasi ComboBox dengan ARRAY dan PERULANGAN FOR
            cbHargaSatuan.Items.Clear();
            for (int i = 0; i < jenisKursi.Length; i++)
            {
                cbHargaSatuan.Items.Add($"{jenisKursi[i]} - Rp {hargaTiket[i]:N0}");
            }
            cbHargaSatuan.DropDownStyle = ComboBoxStyle.DropDownList;

            // Set tanggal hari ini
            tbTanggal.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            tbTanggal.ReadOnly = true;

            // Tampilkan daftar film dengan PERULANGAN FOREACH
            string infoFilm = "Film Tersedia: ";
            foreach (string film in daftarFilm)
            {
                infoFilm += film + ", ";
            }
            MessageBox.Show(infoFilm.TrimEnd(',', ' '), "Daftar Film", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // PERCABANGAN IF - Validasi input kursi
            string kursi = tbKursi.Text;
            if (!string.IsNullOrEmpty(kursi) && !CekValidasiKursi(kursi))
            {
                MessageBox.Show("Format kursi: A1-A10, B1-B10, dll", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HitungTotal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        // ===== FUNGSI/METHOD SELESAI =====
        private void button3_Click(object sender, EventArgs e)
        {
            // PERCABANGAN IF-ELSE - Validasi transaksi
            if (!string.IsNullOrEmpty(tbKursi.Text) && !string.IsNullOrEmpty(tbTotal.Text))
            {
                // Validasi pembayaran cukup atau tidak
                if (!string.IsNullOrEmpty(tbTotalBayar.Text))
                {
                    int bayar = Convert.ToInt32(tbTotalBayar.Text);
                    int total = Convert.ToInt32(tbTotal.Text);

                    if (bayar < total)
                    {
                        int kurang = total - bayar;
                        MessageBox.Show($"Uang bayar kurang Rp {kurang:N0}\nSilakan tambahkan pembayaran!",
                                      "Pembayaran Kurang", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbTotalBayar.Focus();
                        return;
                    }
                }

                // OPERATOR ARITMATIKA (increment)
                jumlahPelanggan++;
                totalTransaksiHariIni += Convert.ToInt32(tbTotal.Text);

                // OUTPUT - Tampilkan struk
                string struk = "========= STRUK PEMBAYARAN =========\n";
                struk += $"Bioskop Totoro\n";
                struk += $"Tanggal: {tbTanggal.Text}\n";
                struk += $"Pelanggan ke-{jumlahPelanggan}\n";
                struk += $"=====================================\n";
                struk += $"No. Kursi    : {tbKursi.Text}\n";
                struk += $"Jenis Kursi  : {cbHargaSatuan.Text}\n";
                struk += $"Jumlah Tiket : {tbJmlBeli.Text}\n";
                struk += $"Total Harga  : Rp {tbTotal.Text}\n";
                struk += $"Bayar        : Rp {tbTotalBayar.Text}\n";
                struk += $"Kembalian    : Rp {TbKembalian.Text}\n";
                struk += $"=====================================\n";
                struk += $"Total Transaksi Hari Ini: Rp {totalTransaksiHariIni:N0}\n";
                struk += $"Terima Kasih!\nSelamat Menonton!";

                MessageBox.Show(struk, "Transaksi Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
            else
            {
                MessageBox.Show("Lengkapi data transaksi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbTotalBayar_TextChanged(object sender, EventArgs e)
        {
            // Hitung kembalian otomatis
            if (!string.IsNullOrEmpty(tbTotalBayar.Text) && !string.IsNullOrEmpty(tbTotal.Text))
            {
                try
                {
                    int bayar = Convert.ToInt32(tbTotalBayar.Text);
                    int total = Convert.ToInt32(tbTotal.Text);
                    int kembalian = bayar - total;
                    TbKembalian.Text = kembalian >= 0 ? kembalian.ToString() : "0";

                    
                }
                catch { }
            }
        }

        private void tbJmlBeli_TextChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        private void cbHargaSatuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        // ===== FUNGSI/METHOD - MENGHITUNG TOTAL =====
        private void HitungTotal()
        {
            try
            {
                if (!string.IsNullOrEmpty(tbJmlBeli.Text) && cbHargaSatuan.SelectedIndex != -1)
                {
                    int jumlahBeli = Convert.ToInt32(tbJmlBeli.Text);
                    int hargaSatuan = hargaTiket[cbHargaSatuan.SelectedIndex];

                    // OPERATOR ARITMATIKA
                    int totalHarga = jumlahBeli * hargaSatuan;
                    int diskon = 0;

                    // PERCABANGAN IF-ELSE IF
                    if (jumlahBeli >= 10)
                        diskon = 15;
                    else if (jumlahBeli >= MINIMAL_TIKET_DISKON)
                        diskon = 5;

                    // Hitung potongan diskon
                    int potonganDiskon = totalHarga * diskon / 100;
                    int totalSetelahDiskon = totalHarga - potonganDiskon;

                    // OUTPUT
                    tbTotal.Text = totalSetelahDiskon.ToString();

                    // Tampilkan info diskon
                    if (diskon > 0)
                    {
                        MessageBox.Show($"Selamat! Anda dapat diskon {diskon}%\nHemat: Rp {potonganDiskon:N0}",
                                      "Diskon", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Masukkan angka yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===== FUNGSI/METHOD - VALIDASI KURSI =====
        private bool CekValidasiKursi(string kursi)
        {
            // OPERATOR LOGIKA: AND (&&)
            return kursi.Length >= 2 && char.IsLetter(kursi[0]);
        }



        // ===== FUNGSI/METHOD - RESET FORM =====
        private void ResetForm()
        {
            tbKursi.Clear();
            cbHargaSatuan.SelectedIndex = -1;
            tbJmlBeli.Clear();
            tbTotal.Clear(); 
            tbTotalBayar.Clear();
            TbKembalian.Clear();
            tbKursi.Focus();
        }
    }
}