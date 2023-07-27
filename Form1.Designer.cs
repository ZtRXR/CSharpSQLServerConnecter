namespace LearnFirst
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			ConnectBase = new Button();
			StaShowText = new Label();
			TextDBName = new Label();
			textBoxDBName = new TextBox();
			TextUserName = new Label();
			textBoxUserName = new TextBox();
			textBoxPwd = new TextBox();
			TextPwd = new Label();
			label1 = new Label();
			textBoxModleName = new TextBox();
			BtnCloseDB = new Button();
			TextDBVersion = new Label();
			TextModleName = new Label();
			TextBoxSqlStr = new TextBox();
			label2 = new Label();
			BtnToSQL = new Button();
			TextSqlStrSta = new Label();
			btnGetCmdSql = new Button();
			BtnRenewSta = new Button();
			label3 = new Label();
			TextBoxColumnSql = new TextBox();
			TextBoxShowSqlRet = new TextBox();
			label4 = new Label();
			SuspendLayout();
			// 
			// ConnectBase
			// 
			ConnectBase.Location = new Point(12, 224);
			ConnectBase.Name = "ConnectBase";
			ConnectBase.Size = new Size(94, 29);
			ConnectBase.TabIndex = 0;
			ConnectBase.Text = "连接数据库";
			ConnectBase.UseVisualStyleBackColor = true;
			ConnectBase.Click += ConnectBase_Click;
			// 
			// StaShowText
			// 
			StaShowText.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			StaShowText.AutoSize = true;
			StaShowText.Location = new Point(12, 535);
			StaShowText.Name = "StaShowText";
			StaShowText.Size = new Size(47, 20);
			StaShowText.TabIndex = 1;
			StaShowText.Text = "状态: ";
			// 
			// TextDBName
			// 
			TextDBName.AutoSize = true;
			TextDBName.Location = new Point(12, 9);
			TextDBName.Name = "TextDBName";
			TextDBName.Size = new Size(98, 20);
			TextDBName.TabIndex = 2;
			TextDBName.Text = "SQL数据库名";
			TextDBName.Click += label1_Click;
			// 
			// textBoxDBName
			// 
			textBoxDBName.Location = new Point(12, 32);
			textBoxDBName.Name = "textBoxDBName";
			textBoxDBName.Size = new Size(125, 27);
			textBoxDBName.TabIndex = 3;
			textBoxDBName.Text = "127.0.0.1";
			// 
			// TextUserName
			// 
			TextUserName.AutoSize = true;
			TextUserName.Location = new Point(12, 62);
			TextUserName.Name = "TextUserName";
			TextUserName.Size = new Size(54, 20);
			TextUserName.TabIndex = 4;
			TextUserName.Text = "连接名";
			// 
			// textBoxUserName
			// 
			textBoxUserName.Location = new Point(12, 85);
			textBoxUserName.Name = "textBoxUserName";
			textBoxUserName.Size = new Size(125, 27);
			textBoxUserName.TabIndex = 5;
			textBoxUserName.Text = "TestUser";
			// 
			// textBoxPwd
			// 
			textBoxPwd.Location = new Point(12, 138);
			textBoxPwd.Name = "textBoxPwd";
			textBoxPwd.PasswordChar = '*';
			textBoxPwd.Size = new Size(125, 27);
			textBoxPwd.TabIndex = 6;
			textBoxPwd.Text = "Zengtudor2008";
			// 
			// TextPwd
			// 
			TextPwd.AutoSize = true;
			TextPwd.Location = new Point(12, 115);
			TextPwd.Name = "TextPwd";
			TextPwd.Size = new Size(39, 20);
			TextPwd.TabIndex = 7;
			TextPwd.Text = "密码";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 168);
			label1.Name = "label1";
			label1.Size = new Size(69, 20);
			label1.TabIndex = 8;
			label1.Text = "数据库名";
			// 
			// textBoxModleName
			// 
			textBoxModleName.Location = new Point(12, 191);
			textBoxModleName.Name = "textBoxModleName";
			textBoxModleName.Size = new Size(125, 27);
			textBoxModleName.TabIndex = 9;
			textBoxModleName.Text = "TestBase";
			// 
			// BtnCloseDB
			// 
			BtnCloseDB.Location = new Point(12, 259);
			BtnCloseDB.Name = "BtnCloseDB";
			BtnCloseDB.Size = new Size(94, 29);
			BtnCloseDB.TabIndex = 10;
			BtnCloseDB.Text = "断开连接";
			BtnCloseDB.UseVisualStyleBackColor = true;
			BtnCloseDB.Click += BtnCloseDB_Click;
			// 
			// TextDBVersion
			// 
			TextDBVersion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			TextDBVersion.AutoSize = true;
			TextDBVersion.Location = new Point(12, 505);
			TextDBVersion.Name = "TextDBVersion";
			TextDBVersion.Size = new Size(92, 20);
			TextDBVersion.TabIndex = 11;
			TextDBVersion.Text = "数据库版本: ";
			// 
			// TextModleName
			// 
			TextModleName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			TextModleName.AutoSize = true;
			TextModleName.Location = new Point(12, 566);
			TextModleName.Name = "TextModleName";
			TextModleName.Size = new Size(62, 20);
			TextModleName.TabIndex = 12;
			TextModleName.Text = "表名称: ";
			// 
			// TextBoxSqlStr
			// 
			TextBoxSqlStr.Location = new Point(240, 32);
			TextBoxSqlStr.Multiline = true;
			TextBoxSqlStr.Name = "TextBoxSqlStr";
			TextBoxSqlStr.ScrollBars = ScrollBars.Both;
			TextBoxSqlStr.Size = new Size(461, 133);
			TextBoxSqlStr.TabIndex = 13;
			TextBoxSqlStr.Text = "select * from student";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(240, 9);
			label2.Name = "label2";
			label2.Size = new Size(68, 20);
			label2.TabIndex = 14;
			label2.Text = "SQL指令";
			// 
			// BtnToSQL
			// 
			BtnToSQL.Location = new Point(526, 171);
			BtnToSQL.Name = "BtnToSQL";
			BtnToSQL.Size = new Size(175, 47);
			BtnToSQL.TabIndex = 15;
			BtnToSQL.Text = "执行SQL指令";
			BtnToSQL.UseVisualStyleBackColor = true;
			BtnToSQL.Click += BtnToSQL_Click;
			// 
			// TextSqlStrSta
			// 
			TextSqlStrSta.AutoSize = true;
			TextSqlStrSta.Location = new Point(240, 184);
			TextSqlStrSta.Name = "TextSqlStrSta";
			TextSqlStrSta.Size = new Size(73, 20);
			TextSqlStrSta.TabIndex = 16;
			TextSqlStrSta.Text = "执行状态:";
			// 
			// btnGetCmdSql
			// 
			btnGetCmdSql.Location = new Point(607, 224);
			btnGetCmdSql.Name = "btnGetCmdSql";
			btnGetCmdSql.Size = new Size(94, 29);
			btnGetCmdSql.TabIndex = 17;
			btnGetCmdSql.Text = "获取数据";
			btnGetCmdSql.UseVisualStyleBackColor = true;
			btnGetCmdSql.Click += btnGetCmdSql_Click;
			// 
			// BtnRenewSta
			// 
			BtnRenewSta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			BtnRenewSta.Location = new Point(12, 473);
			BtnRenewSta.Name = "BtnRenewSta";
			BtnRenewSta.Size = new Size(94, 29);
			BtnRenewSta.TabIndex = 18;
			BtnRenewSta.Text = "刷新状态";
			BtnRenewSta.UseVisualStyleBackColor = true;
			BtnRenewSta.Click += BtnRenewSta_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(240, 224);
			label3.Name = "label3";
			label3.Size = new Size(193, 20);
			label3.TabIndex = 19;
			label3.Text = "查询的表列名，用英文,隔开";
			// 
			// TextBoxColumnSql
			// 
			TextBoxColumnSql.Location = new Point(240, 259);
			TextBoxColumnSql.Name = "TextBoxColumnSql";
			TextBoxColumnSql.Size = new Size(461, 27);
			TextBoxColumnSql.TabIndex = 20;
			TextBoxColumnSql.Text = "Id,Name,age";
			// 
			// TextBoxShowSqlRet
			// 
			TextBoxShowSqlRet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			TextBoxShowSqlRet.Location = new Point(240, 396);
			TextBoxShowSqlRet.Multiline = true;
			TextBoxShowSqlRet.Name = "TextBoxShowSqlRet";
			TextBoxShowSqlRet.ScrollBars = ScrollBars.Both;
			TextBoxShowSqlRet.Size = new Size(461, 190);
			TextBoxShowSqlRet.TabIndex = 21;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(240, 373);
			label4.Name = "label4";
			label4.Size = new Size(114, 20);
			label4.TabIndex = 22;
			label4.Text = "获取数据返回框";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(9F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(950, 600);
			Controls.Add(label4);
			Controls.Add(TextBoxShowSqlRet);
			Controls.Add(TextBoxColumnSql);
			Controls.Add(label3);
			Controls.Add(BtnRenewSta);
			Controls.Add(btnGetCmdSql);
			Controls.Add(TextSqlStrSta);
			Controls.Add(BtnToSQL);
			Controls.Add(label2);
			Controls.Add(TextBoxSqlStr);
			Controls.Add(TextModleName);
			Controls.Add(TextDBVersion);
			Controls.Add(BtnCloseDB);
			Controls.Add(textBoxModleName);
			Controls.Add(label1);
			Controls.Add(TextPwd);
			Controls.Add(textBoxPwd);
			Controls.Add(textBoxUserName);
			Controls.Add(TextUserName);
			Controls.Add(textBoxDBName);
			Controls.Add(TextDBName);
			Controls.Add(StaShowText);
			Controls.Add(ConnectBase);
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Zengtudor:  用C# on .NET 学习微软SQL";
			FormClosing += MainForm_FormClosing;
			Load += MainForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button ConnectBase;
		private Label StaShowText;
		private Label TextDBName;
		private TextBox textBoxDBName;
		private Label TextUserName;
		private TextBox textBoxUserName;
		private TextBox textBoxPwd;
		private Label TextPwd;
		private Label label1;
		private TextBox textBoxModleName;
		private Button BtnCloseDB;
		private Label TextDBVersion;
		private Label TextModleName;
		private TextBox TextBoxSqlStr;
		private Label label2;
		private Button BtnToSQL;
		private Label TextSqlStrSta;
		private Button btnGetCmdSql;
		private Button BtnRenewSta;
		private Label label3;
		private TextBox TextBoxColumnSql;
		private TextBox TextBoxShowSqlRet;
		private Label label4;
	}
}