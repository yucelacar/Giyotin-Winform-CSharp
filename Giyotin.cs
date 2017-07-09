using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.IO;

namespace Giyotin
{
    public partial class Giyotin : Form
    {
        int olusacakLabel = 60;
        public Giyotin()
        {
            InitializeComponent();
            btnReset.Visible = false; //uygulama basladıgında reset görünmüyor.
        }

        List<Label> isimler = new List<Label>();
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIsim.Text))
            {
                lstListe.Items.Add(txtIsim.Text.Trim());
                txtIsim.Clear();
                txtIsim.Focus();
            }
            else
            {
                MessageBox.Show("Listeye eklenecek bir veri giriniz!");
                txtIsim.Clear();
                txtIsim.Focus();
            }
            
        }
        

        //degiskenler
        Random rdm = new Random();
        int locationx;
        int locationy;
        int renk1;
        int renk2;
        int renk3;
        SoundPlayer player = new SoundPlayer();//Reset isleminde susturmak için dısarda tanımladım.

        private void btnGiotin_Click(object sender, EventArgs e)
        {
            btnReset.Visible = true;
            if (lstListe.Items.Count > 0)
            {
                btnEkle.Visible = false;
                txtIsim.Visible = false;
                lstListe.Visible = false;
                btnGiotin.Visible = false;
                LabelOlustur(olusacakLabel);
                tmrCalıstır.Start();

                string path = "music.wav"; // Çalmasini istediginiz ses dosyasinin yolu.Debug da.
                player.SoundLocation = path;
                player.Play();

            }
            else
            {
                MessageBox.Show("Listeye eleman eklemeniz gerekmekte.");
            }


        }

        void LabelOlustur(int kacisimyazsın)
        {
            for (int i = 0; i < kacisimyazsın; i++)
            {

                Label lbl = new Label();
                lbl.Size = new Size(70, 30);
                lbl.Font = new Font("Arial", 13f);

                locationx = rdm.Next(0, (this.Width - 90));
                locationy = rdm.Next(0, (this.Height -40));

                renk1 = rdm.Next(0, 255);
                renk2 = rdm.Next(0, 255);
                renk3 = rdm.Next(0, 255);

                int sanslısayi = rdm.Next(0, lstListe.Items.Count);
                lbl.Text = lstListe.Items[sanslısayi].ToString();
                lbl.Location = new Point(locationx, locationy);
                lbl.Name = "Label" + i;
                lbl.ForeColor = Color.FromArgb(renk1, renk2, renk3);
                isimler.Add(lbl);
            }
        }

        int sayac = 0;
        private void tmrCalıstır_Tick(object sender, EventArgs e)
        {
            this.Controls.Add(isimler[sayac]);
            sayac++;
            if (sayac == olusacakLabel-1)
            {
                tmrCalıstır.Stop();
                sayac = 60;//tik sırasında azalacagı için.
                tmrSil.Start();
            }
        }

        //Silme islemi için Ayrı bir Timer. Sayac burda 60 olarak devam ediyor.
        int sayi;
       
        private void tmrSil_Tick(object sender, EventArgs e)
        {
            sayi = rdm.Next(0, isimler.Count);
            if (isimler.Count > 1)
            {

                this.Controls.Remove(isimler[sayi]);
                isimler.Remove(isimler[sayi]);  //her tick hem form ekranından hem list den isim siliniyor.
                sayac--;
                //kalan eleman sayısına gore intervalleri artacak.
                if (sayac < 45)
                {
                    tmrSil.Interval = 600;
                }
                if (sayac < 30)
                {
                    tmrSil.Interval = 800;
                }
                if (sayac < 20)
                {
                    tmrSil.Interval = 1000;
                }
                if (sayac < 10)
                {
                    tmrSil.Interval = 1200;
                }
                if (sayac < 5)
                {
                    tmrSil.Interval = 1500;
                }


            }
            else
            {
                tmrSil.Stop();
                this.Controls.Remove(isimler[sayi]);
                tmrGoster.Start();

            }


        }

        //Dizide kalan son elemanı büyüterek gösterimek için bir Timer.
        float font = 0;
        int sizex = 60;
        int sizey = 30;
        private void tmrGoster_Tick(object sender, EventArgs e)
        {

            Label sonLabel = isimler[0];
            sonLabel.Location = new Point(this.Width / 2, this.Height / 2);
            font = font + 1;
            sonLabel.Font = new Font("Arial", font);
            sizex = sizex + 5;
            sizey = sizey + 3;
            sonLabel.Size = new Size(sizex, sizey);
            this.Controls.Add(sonLabel);
                     
            if (font == 50)    //Font ve sayac 50 oldugunda duracak.
            {
                tmrGoster.Stop();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tmrGoster.Stop();
            tmrCalıstır.Stop();
            tmrSil.Stop();
            player.Stop();
            //eger ekranda birden cok label varken basılırsa.
            if (isimler.Count>1)
            {
                this.Controls.Clear();
                this.Controls.Add(lstListe);
                this.Controls.Add(txtIsim);
                this.Controls.Add(btnEkle);
                this.Controls.Add(btnGiotin);                
            }

            this.Controls.Remove(isimler[0]); //tek item olması durumunda calısacak.
            btnEkle.Visible = true;
            txtIsim.Visible = true;
            txtIsim.Focus();
            lstListe.Items.Clear();
            lstListe.Visible = true;
            btnGiotin.Visible = true;
            btnReset.Visible = false;
        }
    }
}
