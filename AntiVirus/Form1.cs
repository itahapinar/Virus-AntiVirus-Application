using Microsoft.Win32;
using System.IO;
using System.Security.Cryptography;
namespace AntiVirus
{
    public partial class Form1 : Form
    {
        string baslangicYolu = @"Software\Microsoft\Windows\CurrentVersion\Run";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTehditOlustur_Click(object sender, EventArgs e)
        {
            try
            {

                RegistryKey key = Registry.CurrentUser.OpenSubKey(baslangicYolu, true);

                if (key != null)
                {
                    key.SetValue("test_trojan", "zararli_arka_plan_islemi.exe");
                    key.Close();

                    listBoxSonuclar.Items.Add("--------------------------------------------------");
                    listBoxSonuclar.Items.Add("⚠️ SİSTEME YENİ BİR TEHDİT SIZDIRILDI!");
                    lblSonuc.Text = "SİSTEM TEHLİKEDE!";
                    lblSonuc.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
        private void btnSistemTara_Click(object sender, EventArgs e)
        {
            listBoxSonuclar.Items.Clear();
            listBoxSonuclar.Items.Add("🔍 Regedit Başlangıç Kayıtları Taranıyor...");
            listBoxSonuclar.Items.Add("--------------------------------------------------");

            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(baslangicYolu, true);

                if (key != null)
                {
                    bool tehditBulundu = false;
                    foreach (string programAdi in key.GetValueNames())
                    {
                        if (programAdi.ToLower().Contains("virus") || programAdi.ToLower().Contains("test"))
                        {
                            tehditBulundu = true;
                            listBoxSonuclar.Items.Add($"🚨 TEHDİT YAKALANDI: [{programAdi}]");
                            listBoxSonuclar.Items.Add("🗑️ Zararlı yazılım Regedit'ten kalıcı olarak siliniyor...");

                            key.DeleteValue(programAdi);

                            listBoxSonuclar.Items.Add("✅ Tehdit başarıyla yok edildi!");
                            lblSonuc.Text = "SİSTEM TEMİZLENDİ VE GÜVENLİ!";
                            lblSonuc.ForeColor = Color.Lime; 
                        }
                        else
                        {

                            listBoxSonuclar.Items.Add($"📂 Güvenli Kayıt: {programAdi}");
                        }
                    }
                    key.Close();


                    if (!tehditBulundu)
                    {
                        listBoxSonuclar.Items.Add("--------------------------------------------------");
                        listBoxSonuclar.Items.Add("✅ Sistem temiz, herhangi bir anormallik bulunamadı.");
                        lblSonuc.Text = "SİSTEM GÜVENLİ.";
                        lblSonuc.ForeColor = Color.Lime;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarama sırasında hata oluştu: " + ex.Message);
            }
        }
    }
}
