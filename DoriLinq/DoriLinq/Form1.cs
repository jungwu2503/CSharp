﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoriLinq
{
    public partial class Form1 : Form
    {
        const string sLEVEL = "LEVEL";
        const string sNAME = "NAME";
        const string sATTRIBUTE = "ATTRIBUTE";

        DataTable dt;

        enum EnumName
        {
            슬라임,
            가고일,
            골렘,
            코볼트,
            고블린,
            고스트,
            언데드,
            노움,
            드래곤,
            웜,
            서큐버스,
            데빌,
            만티코어,
            바실리스트,
        }

        enum EnumAttribute
        {
            불,
            물,
            바람,
            번개,
            어둠,
            빛,
            땅,
            나무,
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTableCreate(); 
            EnemyCreate();
            ComboBoxCreate();
        }
                
        private void DataTableCreate()
        {
            dt = new DataTable("Enemy");

            DataColumn colLevel = new DataColumn(sLEVEL, typeof(int));
            DataColumn colName = new DataColumn(sNAME, typeof(string));
            DataColumn colAttribute = new DataColumn(sATTRIBUTE, typeof(string));

            dt.Columns.Add(colLevel);
            dt.Columns.Add(colName);
            dt.Columns.Add(colAttribute);
        }

        private void EnemyCreate()
        {
            Random rd = new Random();

            foreach (EnumName oName in Enum.GetValues(typeof(EnumName))) 
            {
                DataRow dr = dt.NewRow();

                dr[sLEVEL] = rd.Next(1, 11); // 1~10 중에서 Random
                dr[sNAME] = oName.ToString(); // 이름 넣어줌

                int iEnumLength = Enum.GetValues(typeof(EnumAttribute)).Length; // Enum의 개수를 가져옴
                int iAttribute = rd.Next(iEnumLength);
                dr[sATTRIBUTE] = (EnumAttribute)iAttribute;

                dt.Rows.Add(dr);
            }

            dgEnemyTable.DataSource = dt;
        }

        private void ComboBoxCreate()
        {
            foreach (EnumAttribute oAttribute in Enum.GetValues(typeof(EnumAttribute))) 
            {
                cboxAttribute.Items.Add(oAttribute);
            }
            cboxAttribute.SelectedIndex = 0;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Button oBtn = sender as Button;

            DataTable dtCopy = dgEnemyTable.DataSource as DataTable;

            IEnumerable<DataRow> vSortTable = null;

            switch (oBtn.Name)
            {
                case "btnLevel":
                    vSortTable = from oRow in dtCopy.AsEnumerable()
                             orderby oRow.Field<int>(sLEVEL) // 정렬 기준
                             select oRow;
                    break;
                case "btnName":
                    vSortTable = from oRow in dtCopy.AsEnumerable()
                                 orderby oRow.Field<string>(sNAME) // 정렬 기준
                                 select oRow;
                    break;
                case "btnAttribute":
                    vSortTable = from oRow in dtCopy.AsEnumerable()
                                 orderby oRow.Field<string>(sATTRIBUTE) // 정렬 기준
                                 select oRow;
                    break;
            }

            

            dtCopy = vSortTable.CopyToDataTable();
            dgEnemyTable.DataSource = dtCopy;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DataTable dtCopy = dgEnemyTable.DataSource as DataTable;

            IEnumerable<DataRow> vSortTable = from oRow in dtCopy.AsEnumerable()
                                              where oRow.Field<string>(sATTRIBUTE) == cboxAttribute.Text &&
                                              (oRow.Field<int>(sLEVEL) >= nLevelMin.Value && oRow.Field<int>(sLEVEL) <= nLevelMax.Value)
                                              select oRow;

            if (vSortTable.Count() > 0)
            {
                dtCopy = vSortTable.CopyToDataTable();
                dgEnemyTable.DataSource = dtCopy;
            }
            else
            {
                MessageBox.Show("검색 조건에 맞는 data가 없습니다.");
            }

        }

    }
}
