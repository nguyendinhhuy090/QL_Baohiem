using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace QL_Baohiem
{
    public partial class Form1 : Form
    {
        DataProvider da = new DataProvider();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            da.ConnectToMongoDB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var collection = da.getDatabase().GetCollection<Product>("products");
            List<Product> products = collection.Find(new BsonDocument()).ToList();
            dataGridView1.DataSource = products;

        }
    }
}
