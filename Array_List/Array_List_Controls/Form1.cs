using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Array_List_Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region ArrayList
        /*
        ArrayList: Koleksiyon sınıflarının en genel amaçlı olanıdır.ArrayList bir koleksiyon sınıfı olup çalışması için öncelikle System.Collections sınıfının projeye eklenmiş olması gereki.
        *Dizilere benzer ama eleman sayısının  sabit olmaması ve farklı tipte değerler alabilmesiyle diziden ayrılır,object tipinden nesneler alır
        */
        #endregion

        //Global bir ArrayList tanımalayalım
        ArrayList kisilistesi = new ArrayList();

        //Add ile arrayliste ekleme
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(TextBoxBosMu(txtadsoyad))
            {
                kisilistesi.Add(txtadsoyad.Text);
                txtadsoyad.Text = string.Empty ;
                Yenile();

            }

        }

        //TextBox Kontrolü
        private bool TextBoxBosMu(params Control[] text)
        {
            bool sonuc=false;
            foreach(var item in text)
            {
                if (item.Text != null && item.Text != "" && item.Name == "txtadsoyad")
                    sonuc = true;
                else sonuc = false;
             }
            return sonuc;
        }

        //Değişikliklerden sonra listboxı güncelle ArrayListe göre
        private void Yenile()
        {
            listBox1.Items.Clear();
            //foreach(var item in kisilistesi) liste elemanlarına var tipinden de ulaşabilirdik
            foreach( string item in kisilistesi)
            {
                listBox1.Items.Add(item);
            }
        }

        private void Temizle()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox) (item as TextBox).ResetText();
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (TextBoxBosMu(txtadsoyad))
            {
                kisilistesi.Remove(txtadsoyad);
            }
            Yenile();
            Temizle();
        }
        //Listenin eleman sayısını verir
        private void btncount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Listenin eleman sayısı :"+kisilistesi.Count);
        }


        /*kisilistesi = ArrayList.FixedSize(kisilistesi); // kisilistesi isimli diziye şu ana kadar kaç eleman eklediysek, yani eleman sayısı kaçsa, o sayıya eşitle.
        ***Fixleme işlemini yaptıktan sonra eğer eleman eklemek istersek şöyle bir hata alırız:
          *****  Koleksiyon sabit bir boyuta sahiptir
          *Dizinin sabit kapasiteli olup olmadıgını ogrenmek için
          */
        private void btnisfixedsize_Click(object sender, EventArgs e)
        {
            if(kisilistesi.IsFixedSize)
            {
                MessageBox.Show("Sabit kapasiteli");
            }
            else
            {
                MessageBox.Show("Sabit değil dinamik");
            }
        }

       // Liste sıralanıp tekrar listviewa aktarılır
        private void btnsort_Click(object sender, EventArgs e)
        {
            kisilistesi.Sort();
            Yenile();

        }
        //Listenin sonuna yeni veri ekler
        private void btninsert_Click(object sender, EventArgs e)
        {
            if(TextBoxBosMu(txtadsoyad))
            {
                kisilistesi.Insert(kisilistesi.Count ,txtadsoyad.Text);
                Yenile();
                Temizle();
            }
        }

        //Tüm Listeyi Siler
        private void btnclear_Click(object sender, EventArgs e)
        {
            kisilistesi.Clear();
            Yenile();
        }
        //Liste içerisinde kelime bazlı arama yapar
        private void btncontains_Click(object sender, EventArgs e)
        { 
            if (TextBoxBosMu(txtadsoyad))
            {
                if (kisilistesi.Contains(txtadsoyad.Text)) {
                   
                    MessageBox.Show("Aradığınız değer Array List içerisinde vardır ");
                }
                else
                {
                    MessageBox.Show("Aradığınız değer Array List içerisinde yoktur ");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Aranacak İsmi giriniz:");
            }
        }
    }
}
