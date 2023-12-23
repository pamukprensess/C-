using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marketuyg
{
    public partial class Form1 : Form
    {
        int sutFiyat, sutAdet, sutToplam;
        int unFiyat, unAdet, untoplam;
        int sekerFiyat, sekerAdet, sekerToplam;
        int toplam;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            sutFiyat = Convert.ToInt32(txtsutfiyat.Text);
            sutAdet = Convert.ToInt32(txtsutadet.Text);
            unFiyat = Convert.ToInt32(txtunfiyat.Text);
            unAdet = Convert.ToInt32(txtunadet.Text);
            sekerFiyat = Convert.ToInt32(txtsekerfiyat.Text);
            sekerAdet = Convert.ToInt32(txtsekeradet.Text);  // textbox'lara girilen sayıları değişkenlere atadık.

            sutToplam = sutFiyat * sutAdet;   // süte verilecek toplam ücreti hesapladık.
            textBox3.Text = sutToplam.ToString();  //süte verilecek toplam parayı textbox3'e yazdık.

            untoplam = unFiyat * unAdet; // una verilecek toplam ücreti hesapladık.
            textBox6.Text = untoplam.ToString(); //una verilecek toplam parayı textbox6'ya yazdık.

            sekerToplam = sekerAdet * sekerFiyat; // şekere verilecek toplam ücreti hesapladık.
            textBox9.Text = sekerToplam.ToString(); //şekere verilecek toplam parayı textbox9'a yazdık.


            label8.Text = (sutToplam + untoplam + sekerToplam).ToString(); //->ÖDENECEK TOPLAM TUTARI label8'e yazdık.

            /*if(checkBox1.Checked==true && checkBox2.Checked==true && checkBox3.Checked==true)
            {
                label8.Text = (sutToplam + untoplam + sekerToplam).ToString();
            }*/



            
            //UZUN ÇÖZÜM: tüm checkbox'lar tek tek kontrol edilerek işlem yapılır. if-else if'lerin sırası bozulursa hata olur mu, neden? (!)Not-DEĞİL operatörünün kullanılacağı yer var mı? 

            bool secimSut = checkBox1.Checked; // checkbox1 seçili ise secimSut degiskeni true olur
            bool secimUn = checkBox2.Checked;
            bool secimSeker = checkBox3.Checked;
            

            /*if (secimSut == true && secimUn == true && secimSeker == true)
            {
                label8.Text = (sutToplam + untoplam + sekerToplam).ToString();
            }

            else if (secimSut == true && secimUn == true )
            {
                label8.Text = (sutToplam + untoplam).ToString();
            }
            else if (secimSut == true && secimSeker == true)
            {
                label8.Text = (sutToplam + sekerToplam).ToString();
            }
            else if (secimUn == true && secimSeker == true)
            {
                label8.Text = (untoplam + sekerToplam).ToString();
            }
            else if (secimSut == true && secimSeker == true)
            {
                label8.Text = (sutToplam + sekerToplam).ToString();
            }
            else if (secimSut == true)
            {
                label8.Text = sutToplam.ToString();
            }
            else if (secimUn == true)
            {
                label8.Text = untoplam.ToString();
            }
            else if (secimSeker == true)
            {
                label8.Text = sekerToplam.ToString();
            }
            */


            //KISA ÇÖZÜM: Bir değişken tanımlanır(toplam). İlk dereği 0 atanır. Checkbox'ların seçili olma durumuna göre toplam değişkeni üzerine ürün fiyatları eklenir.

            toplam = 0; //ilk başta ödenecek toplam değere 0 atadık.
             if(checkBox1.Checked==true)
             {
                 toplam += sutToplam; // ilk checkbox seçili ise toplamın içindeki değere sutToplam'ı ekler ve tekrar toplam degiskeninin içine atar.

             }
             if(checkBox2.Checked==true)
             {
                 toplam += untoplam;  //ikinci checkbox seçili ise toplamın içindeki değere sutToplam'ı ekler ve tekrar toplam degiskeninin içine atar.
             }
             if(checkBox3.Checked==true)
             {
                 toplam += sekerToplam;  // üçüncü checkbox seçili ise toplamın içindeki değere sekerToplam'ı ekler ve tekrar toplam degiskeninin içine atar.
             }
             label8.Text = toplam.ToString() + " ₺";  //seçilen ürünlere göre toplam ücreti label8'de gösterir.
            
        }
    }
}
