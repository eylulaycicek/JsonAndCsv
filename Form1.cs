using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSONveCSVDosyalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<personel> liste = new List<personel>();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                personel p = new personel();
                p.Id = Guid.NewGuid();
                p.Isim = FakeData.NameData.GetFirstName();
                p.Soyisim = FakeData.NameData.GetSurname();
                p.Email = p.Isim + "." + p.Soyisim + "@" + FakeData.NetworkData.GetDomain();
                p.Telefon = FakeData.PhoneNumberData.GetPhoneNumber();
                liste.Add(p);
            }
        }

        private void btn_json_olustur_Click(object sender, EventArgs e)
        {
            if(!Directory.Exists("C:\\JASON")) //böyle bir klasör yoksa create et diyeceğiz
            {
                Directory.CreateDirectory("C:\\JASON\\");
            }

            string veri=Newtonsoft.Json.JsonConvert.SerializeObject(liste);
            File.WriteAllText("C:\\JASON\\personeller.json",veri);

                
        }

        private void btn_json_oku_Click(object sender, EventArgs e)
        {

            string veri= File.ReadAllText("C:\\JASON\\personeller.json");

            List<personel> personeller = Newtonsoft.Json.JsonConvert.DeserializeObject<List<personel>>(veri); //veriyi bu tipte deserialize et dedik
            lst_personeller.DataSource=personeller;
            /*lst_personeller.DisplayMember = "Isim"; *///ovverride yerine bunu da yapabiliriz ama sadece tek bir kolon yazdırabiliriz
        }

        private void btn_csvolustur_Click(object sender, EventArgs e)
        {
            if (!File.Exists("C:\\CSV\\personeller.csv"))
            {
                StreamWriter dosya = new StreamWriter("C:\\CSV\\personeller.csv");
                CsvWriter csv = new CsvWriter(dosya, CultureInfo.InvariantCulture, false);
                csv.WriteHeader(typeof(personel));

                csv.WriteRecords(liste);


                dosya.Close();
            }
        }

        private void btn_csvoku_Click(object sender, EventArgs e)
        {
            StreamReader dosya = new StreamReader("C:\\CSV\\personeller.csv");
            CsvReader oku = new CsvReader(dosya,CultureInfo.InvariantCulture, false);
           List<personel> personeller= oku.GetRecords<personel>().ToList();
            lst_personeller.DataSource = personeller;


        }
    }
}
