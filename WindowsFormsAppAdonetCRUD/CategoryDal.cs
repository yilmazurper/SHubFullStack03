using System.Data.SqlClient;

namespace WindowsFormsAppAdonetCRUD
{
    internal class CategoryDal : ortakDal
    {
        public int Add(Category category)
        {
            int sonuc = 0;
            ConnectionKontrol();
            var command = new SqlCommand("insert into categories (Name , Description , IsActive , CreateDate ) values (@Name , @Description , @IsActive , @CreateDate )", _connection);
            command.Parameters.AddWithValue("@Name" , category.Name);
            command.Parameters.AddWithValue("@Description", category.Description);
            command.Parameters.AddWithValue("@IsActive", category.IsActive);
            command.Parameters.AddWithValue("@CreateDate", category.CreateDate);
            sonuc =command.ExecuteNonQuery(); // sonuc degiskenine sql de etkilenen kayit sayisini ata
            command.Dispose();
            _connection.Close();

            return sonuc;
        }
        public int update(Category category)
        {
            int sonuc = 0;
            ConnectionKontrol();
            var command = new SqlCommand("update categories set Name=@Name , Description=@Description , IsActive= @IsActive, CreateDate =@CreateDate  where Id=@Id,  ", _connection);
            command.Parameters.AddWithValue("@Id", category.Id);
            command.Parameters.AddWithValue("@Name", category.Name);
            command.Parameters.AddWithValue("@Description", category.Description);
            command.Parameters.AddWithValue("@IsActive", category.IsActive);
            command.Parameters.AddWithValue("@CreateDate", category.CreateDate);
            sonuc = command.ExecuteNonQuery(); // sonuc degiskenine sql de etkilenen kayit sayisini ata
            command.Dispose();
            _connection.Close();

            return sonuc;
        }
        public int Delete(Category category)
        {
            int sonuc = 0;
            ConnectionKontrol();
            var command = new SqlCommand("delete from categories where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Id", category.Id);
            sonuc = command.ExecuteNonQuery(); // sonuc degiskenine sql de etkilenen kayit sayisini ata
            command.Dispose();
            _connection.Close();

            return sonuc;
        }
    }
}
