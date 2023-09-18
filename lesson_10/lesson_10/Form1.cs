using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.ServiceModel.Web;
using System.Runtime.Serialization.Json;
using System.IO;

namespace lesson_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product1 = new Product(10, "Стол", 4500);
            label1.Text = string.Format("Код = {0}\n Наименование = {1}\n Цена = {2}\n",
                product1.code, product1.name, product1.price);

            DataContractJsonSerializer ps = new DataContractJsonSerializer(typeof(Product));

            Stream memory = new MemoryStream();
            ps.WriteObject(memory, product1);

            memory.Position = 0;
            StreamReader streamReader = new StreamReader(memory);
            string s = streamReader.ReadToEnd();

            textBox1.Text = s;

            string s1 = "{\"code\":11,\"name\":\"Стул\",\"price\":500}";

            Stream stream = new MemoryStream(Encoding.UTF8.GetBytes(s1));

            label1.Text += string.Format("\n n = {0}", stream.Length);

            Product product2 = (Product)ps.ReadObject(stream);

            label1.Text += string.Format("\n Код = {0}\n Наименование = {1} \n Цена = {2}",
                product2.code, product2.name, product2.price);
        }
    }


    [DataContract]
    public class Product
    {
        [DataMember]
        public int code;
        [DataMember]
        public string name;
        [DataMember]
        public double price;

        public Product(int code, string name, double price)
        {
            this.code = code;
            this.name = name;
            this.price = price;
        }


    }
}
