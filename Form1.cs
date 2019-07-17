using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YonlendirmeGirisi_HW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Eger ilk textbox'a "Admin","Moderator","Yonetici","CEO","Baskan" 
            //degerleri girilirse "Yönetim Paneline Yönlendiriliyorsunuz..."
            //"Uye" girilirse "Ana Sayfaya Yonlendiriliyorsunuz...";
            //Harici bir durumda "Bu Sayfayı Görme Yetkiniz Yok!";
        }

        private void BtnGiriş_Click(object sender, EventArgs e)
        {
            string veri = txtUser.Text.ToLower();
            switch (veri)

            {
                case "admin":
                case "moderator":
                case "Yonetici":
                case "ceo":
                case "baskan":
                    MessageBox.Show("Yonetim Paneline Yönlendiriliyorsunuz");
                    break;

                case "uye":
                    MessageBox.Show("Ana Sayfaya Yonlendiriliyorsunuz");
                    break;




                default:
                    MessageBox.Show("Bu Sayfayı Görme Yetkiniz Yok");
                    break;
            }
            txtUser.Clear();
        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
