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
    public partial class test3kol : Form
    {
        ListBox listBox = new ListBox();
        Model M = new Model();
        List<string> AnsverList = new List<string>();
        int K = 0;
        bool IsStudent = false;


        public test3kol()
        {
            InitializeComponent();
        }


        public test3kol(bool isStud, string filename)
        {
            InitializeComponent();

            To1listBox.HorizontalScrollbar = true;
            To2listBox.HorizontalScrollbar = true;
            To3listBox.HorizontalScrollbar = true;
            fromListBox.HorizontalScrollbar = true;

            listBox = To1listBox;
            IsStudent = isStud;
            this.TeacherAccess();
            StreamReader streamReader = new StreamReader(filename);
            streamReader.ReadLine();
            int.TryParse(streamReader.ReadLine(), out K);
            TopicTextBox.Text = streamReader.ReadLine();
            TaskTextBox.Text = streamReader.ReadLine();
            FromTextBox.Text = streamReader.ReadLine();
            To1TextBox.Text = streamReader.ReadLine();
            To2TextBox.Text = streamReader.ReadLine();
            To3TextBox.Text = streamReader.ReadLine();
            while (true)
            {
                string str = streamReader.ReadLine();
                if (str != null)
                    AnsverList.Add(str);
                else break;
            }
            M.ResetButtonClick(To1listBox, To2listBox, To3listBox, fromListBox);
            M.RestartButtonClick(AnsverList, fromListBox, K);     
        }

        private void test3kol_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void To1listBox_Click(object sender, EventArgs e)
        {
            M.MoveFromTo(listBox, To1listBox);
        }

        private void To1listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            M.ChangeIndex(To1listBox, ref listBox);
        }

        private void To2listBox_Click(object sender, EventArgs e)
        {
            M.MoveFromTo(listBox, To2listBox);
        }

        private void To2listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            M.ChangeIndex(To2listBox, ref listBox);
        }

        private void To3listBox_Click(object sender, EventArgs e)
        {
            M.MoveFromTo(listBox, To3listBox);
        }

        private void To3listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            M.ChangeIndex(To3listBox, ref listBox);
        }

        private void fromListBox_Click(object sender, EventArgs e)
        {
            M.MoveFromTo(listBox, fromListBox);
        }

        private void fromListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            M.ChangeIndex(fromListBox, ref listBox);
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            if (fromListBox.Items.Count == 0)
                ResultTextBox.Text = M.ResultButtonClick(AnsverList, To1listBox, To2listBox, To3listBox).ToString() + '/' + M.Count(To1listBox, To2listBox, To3listBox).ToString();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            M.ResetButtonClick(To1listBox, To2listBox, To3listBox, fromListBox);
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            M.ResetButtonClick(To1listBox, To2listBox, To3listBox, fromListBox);
            M.RestartButtonClick(AnsverList, fromListBox, K);
        }

        private void TeacherAccess()
        {
            this.TopicTextBox.ReadOnly = IsStudent;
            this.TaskTextBox.ReadOnly = IsStudent;
            this.To1TextBox.ReadOnly = IsStudent;
            this.To2TextBox.ReadOnly = IsStudent;
            this.To3TextBox.ReadOnly = IsStudent;
            this.FromTextBox.ReadOnly = IsStudent;
            this.ResultTextBox.ReadOnly = IsStudent;
        }

    }
}
