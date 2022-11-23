using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TableEx
{
    public partial class ListForm : Form
    {
        Button addBtn;
        Button removeBtn;
        TextBox nameBox;
        TextBox korBox;
        TextBox engBox;
        TextBox mathBox;
        ArrayList list = new ArrayList();
        int selectedIndex;
        String _fileName;

        public ListForm()
        {
            InitializeComponent();

            selectedIndex = -1;

            listView.Parent = this;
            listView.Dock = DockStyle.Fill;
            listView.View = View.Details;
            listView.MultiSelect = false;

            this.TopMost = true;

            this.SetBounds(100, 100, 530, 500);
            listView.Columns.Add("순서", 70, HorizontalAlignment.Center);
            listView.Columns.Add("이름", 70, HorizontalAlignment.Center);
            listView.Columns.Add("국어", 70, HorizontalAlignment.Center);
            listView.Columns.Add("영어", 70, HorizontalAlignment.Center);
            listView.Columns.Add("수학", 70, HorizontalAlignment.Center);
            listView.Columns.Add("합계", 70, HorizontalAlignment.Center);
            listView.Columns.Add("장학금여부", 100, HorizontalAlignment.Center);
            
            //listView.Items.Add(list);  

            //listView.Items.Add(new ListViewItem(list));

            Panel panel = new Panel();
            panel.Dock = DockStyle.Bottom;
            panel.Parent = this;

            Label nameLabel = new Label();
            nameLabel.Text = "이름:";
            nameLabel.SetBounds(20, 35, 40, 40);

            nameBox = new TextBox();
            nameBox.SetBounds(60, 30, 60, 40);

            Label korLabel = new Label();
            korLabel.Text = "국어:";
            korLabel.SetBounds(130, 35, 40, 40);

            korBox = new TextBox();
            korBox.SetBounds(170, 30, 30, 40);

            Label engLabel = new Label();
            engLabel.Text = "영어:";
            engLabel.SetBounds(210, 35, 40, 40);

            engBox = new TextBox();
            engBox.SetBounds(250, 30, 30, 40);

            Label mathLabel = new Label();
            mathLabel.Text = "수학:";
            mathLabel.SetBounds(290, 35, 40, 40);

            mathBox = new TextBox();
            mathBox.SetBounds(330, 30, 30, 40);

            addBtn = new Button();
            addBtn.Text = "Add";
            addBtn.SetBounds(380, 20, 60, 40);
            addBtn.Click += new EventHandler(buttonClicked);
            removeBtn = new Button();
            removeBtn.Text = "Remove";
            removeBtn.SetBounds(445, 20, 60, 40);
            removeBtn.Click += new EventHandler(buttonClicked);

            panel.Controls.Add(nameLabel);
            panel.Controls.Add(nameBox);
            panel.Controls.Add(korLabel);
            panel.Controls.Add(korBox);
            panel.Controls.Add(engLabel);
            panel.Controls.Add(engBox);
            panel.Controls.Add(mathLabel);
            panel.Controls.Add(mathBox);
            panel.Controls.Add(addBtn);
            panel.Controls.Add(removeBtn);

            list.Add(new Student("홍충표", 20, 30, 40));
            list.Add(new Student("고현규", 40, 30, 10));
            list.Add(new Student("김동혁", 30, 50, 50));
            list.Add(new Student("유승진", 10, 20, 70));

            displayStudent();
        }

        void buttonClicked(object sender, EventArgs ea)
        {
            if (!(sender is Button)) return;
            Button button = (Button)sender;
            if (button.Equals(addBtn))
            {
                int sum = int.Parse(korBox.Text) + int.Parse(engBox.Text) + int.Parse(mathBox.Text);
                bool isScholar = sum >= 100 ? true : false;
                String[] value = { "" + (list.Count+1), nameBox.Text, korBox.Text, engBox.Text, mathBox.Text, ""+(sum), ""+isScholar};
                ListViewItem lvi = new ListViewItem(value[0]);

                lvi.SubItems.Add(value[1]);
                lvi.SubItems.Add(value[2]);
                lvi.SubItems.Add(value[3]);
                lvi.SubItems.Add(value[4]);
                lvi.SubItems.Add(value[5]);
                lvi.SubItems.Add(value[6]);

                listView.Items.Add(lvi);
                listView.Invalidate();

                list.Add(new Student(value[1], int.Parse(value[2]), int.Parse(value[3]), int.Parse(value[4])));
            }
            else if (button.Equals(removeBtn))
            {
                if (selectedIndex == -1) return;

                list.RemoveAt(selectedIndex);
                displayStudent();
                //MessageBox.Show(""+selectedIndex);
            }
        }

        void displayStudent()
        {
            listView.Items.Clear();

            int index = 0;
      
            for (index = 0; index < list.Count; index++)
            {
                Student st = (Student)list[index];

                ListViewItem lvi = new ListViewItem(""+(index+1));
                lvi.SubItems.Add(st.Name);
                lvi.SubItems.Add(""+st.Kor);
                lvi.SubItems.Add(""+st.Eng);
                lvi.SubItems.Add(""+st.Math);
                lvi.SubItems.Add(""+st.Sum);
                lvi.SubItems.Add(""+st.IsScholar);

                listView.Items.Add(lvi);
            }
            listView.Invalidate();

        }
        
        private void listView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected) selectedIndex = e.ItemIndex;
            else selectedIndex = -1;
        }

        private void saveSerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog chooser = new SaveFileDialog();
            chooser.Title = "File Save";
            chooser.Filter = "Serialized Files (*.ser)|*.ser";
            chooser.InitialDirectory = "C:\\Users\\user\\Desktop";
            chooser.OverwritePrompt = true;
            if (chooser.ShowDialog() != DialogResult.OK) return;
            String fileName = chooser.FileName;
            if (fileName == null) return;
            if (fileName.Length == 0) return;
            _fileName = fileName;
            doSave();

            /*Stream s = new FileStream("*.ser", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(s, list);
            s.Close();*/
        }

        private void doSave()
        {
            /*Stream s = new FileStream("*.ser", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(s, list);
            s.Close();*/

            BinaryFormatter formatter = new BinaryFormatter();
            Stream output = File.Create(_fileName);

            formatter.Serialize(output, list);
            output.Close();
        }

        private void saveTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Stream s = new FileStream("*.ser", FileMode.Create);
            StreamReader sr = new StreamReader(s);
            String str = "";

            str = list.ToString();*/

            StreamWriter writer = File.CreateText("*.txt");
            //IEnumerator<Student> = list.GetEnumerator();
            writer.WriteLine(list);

            writer.Close();
        }

        private void openSerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Stream s = new FileStream("*.ser", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            list = (ArrayList)bf.Deserialize(s);
            s.Close();*/

            OpenFileDialog chooser = new OpenFileDialog();
            chooser.Title = "File Open";
            chooser.Filter = "Serialized Files (*.ser)|*.ser";
            chooser.InitialDirectory = "C:\\Users\\user\\Desktop";
            if (chooser.ShowDialog() != DialogResult.OK) return;
            _fileName = chooser.FileName;

            doOpen();
        }

        private void doOpen()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream input = File.OpenRead(_fileName);

            list = (ArrayList)formatter.Deserialize(input);
            input.Close();
            displayStudent();
        }
                
        private void openTextToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
        
}



/*namespace TableEx
{
    public class Student
    {
        String name;
        int kor, eng, math, sum;
        Boolean isScholar;
        
        public Student(String name, int kor, int eng, int math)
        {
            this.name = name;
            this.kor = kor;
            this.eng = eng;
            this.math = math;
            this.sum = kor + eng + math;
            isScholar = sum >= 100 ? true : false ;
        }
        
    }

    public partial class ListForm : Form
    {
        Button addBtn;
        Button removeBtn;
        TextBox nameBox;
        TextBox korBox;
        TextBox engBox;
        TextBox mathBox;
        int index;
        List<Student> list = new List<Student>();

        public ListForm()
        {
            InitializeComponent();

            listView.Parent = this;
            listView.Dock = DockStyle.Fill;
            listView.View = View.Details;
            listView.MultiSelect = false;
            index = 1;

            this.TopMost = true;
            
            this.SetBounds(100, 100, 530, 500);
            listView.Columns.Add("순서", 70, HorizontalAlignment.Center);
            listView.Columns.Add("이름", 70, HorizontalAlignment.Center);
            listView.Columns.Add("국어", 70, HorizontalAlignment.Center);
            listView.Columns.Add("영어", 70, HorizontalAlignment.Center);
            listView.Columns.Add("수학", 70, HorizontalAlignment.Center);
            listView.Columns.Add("합계", 70, HorizontalAlignment.Center);
            listView.Columns.Add("장학금여부", 100, HorizontalAlignment.Center);

            list.Add(new Student("홍충표", 20, 30, 40));
            list.Add(new Student("고현규", 40, 30, 10));
            list.Add(new Student("김동혁", 30, 50, 50));
            list.Add(new Student("유승진", 10, 20, 70));

            //listView.Items.Add(list);  

            listView.Items.Add(new ListViewItem(list));
            
            Panel panel = new Panel();
            panel.Dock = DockStyle.Bottom;
            panel.Parent = this;

            Label nameLabel = new Label();
            nameLabel.Text = "이름:";
            nameLabel.SetBounds(20, 35, 40, 40);

            nameBox = new TextBox();
            nameBox.SetBounds(60, 30, 60, 40);

            Label korLabel = new Label();
            korLabel.Text = "국어:";
            korLabel.SetBounds(130, 35, 40, 40);

            korBox = new TextBox();
            korBox.SetBounds(170, 30, 30, 40);

            Label engLabel = new Label();
            engLabel.Text = "영어:";
            engLabel.SetBounds(210, 35, 40, 40);

            engBox = new TextBox();
            engBox.SetBounds(250, 30, 30, 40);

            Label mathLabel = new Label();
            mathLabel.Text = "수학:";
            mathLabel.SetBounds(290, 35, 40, 40);

            mathBox = new TextBox();
            mathBox.SetBounds(330, 30, 30, 40);

            addBtn = new Button();
            addBtn.Text = "Add";
            addBtn.SetBounds(380, 20, 60, 40);
            addBtn.Click += new EventHandler(buttonClicked);
            removeBtn = new Button();
            removeBtn.Text = "Remove";
            removeBtn.SetBounds(445, 20, 60, 40);

            panel.Controls.Add(nameLabel);
            panel.Controls.Add(nameBox);
            panel.Controls.Add(korLabel);
            panel.Controls.Add(korBox);
            panel.Controls.Add(engLabel);
            panel.Controls.Add(engBox);
            panel.Controls.Add(mathLabel);
            panel.Controls.Add(mathBox);
            panel.Controls.Add(addBtn);
            panel.Controls.Add(removeBtn);
        }

        void buttonClicked(object sender, EventArgs ea)
        {
            if (!(sender is Button)) return;
            Button button = (Button)sender;
            if (button.Equals(addBtn))
            {


                //int sum = int.Parse(korBox.Text) + int.Parse(engBox.Text) + int.Parse(mathBox.Text);
                //Boolean isScholar = sum >= 100 ? true : false;
                //String[] row = { "" + index, nameBox.Text, korBox.Text, engBox.Text, mathBox.Text, ""+(sum), ""+isScholar};
                //ListViewItem lvi = new ListViewItem(row);
                
                //lvi.SubItems.Add(""+index);
                //lvi.SubItems.Add(nameBox.Text);
                //lvi.SubItems.Add(korBox.Text);
                //lvi.SubItems.Add(engBox.Text);
                //lvi.SubItems.Add(mathBox.Text);
                                
                //listView.Items.Add(lvi);
                //listView.Invalidate();
                //index++;
            }
            else if (button.Equals("Remove"))
            {
                //listView.Items.Remove();
            }
        }

    }
} */
