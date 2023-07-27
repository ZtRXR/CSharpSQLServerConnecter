using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFirst.MySQL;

public class ConnectSQL
{
	public static DataTable ExecuteTable(SqlConnection sqlConnection, string sql)
	{
		SqlCommand sqlCommand = new(sql, sqlConnection);
		SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
		DataSet ds = new DataSet();
		adapter.Fill(ds);
		return ds.Tables[0];
	} 
}
