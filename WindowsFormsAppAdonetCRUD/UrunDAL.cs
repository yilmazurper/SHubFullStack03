using System.Data.SqlClient;

namespace WindowsFormsAppAdonetCRUD
{
    internal class UrunDAL: ortakDal
    {
        public int Add(Product product)

        {
            int sonuc = 0;
            ConnectionKontrol();
            var command = new SqlCommand("insert into products (Name , Description , IsActive , CreateDate , Stock , Price ) values (@Name , @Description , @IsActive , @CreateDate , @Stock , @Price)", _connection);
            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@Description", product.Description);
            command.Parameters.AddWithValue("@IsActive", product.IsActive);
            command.Parameters.AddWithValue("@CreateDate", product.CreateDate);
            command.Parameters.AddWithValue("@Stock", product.Stock);
            command.Parameters.AddWithValue("@Price", product.Price);
            sonuc = command.ExecuteNonQuery(); // sonuc degiskenine sql de etkilenen kayit sayisini ata
            command.Dispose();
            _connection.Close();

            return sonuc;
        }
        public int update(Product product)

        {
            int sonuc = 0;
            ConnectionKontrol();
            var command = new SqlCommand("update products set Name=@Name , Description=@Description , IsActive= @IsActive, CreateDate =@CreateDate , stock=@Stock , price=@Price where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@Description", product.Description);
            command.Parameters.AddWithValue("@IsActive", product.IsActive);
            command.Parameters.AddWithValue("@CreateDate", product.CreateDate);
            command.Parameters.AddWithValue("@Stock", product.Stock);
            command.Parameters.AddWithValue("@Price", product.Price);
            command.Parameters.AddWithValue("@Id", product.Id);
            sonuc = command.ExecuteNonQuery(); // sonuc degiskenine sql de etkilenen kayit sayisini ata
            command.Dispose();
            _connection.Close();

            return sonuc;
        }

        public int Delete(Product product)

        {
            int sonuc = 0;
            ConnectionKontrol();
            var command = new SqlCommand("delete from categories where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Id", product.Id);
            sonuc = command.ExecuteNonQuery(); // sonuc degiskenine sql de etkilenen kayit sayisini ata
            command.Dispose();
            _connection.Close();

            return sonuc;
        }

    }
}
