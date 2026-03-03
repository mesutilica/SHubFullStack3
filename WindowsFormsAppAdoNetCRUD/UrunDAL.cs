using System.Data.SqlClient;

namespace WindowsFormsAppAdoNetCRUD
{
    internal class UrunDAL : OrtakDAL
    {
        public int Add(Product product)
        {
            int sonuc = 0;
            ConnectionKontrol();
            var command = new SqlCommand("insert into products (Name, Description, IsActive, CreateDate, Stock, Price) values (@Name, @Description, @IsActive, @CreateDate, @Stock, @Price)", _connection);
            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@Description", product.Description);
            command.Parameters.AddWithValue("@IsActive", product.IsActive);
            command.Parameters.AddWithValue("@CreateDate", product.CreateDate);
            command.Parameters.AddWithValue("@Stock", product.Stock);
            command.Parameters.AddWithValue("@Price", product.Price);
            sonuc = command.ExecuteNonQuery(); // sonuc değişkenine sql de etkilenen kayıt sayısını ata
            command.Dispose();
            _connection.Close();

            return sonuc;
        }
        public int Update(Product product)
        {
            int sonuc = 0;
            ConnectionKontrol();
            var command = new SqlCommand("update products set Name=@Name, Description=@Description, IsActive=@IsActive, CreateDate=@CreateDate, Stock=@Stock, Price=@Price where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@Description", product.Description);
            command.Parameters.AddWithValue("@IsActive", product.IsActive);
            command.Parameters.AddWithValue("@CreateDate", product.CreateDate);
            command.Parameters.AddWithValue("@Stock", product.Stock);
            command.Parameters.AddWithValue("@Price", product.Price);
            command.Parameters.AddWithValue("@Id", product.Id);
            sonuc = command.ExecuteNonQuery(); // sonuc değişkenine sql de etkilenen kayıt sayısını ata
            command.Dispose();
            _connection.Close();

            return sonuc;
        }
        public int Delete(Product product)
        {
            int sonuc = 0;
            ConnectionKontrol();
            var command = new SqlCommand("delete from products where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Id", product.Id);
            sonuc = command.ExecuteNonQuery(); // sonuc değişkenine sql de etkilenen kayıt sayısını ata
            command.Dispose();
            _connection.Close();

            return sonuc;
        }
    }
}
