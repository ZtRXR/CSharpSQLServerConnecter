namespace LearnFirst;

using System.Data;
using System.Data.SqlClient;
using LearnFirst.MySQL;
public partial class MainForm : Form
{
	public MainForm()
	{
		InitializeComponent();
	}

	private void MainForm_Load(object sender, EventArgs e)
	{
	}
	public void StaChangeText(string text)
	{
		StaShowText.Text = "״̬: " + text;
	}
	SqlConnection SqlC = new("server=127.0.0.1;uid=TestUser;pwd=Zengtudor2008;database=TestBase");
	bool OKed = false;
	public async void ConnectDB()
	{
		try
		{
			await SqlC.OpenAsync();
			OKed = true;
			RenewSta();
			StaShowText.ForeColor = Color.Green;
		}
		catch (Exception ex)
		{
			StaShowText.ForeColor = Color.Red;
			StaChangeText($"{textBoxDBName.Text} {SqlC.State}");
			MessageBox.Show($"{textBoxDBName.Text}  {SqlC.State}\n" + ex.Message);
		}
	}
	private void ConnectBase_Click(object sender, EventArgs e)
	{
		StaShowText.ForeColor = Color.Gray;
		if (OKed == true)
		{
			StaChangeText($"�ر����� {SqlC.Database}");
			SqlC.Close();
		}
		StaChangeText($"�������ݿ� {textBoxDBName.Text} ��...");
		SqlC = new(GetSqlConStr());
		ConnectDB();
	}
	public string GetSqlConStr()
	{
		return $"server={textBoxDBName.Text};uid={textBoxUserName.Text};pwd={textBoxPwd.Text};database={textBoxModleName.Text}";
	}

	private void label1_Click(object sender, EventArgs e)
	{

	}

	private async void BtnCloseDB_Click(object sender, EventArgs e)
	{
		StaChangeText($"{textBoxDBName.Text} {SqlC.State}");
		try
		{
			await SqlC.CloseAsync();
			StaChangeText($"{textBoxDBName.Text} {SqlC.State}");
			StaShowText.ForeColor = Color.Gray;
		}
		catch (Exception ex)
		{
			StaShowText.ForeColor = Color.Red;
			StaChangeText($"{SqlC.Database} {SqlC.State}");
			MessageBox.Show(ex.Message);
		}
	}

	private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		SqlC.Close();
	}

	private async void BtnToSQL_Click(object sender, EventArgs e)
	{
		var GetSta = SqlC.State;
		string Sta = GetSta.ToString();
		if (Sta == "Closed")
		{
			MessageBox.Show("�����������ݿ�");
			return;
		}

		SqlCommand cmd = new();
		cmd.Connection = SqlC;
		cmd.CommandText = TextBoxSqlStr.Text;
		try
		{
			TextSqlStrSta.ForeColor = Color.Green;
			TextSqlStrSta.Text = $"ִ��״̬: �ɹ�";
			await cmd.ExecuteNonQueryAsync();
			RenewSta();
		}
		catch (Exception ex)
		{
			TextSqlStrSta.ForeColor = Color.Red;
			TextSqlStrSta.Text = $"ִ��״̬: ����";
			MessageBox.Show($"ִ��SQL������\n{ex.Message}");
		}

	}
	public void RenewSta()
	{
		try
		{
			StaChangeText($"{textBoxDBName.Text} {SqlC.State}");
			TextDBVersion.Text = $"���ݿ�汾: {SqlC.ServerVersion.ToString()}";
			TextModleName.Text = $"������: {SqlC.Database}";
		}
		catch (Exception ex)
		{
			StaShowText.ForeColor = Color.Red;
			MessageBox.Show("ˢ��״̬ʧ�ܣ��������ݿ�����״̬\n" + ex.Message);
		}
	}
	private void btnGetCmdSql_Click(object sender, EventArgs e)
	{
		DataTable dataTable = new DataTable();
		try
		{
			string[] ColumnNames = TextBoxColumnSql.Text.Split(',');
			dataTable = ConnectSQL.ExecuteTable(SqlC, TextBoxSqlStr.Text);
			string ShowStr = "";
			foreach (DataRow row in dataTable.Rows)
			{
				string str = "";
				foreach (string ColumnName in ColumnNames)
				{
					str += $"{ColumnName} :{row[ColumnName]} ";
				}
				ShowStr += $"{str}\t";
			}
			TextBoxShowSqlRet.Text = ShowStr;
			RenewSta();
		}
		catch (Exception ex)
		{
			MessageBox.Show($"����SQL������Ƿ��в�ѯ���\n{ex.Message}");
		}
	}

	private void BtnRenewSta_Click(object sender, EventArgs e)
	{
		RenewSta();
	}
}