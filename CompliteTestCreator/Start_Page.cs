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
    public partial class Start_Page : Form
    {
        public Start_Page()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
        
        private void CreateButton_Click(object sender, EventArgs e)
        {
            /*
            int a = comboBox1.SelectedIndex;
            switch (a)
            {
                case 0:
                    {
                        Form test = new test2kol();
                        test.Show();
                        this.Hide();
                        break;
                    }
                case 1:
                    {
                        Form test = new test3kol();
                        test.Show();
                        this.Hide();
                        break;
                    }
                case 2:
                    {
                        Form test = new test4kol();
                        test.Show();
                        this.Hide();
                        break;
                    }
            }
                */
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Text files(*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog.FileName;
            /*
            int a = comboBox2.SelectedIndex;
            bool isStudent;
            switch (a)
            {
                case 0:
                    {
                        isStudent = true;
                        break;
                    }
                case 1:
                    {
                        isStudent = false;
                        break;
                    }
                default:
                    {
                        isStudent = true;
                        break;
                    }
            }
            */
            int a;
            StreamReader streamReader = new StreamReader(filename);
            int.TryParse(streamReader.ReadLine(), out a);

            switch (a)
            {
                case 2:
                    {
                        Form test = new test2kol(true, filename);
                        test.Show();
                        this.Hide();
                        break;
                    }
                case 3:
                    {
                        Form test = new test3kol(true, filename);
                        test.Show();
                        this.Hide();
                        break;
                    }
                case 4:
                    {
                        Form test = new test4kol(true, filename);
                        test.Show();
                        this.Hide();
                        break;
                    }
            }
        }
    }
}
