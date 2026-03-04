using System.Data.SqlClient;

namespace WindowsFormsAppAdoNetCRUD
{
    internal class KullaniciDAL : OrtakDAL
    {
        public int Add(User user)
        {
            int sonuc = 0;
            ConnectionKontrol();
            var command = new SqlCommand("insert into users (Name, Surname, IsActive, CreateDate, Password, Email) values (@Name, @Surname, @IsActive, @CreateDate, @Password, @Email)", _connection);
            command.Parameters.AddWithValue("@Name", user.Name);
            command.Parameters.AddWithValue("@Surname", user.Surname);
            command.Parameters.AddWithValue("@IsActive", user.IsActive);
            command.Parameters.AddWithValue("@CreateDate", user.CreateDate);
            command.Parameters.AddWithValue("@Password", user.Password);
            command.Parameters.AddWithValue("@Email", user.Email);
            sonuc = command.ExecuteNonQuery(); // sonuc değişkenine sql de etkilenen kayıt sayısını ata
            command.Dispose();
            _connection.Close();

            return sonuc;
        }
        public int Update(User user)
        {
            int sonuc = 0;
            ConnectionKontrol();
            var command = new SqlCommand("update users set Name=@Name, Surname=@Surname, IsActive=@IsActive, CreateDate=@CreateDate, Password=@Password, Email=@Email where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Id", user.Id);
            command.Parameters.AddWithValue("@Name", user.Name);
            command.Parameters.AddWithValue("@Surname", user.Surname);
            command.Parameters.AddWithValue("@IsActive", user.IsActive);
            command.Parameters.AddWithValue("@CreateDate", user.CreateDate);
            command.Parameters.AddWithValue("@Password", user.Password);
            command.Parameters.AddWithValue("@Email", user.Email);
            sonuc = command.ExecuteNonQuery(); // sonuc değişkenine sql de etkilenen kayıt sayısını ata
            command.Dispose();
            _connection.Close();

            return sonuc;
        }
        public int Delete(User user)
        {
            int sonuc = 0;
            ConnectionKontrol();
            var command = new SqlCommand("delete from users where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Id", user.Id);
            sonuc = command.ExecuteNonQuery(); // sonuc değişkenine sql de etkilenen kayıt sayısını ata
            command.Dispose();
            _connection.Close();

            return sonuc;
        }
    }
}
