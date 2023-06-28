using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// veri tabanı bağlantı

using System.Data;
using System.Data.SqlClient;

// --------------------------

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=mustafa-laptop;Initial Catalog=dbYazOkulu;Integrated Security=True");

    }
}
