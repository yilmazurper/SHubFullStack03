using System.Data.SqlClient;

namespace WindowsFormsAppAdonetCRUD
{
    internal class KullanciDal: ortakDal
    {
        public int Add(User user)
        {
            int sonuc = 0;
            ConnectionKontrol();
            var command = new SqlCommand("insert into users (Name , Description , IsActive , CreateDate,Password ,Email ) values (@Name , @Description , @IsActive , @CreateDate,@Password , @Email)", _connection);
            command.Parameters.AddWithValue("@Name", user.Name);
            command.Parameters.AddWithValue("@Surname", user.Surname);
            command.Parameters.AddWithValue("@IsActive", user.IsActive);
            command.Parameters.AddWithValue("@CreateDate", user.CreateDate);
            command.Parameters.AddWithValue("@Password", user.Password);
            command.Parameters.AddWithValue("@Email", user.Email);
            sonuc = command.ExecuteNonQuery(); // sonuc degiskenine sql de etkilenen kayit sayisini ata
            command.Dispose();
            _connection.Close();

            return sonuc;
        }
        public int Update(User user)
        {
            int sonuc = 0;
            ConnectionKontrol();
            var command = new SqlCommand("update users set Name=@Name , Surname=@surname , IsActive=@IsActive , CreateDate=@CreateDate,Password=@Password ,Email=@Email where Is=@Id", _connection);
            command.Parameters.AddWithValue("@Id", user.Id);
            command.Parameters.AddWithValue("@Name", user.Name);
            command.Parameters.AddWithValue("@Description", user.Surname);
            command.Parameters.AddWithValue("@IsActive", user.IsActive);
            command.Parameters.AddWithValue("@CreateDate", user.CreateDate);
            command.Parameters.AddWithValue("@Password", user.Password);
            command.Parameters.AddWithValue("@Email", user.Email);
            sonuc = command.ExecuteNonQuery(); // sonuc degiskenine sql de etkilenen kayit sayisini ata
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
            sonuc = command.ExecuteNonQuery(); // sonuc degiskenine sql de etkilenen kayit sayisini ata
            command.Dispose();
            _connection.Close();

            return sonuc;
        }
    }
}
