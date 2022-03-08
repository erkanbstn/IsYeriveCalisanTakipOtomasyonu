using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakipProjesi.Baglanti
{
    public static class ConBag
    {
        public static byte ID { get; set; }
        public static byte ID2 { get; set; }
        public static byte ID3 { get; set; }
        public static IsTakipEntities it = new IsTakipEntities();
        public static SqlConnection it2 = new SqlConnection("Data Source=GEOPC\\SQLEXPRESS;Initial Catalog=IsTakip;Integrated Security=True;");
    }
}
