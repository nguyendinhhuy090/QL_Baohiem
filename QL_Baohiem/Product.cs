using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace QL_Baohiem
{
    public class Product
    {
        public ObjectId Id { get; set; }
        public string name { get; set; }
        public string manufacture { get; set; }
        public string category { get; set; }
        public double price { get; set; }
    }
}
