using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace QL_Baohiem
{
    public class DataProvider
    {
        public MongoClient client;
        
        public DataProvider() { }
        public string getConnectionString()
        {
            string conn = "mongodb://localhost:27017";
            return conn;
        }
        public MongoClient getClient()
        {
            client = new MongoClient(getConnectionString());
            return client;
        }
        public IMongoDatabase getDatabase()
        {
            getConnectionString();
            getClient();
            IMongoDatabase database = client.GetDatabase("db1");
            return database;
        }
        public void ConnectToMongoDB()
        {
            try
            {
                getConnectionString();
                getClient();
                getDatabase();
                MessageBox.Show("Connection Successful !");
            }
            catch
            {
                MessageBox.Show("Connection Failed !");
            }
        }
    }
}
