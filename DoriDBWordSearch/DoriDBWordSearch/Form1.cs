using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoriDBWordSearch
{
    public partial class Form1 : Form
    {
        OleDbConnection _conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDBLoad_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            OFDialog.InitialDirectory = Application.StartupPath; // 프로그램 실행 파일 위치
            OFDialog.FileName = "*.mdb";
            OFDialog.Filter = "db files (*.mdb)|*.mdb|All files (*.*)|*.*";

            if (OFDialog.ShowDialog() == DialogResult.OK)
            {
                tboxPath.Text = OFDialog.FileName;
                DBConnect(tboxPath.Text);
            }
        }

        #region DB Connection

        private void DBConnect(string strDBPath)
        {
            string connStr = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}", strDBPath);

            _conn = new OleDbConnection(connStr);

            string Query = @"Select +
                            From Voca";

            QueryExecute(Query);
        }

        private void QueryExecute(string Query)
        {
            DataSet ds = new DataSet();

            OleDbDataAdapter adp = new OleDbDataAdapter(Query, _conn);
            adp.Fill(ds);

            dgData.DataSource = ds.Tables[0];
        }

        #endregion

        private void btnExe_Click(object sender, EventArgs e)
        {
            QueryExecute(tboxQuery.Text);
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            Button obtn = sender as Button;

            string strQuery = null;

            switch (obtn.Name)
            {
                case "btnEx1":
                    strQuery = @"Select + 
                                From Voca";
                    break;
                case "btnEx2":
                    strQuery = @"Select + 
                                From Voca
                                Where 단어 Like ""%a%""";
                    break;
                case "btnEx3":
                    strQuery = @"Select + 
                                From Voca
                                Order By ID DESC";
                    break;
            }

            tboxQuery.Text = strQuery;
        }

    }
}
