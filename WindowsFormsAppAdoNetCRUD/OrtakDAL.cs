using System.Data; // veritabanı işlemleri için gerekli kütüphane
using System.Data.SqlClient;// sql işlemleri için ado.net kütüphanesi

namespace WindowsFormsAppAdoNetCRUD
{
    internal class OrtakDAL
    {
        internal SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB; database=WindowsFormsAppAdoNetCRUD; Integrated Security=True;"); // veritabanımın bulunduğu server bilgisini connection string olarak burada tanımlıyorum.
        internal void ConnectionKontrol()
        {
            if (_connection.State != ConnectionState.Open) //Eğer veritabanı bağlantımızın durumu kapalı ise
                _connection.Open(); //Veritabanı bağlantısını aç
        }
        public DataTable GetDataTable(string sqlSorgu)
        {
            var dt = new DataTable(); // geri döndüreceğimiz data table nesnesi

            ConnectionKontrol(); // veritabanı bağlantısı kapalıysa açacak metod

            var command = new SqlCommand(sqlSorgu, _connection); // server da sql sorgusu çalıştıracak nesne

            SqlDataReader reader = command.ExecuteReader(); // sql komutunu çalıştır ve dönen datayı reader nesnesine aktar.

            dt.Load(reader); // reader içindeki verileri data table nesnesine yükle

            reader.Close(); // reader nesnesini kapat.
            _connection.Close(); // _connection nesnesini kapat.
            command.Dispose(); // komutu yoket

            return dt; // db den okunan verileri gönder.
        }
    }
}
