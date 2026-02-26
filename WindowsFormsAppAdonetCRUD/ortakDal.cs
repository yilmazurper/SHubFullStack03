using System.Data; //  veritabani islemleri icin gerekli kutuphane
using System.Data.SqlClient; // sql islmeleri icin ado.net kutuphanesi


namespace WindowsFormsAppAdonetCRUD
{
    internal class ortakDal
    {
         internal SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB; Database=WindowsFormsAppAdoNetCRUD; integrated Security=True; "); //veri tabanimizin bulundugu server bilgisini conection steing olarak burada tanimliyorum
        internal void ConnectionKontrol()
        { 
            if (_connection.State != ConnectionState.Open) // veritabani baglantimizin durumu kapali ise 
                _connection.Open(); //veri tabani baglantisini ac
        }
        public DataTable GetDataTable(string SqlSorgu)
        { 
            var dt = new DataTable();

            ConnectionKontrol();

            var command  = new SqlCommand(SqlSorgu, _connection);

            SqlDataReader reader =command.ExecuteReader(); //sql komutunu calistir ve donen detayi reader nesnesine aktar

            dt.Load(reader); //reader icindeki verileri datatable nesnesne yukle

            reader.Close(); //reader nesnesini kapat
            _connection.Close(); //_connection nesnesini kapat
            command.Dispose();  //komutu yoket

            return dt;   //db den okunan verileri gonder


         

        }

    }
}
