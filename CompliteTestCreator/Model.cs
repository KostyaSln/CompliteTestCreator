using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompliteTestCreator
{
    class Model
    {
        Random Random = new Random();
        bool IsRedacter = false;

        public void MoveFromTo(System.Windows.Forms.ListBox From, System.Windows.Forms.ListBox To)
        {
            if (From != To && From.SelectedIndex != -1)
            {
                To.Items.Add(From.SelectedItem);
                From.Items.Remove(From.SelectedItem);
            }
        }
        public void ChangeIndex(System.Windows.Forms.ListBox New, ref System.Windows.Forms.ListBox Old)
        {
            if (Old != New)
            {
                Old.ClearSelected();
                Old = New;
            }
        }
        public void Redaction (System.Windows.Forms.TextBox To, System.Windows.Forms.ListBox From)
        {
            if (To.Text != "" && !IsRedacter)
                AddToList(To, From);
            if (From.SelectedIndex != -1 && !IsRedacter)
            {
                IsRedacter = true;
                To.Text = From.SelectedItem.ToString();
                From.Items.Remove(From.SelectedItem);
                IsRedacter = false;
            }
        }

        public void AddToList(System.Windows.Forms.TextBox From, System.Windows.Forms.ListBox To)
        {
            if (From.Text != "")
            {
                To.Items.Add(From.Text);
                From.Text = "";
            }
        }

        public void FormAnsverList(ref List<string> AnsList, System.Windows.Forms.ListBox LB1, System.Windows.Forms.ListBox LB2)
        {
            foreach (string i in LB1.Items)
                AnsList.Add('1' + i);
            foreach (string i in LB2.Items)
                AnsList.Add('2' + i);
        }
        public void FormAnsverList(ref List<string> AnsList, System.Windows.Forms.ListBox LB1, System.Windows.Forms.ListBox LB2, System.Windows.Forms.ListBox LB3)
        {
            foreach (string i in LB1.Items)
                AnsList.Add('1' + i);
            foreach (string i in LB2.Items)
                AnsList.Add('2' + i);
            foreach (string i in LB3.Items)
                AnsList.Add('3' + i);
        }
        public void FormAnsverList(ref List<string> AnsList, System.Windows.Forms.ListBox LB1, System.Windows.Forms.ListBox LB2, System.Windows.Forms.ListBox LB3, System.Windows.Forms.ListBox LB4)
        {
            foreach (string i in LB1.Items)
                AnsList.Add('1' + i);
            foreach (string i in LB2.Items)
                AnsList.Add('2' + i);
            foreach (string i in LB3.Items)
                AnsList.Add('3' + i);
            foreach (string i in LB4.Items)
                AnsList.Add('4' + i);
        }

        public int ResultButtonClick(List<string> AnsList, System.Windows.Forms.ListBox LB1, System.Windows.Forms.ListBox LB2)
        {
            int RA = 0;
            foreach (string i in LB1.Items)
                if (AnsList.Contains('1' + i))
                    RA++;
            foreach (string i in LB2.Items)
                if (AnsList.Contains('2' + i))
                    RA++;
            return (RA);
        }
        public int ResultButtonClick(List<string> AnsList, System.Windows.Forms.ListBox LB1, System.Windows.Forms.ListBox LB2, System.Windows.Forms.ListBox LB3)
        {
            int RA = 0;
            foreach (string i in LB1.Items)
                if (AnsList.Contains('1' + i))
                    RA++;
            foreach (string i in LB2.Items)
                if (AnsList.Contains('2' + i))
                    RA++;
            foreach (string i in LB3.Items)
                if (AnsList.Contains('3' + i))
                    RA++;
            return (RA);
        }
        public int ResultButtonClick(List<string> AnsList, System.Windows.Forms.ListBox LB1, System.Windows.Forms.ListBox LB2, System.Windows.Forms.ListBox LB3, System.Windows.Forms.ListBox LB4)
        {
            int RA = 0;
            foreach (string i in LB1.Items)
                if (AnsList.Contains('1' + i))
                    RA++;
            foreach (string i in LB2.Items)
                if (AnsList.Contains('2' + i))
                    RA++;
            foreach (string i in LB3.Items)
                if (AnsList.Contains('3' + i))
                    RA++;
            foreach (string i in LB4.Items)
                if (AnsList.Contains('4' + i))
                    RA++;
            return (RA);
        }



        public int Count(System.Windows.Forms.ListBox LB1, System.Windows.Forms.ListBox LB2)
        {
            int R;
            R = LB1.Items.Count + LB2.Items.Count;
            return (R);
        }
        public int Count(System.Windows.Forms.ListBox LB1, System.Windows.Forms.ListBox LB2, System.Windows.Forms.ListBox LB3)
        {
            int R;
            R = LB1.Items.Count + LB2.Items.Count + LB3.Items.Count;
            return (R);
        }
        public int Count(System.Windows.Forms.ListBox LB1, System.Windows.Forms.ListBox LB2, System.Windows.Forms.ListBox LB3, System.Windows.Forms.ListBox LB4)
        {
            int R;
            R = LB1.Items.Count + LB2.Items.Count + LB3.Items.Count + LB4.Items.Count;
            return (R);
        }

        public void ResetButtonClick(System.Windows.Forms.ListBox LB1, System.Windows.Forms.ListBox LB2, System.Windows.Forms.ListBox To)
        {

            To.Items.AddRange(LB1.Items);
            To.Items.AddRange(LB2.Items);
            LB1.Items.Clear();
            LB2.Items.Clear();
            Shafle(To.Items);
        }
        public void ResetButtonClick(System.Windows.Forms.ListBox LB1, System.Windows.Forms.ListBox LB2, System.Windows.Forms.ListBox LB3, System.Windows.Forms.ListBox To)
        {

            To.Items.AddRange(LB1.Items);
            To.Items.AddRange(LB2.Items);
            To.Items.AddRange(LB3.Items);
            LB1.Items.Clear();
            LB2.Items.Clear();
            LB3.Items.Clear();
            Shafle(To.Items);
        }
        public void ResetButtonClick(System.Windows.Forms.ListBox LB1, System.Windows.Forms.ListBox LB2, System.Windows.Forms.ListBox LB3, System.Windows.Forms.ListBox LB4, System.Windows.Forms.ListBox To)
        {

            To.Items.AddRange(LB1.Items);
            To.Items.AddRange(LB2.Items);
            To.Items.AddRange(LB3.Items);
            To.Items.AddRange(LB4.Items);
            LB1.Items.Clear();
            LB2.Items.Clear();
            LB3.Items.Clear();
            LB4.Items.Clear();
            Shafle(To.Items);
        }


        public void RestartButtonClick(List<string> AnsList, System.Windows.Forms.ListBox To, int K)
        {
            Shafle(AnsList);
            To.Items.Clear();
            if(K == 0)
            {
                K = AnsList.Count;
            }
            for (int i = 0; i < AnsList.Count; i++)
            {
                double rnd = Random.NextDouble();
                if (rnd < (double) K/(AnsList.Count - i))
                {
                    To.Items.Add(AnsList[i].Substring(1));
                    K--;
                }
            }
        }

        private void Shafle(List<string> Shaf)
        {
            for (int i = 0; i < Shaf.Count - 1; i++)
            {
                int j = Random.Next(i + 1, Shaf.Count);
                String temp = Shaf[i];
                Shaf[i] = Shaf[j];
                Shaf[j] = temp;
            }
        }

        private void Shafle(System.Windows.Forms.ListBox.ObjectCollection Shaf)
        {
            for (int i = 0; i < Shaf.Count - 1; i++)
            {
                int j = Random.Next(i + 1, Shaf.Count);
                Object temp = Shaf[i];
                Shaf[i] = Shaf[j];
                Shaf[j] = temp;
            }
        }
    }
}
