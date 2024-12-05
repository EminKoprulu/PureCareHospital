using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti() //sql bağlantısı sınıfı
        {
            SqlConnection baglan = new SqlConnection("Data Source=Bilgisayar\\MSSQLSERVER01;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open(); //sınıfı çağırınca bağlantı açık olarak gelsin
            return baglan;
            //sqlbaglantisi: sınıfın adı
            //baglanti: metodun adı
            //baglan: nesnenin adı
        }
    }
}
