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
    }
}
