using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoriTreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Log(enLogLevel.Info, "프로그램을 시작합니다");
        }

        // TreeView 폴더 기준으로 노드 경로를 가져옴
        private void btnTreeLoad_Click(object sender, EventArgs e)
        {
            tviewLocation.Nodes.Clear();

            // 폴더 경로, 어떤 TreeView에다 넣을건지 
            TreeViewLoadByPath(tviewLocation, tboxSource.Text);



        }

        private void TreeViewLoadByPath(TreeView treeView, string path)
        {
            if (string.IsNullOrEmpty(tboxSource.Text))
            {
                return;
            }

            DirectoryInfo rootDirectoryInfo = new DirectoryInfo(path);

            // TreeNode tn = CreateDirectoryNode(rootDirectoryInfo); 
            // 계층 구조를 가지고 있는 노드를 만들어서 넣어줌
            // 재귀 함수를 가지고 Node 경로를 찾아옴
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo)); 

        }

        private TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            TreeNode directoryNode = new TreeNode(directoryInfo.Name);

            foreach (var directory in directoryInfo.GetDirectories())
            {
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            }

            // File
            foreach (var file in directoryInfo.GetFiles())
            {
                directoryNode.Nodes.Add(new TreeNode(file.Name));

            }

            return directoryNode;
        }

        private void btnExtend_Click(object sender, EventArgs e)
        {
            //tviewLocation.ExpandAll();
            if (tviewLocation.SelectedNode != null)
            {
                tviewLocation.SelectedNode.ExpandAll();
            }
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            tviewLocation.CollapseAll();
        }

        private void tviewLocation_DoubleClick(object sender, EventArgs e)
        {
            string strSelectPath = tviewLocation.SelectedNode.FullPath;

            if (lboxCommand.Items.Contains(strSelectPath))
            {
                return;
            }

            lboxCommand.Items.Add(strSelectPath);
        }

        // Folder 보여줌
        private void lboxCommand_MouseClick(object sender, MouseEventArgs e)
        {
            string dirPath = SourcePath();

            if (dirPath == null)
            {
                return;
            }

            if (lboxCommand.SelectedItem == null) return;  
            
            StringBuilder sb = new StringBuilder();

            if (Directory.Exists(dirPath))
            {
                DirectoryInfo di = new DirectoryInfo(dirPath);

                foreach (var directory in di.GetDirectories())
                {
                    //sb.Append(string.Format("[Folder] {0} \n", directory));
                    sb.Append("[Folder] ");
                }

                // File
                foreach (var file in di.GetFiles())
                {
                    //sb.Append(string.Format("{0} \r\n", file.Name));
                    sb.Append("[File]");
                }

                tboxFile.Text = sb.ToString();
            }
        }

        // 삭제기능
        private void lboxCommand_DoubleClick(object sender, EventArgs e)
        {
            if (lboxCommand.SelectedIndex != -1)
            {
                lboxCommand.Items.RemoveAt(lboxCommand.SelectedIndex);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string sourcePath = SourcePath(); // Source folder full path

            string destinationPath = tboxDestination.Text; //+ \(DateTime.Now:yyyyMMdd_hhss); 
                      
            //Log(enLogLevel.Info, $"Source : {sourcePath}");
            //Log(enLogLevel.Info, $"Destination : {destinationPath}");

            //FileSystem.CopyDirectory(sourcePath, destinationPath, UIOption.AllDialogs); 왜 안써지지?

            //Log(enLogLevel.Info, $"경로 Backup을 완료 하였습니다.");
        }

        private string SourcePath()
        {
            if (String.IsNullOrEmpty(tboxSource.Text))
            {
                Log(enLogLevel.Warning, "Source 경로가 입력되어 있지 않습니다.");
                return null;
            }

            // 파일 경로 찾기
            string path = tboxSource.Text; // 앞쪽 경로
            string LastPath = Path.GetDirectoryName(path);
            string strPath = lboxCommand.SelectedItem.ToString();
            string dirPath = LastPath + strPath;

            return dirPath;
        }

        // Log 표기
        enum enLogLevel
        {
            Info, // 알림
            Warning, // 경고
            Error, // 크리티컬한
        }

        private void Log(enLogLevel eLevel, string LogDesc)
        {
            DateTime dTime = DateTime.Now;

            lboxLog.Items.Add(dTime + eLevel.ToString() + LogDesc);
            //string logInfo = $"{dTime:yyyy-MM-dd hh:mm:ss.fff} {(eLevel.ToString()} {LogDesc}";
            //lboxLog.Items.Add(logInfo);

            //lboxLog.Items.Insert(0, logInfo);
        }

        private void Log(DateTime dTime, enLogLevel eLevel, string LogDesc)
        {

        }

    }
}
