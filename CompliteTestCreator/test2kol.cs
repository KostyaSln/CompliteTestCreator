using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompliteTestCreator
{
    public partial class test2kol : Form
    {
        ListBox listBox = new ListBox();
        Model M = new Model();
        List<string> AnsverList = new List<string>();
        int K = 0;
        bool IsStudent = false;
        

        public test2kol()
        {
            InitializeComponent();
            listBox = To1listBox;
            To1listBox.HorizontalScrollbar = true;
            To2listBox.HorizontalScrollbar = true;
            fromListBox.HorizontalScrollbar = true;
        }

        public test2kol(bool isStud, string filename)
        {
            InitializeComponent();

            To1listBox.HorizontalScrollbar = true;
            To2listBox.HorizontalScrollbar = true;

            listBox = To1listBox;
            IsStudent = isStud;
            this.TeacherAccess();
            StreamReader streamReader = new StreamReader(filename);
            streamReader.ReadLine();
            int.TryParse(streamReader.ReadLine(),out K);
            TopicTextBox.Text = streamReader.ReadLine();
            TaskTextBox.Text = streamReader.ReadLine();
            FromTextBox.Text = streamReader.ReadLine();
            To1TextBox.Text = streamReader.ReadLine();
            To2TextBox.Text = streamReader.ReadLine();
            while (true)
            {
                string str = streamReader.ReadLine();
                if (str != null) 
                    AnsverList.Add(str);
                else break;
            }
            //if (IsStudent)
            //{
                M.ResetButtonClick(To1listBox, To2listBox, fromListBox);
                M.RestartButtonClick(AnsverList, fromListBox, K);
            //}
            /*
            else
            {
                foreach (string a in AnsverList)
                {
                    
                    switch (a[0])
                    {
                        case '1':
                            {
                                To1listBox.Items.Add(a.Substring(1));
                                break;
                            }
                        case '2':
                            {
                                To2listBox.Items.Add(a.Substring(1));
                                break;
                            }
                    }
                        
                }
            }
            */
        }

        private void test2kol_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void To1listBox_Click(object sender, EventArgs e)
        {
            //if(IsStudent)
                M.MoveFromTo(listBox, To1listBox);
        }

        private void To1listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (IsStudent)
                M.ChangeIndex(To1listBox,ref listBox);
            //else
            //   M.Redaction(To1TextBox, To1listBox);
        }

        private void To2listBox_Click(object sender, EventArgs e)
        {
            //if (IsStudent)
                M.MoveFromTo(listBox, To2listBox);
        }

        private void To2listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (IsStudent)
                M.ChangeIndex(To2listBox, ref listBox);
            //else
            //    M.Redaction(To2TextBox, To2listBox);
        }

        private void fromListBox_Click(object sender, EventArgs e)
        {
            //if (IsStudent)
                M.MoveFromTo(listBox, fromListBox);
        }

        private void fromListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (IsStudent)
                M.ChangeIndex(fromListBox, ref listBox);
        }
        
        private void To1TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            if (e.KeyCode == Keys.Enter)
                M.AddToList(To1TextBox, To1listBox);  
            */
        }
        
        private void To2TextBox_KeyDown(object sender, KeyEventArgs e)
        {
        /*
            if (e.KeyCode == Keys.Enter)
                M.AddToList(To2TextBox, To2listBox);
        */
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
        /*
            if (!(saveFileDialog.ShowDialog() == DialogResult.OK))
                return;

            List<string> fileText = new List<string>();

            fileText.Add("2");
            int.TryParse(KTextBox.Text, out K);
            fileText.Add(K.ToString());
            fileText.Add(TopicTextBox.Text);
            fileText.Add(TaskTextBox.Text);
            fileText.Add(FromTextBox.Text);
            fileText.Add(To1TextBox.Text);
            fileText.Add(To2TextBox.Text);
            M.FormAnsverList(ref AnsverList, To1listBox, To2listBox);
            fileText.AddRange(AnsverList);

            string filename = saveFileDialog.FileName;
            System.IO.File.WriteAllLines(filename, fileText);
        */
        }
        
        private void ResultButton_Click(object sender, EventArgs e)
        {
            if(fromListBox.Items.Count == 0)
                ResultTextBox.Text = M.ResultButtonClick(AnsverList, To1listBox, To2listBox).ToString() + '/' + M.Count(To1listBox, To2listBox).ToString();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            M.ResetButtonClick(To1listBox, To2listBox, fromListBox);
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            M.ResetButtonClick(To1listBox, To2listBox, fromListBox);
            M.RestartButtonClick(AnsverList, fromListBox, K);
        }

        private void KTextBox_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
        
        private void TeacherAccess()
        {
            this.TopicTextBox.ReadOnly = IsStudent;
            this.TaskTextBox.ReadOnly = IsStudent;
            this.To1TextBox.ReadOnly = IsStudent;
            this.To2TextBox.ReadOnly = IsStudent;
            this.FromTextBox.ReadOnly = IsStudent;
            this.ResultTextBox.ReadOnly = IsStudent;
            if (IsStudent)
            {
                this.KLabel.Hide();
                this.KTextBox.Hide();
                this.SaveButton.Hide();
            }
        }
        
    }
}
