
namespace CompliteTestCreator
{
    partial class test2kol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopicTextBox = new System.Windows.Forms.TextBox();
            this.To1listBox = new System.Windows.Forms.ListBox();
            this.To2listBox = new System.Windows.Forms.ListBox();
            this.fromListBox = new System.Windows.Forms.ListBox();
            this.To1TextBox = new System.Windows.Forms.TextBox();
            this.To2TextBox = new System.Windows.Forms.TextBox();
            this.FromTextBox = new System.Windows.Forms.TextBox();
            this.TaskTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.ResultButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.KTextBox = new System.Windows.Forms.TextBox();
            this.KLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // TopicTextBox
            // 
            this.TopicTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopicTextBox.Location = new System.Drawing.Point(21, 3);
            this.TopicTextBox.Name = "TopicTextBox";
            this.TopicTextBox.Size = new System.Drawing.Size(1232, 35);
            this.TopicTextBox.TabIndex = 0;
            this.TopicTextBox.Text = "Тема";
            // 
            // To1listBox
            // 
            this.To1listBox.FormattingEnabled = true;
            this.To1listBox.ItemHeight = 24;
            this.To1listBox.Location = new System.Drawing.Point(20, 146);
            this.To1listBox.Name = "To1listBox";
            this.To1listBox.Size = new System.Drawing.Size(300, 484);
            this.To1listBox.TabIndex = 1;
            this.To1listBox.Click += new System.EventHandler(this.To1listBox_Click);
            this.To1listBox.SelectedIndexChanged += new System.EventHandler(this.To1listBox_SelectedIndexChanged);
            // 
            // To2listBox
            // 
            this.To2listBox.FormattingEnabled = true;
            this.To2listBox.ItemHeight = 24;
            this.To2listBox.Location = new System.Drawing.Point(326, 146);
            this.To2listBox.Name = "To2listBox";
            this.To2listBox.Size = new System.Drawing.Size(300, 484);
            this.To2listBox.TabIndex = 2;
            this.To2listBox.Click += new System.EventHandler(this.To2listBox_Click);
            this.To2listBox.SelectedIndexChanged += new System.EventHandler(this.To2listBox_SelectedIndexChanged);
            // 
            // fromListBox
            // 
            this.fromListBox.FormattingEnabled = true;
            this.fromListBox.ItemHeight = 24;
            this.fromListBox.Location = new System.Drawing.Point(632, 146);
            this.fromListBox.Name = "fromListBox";
            this.fromListBox.Size = new System.Drawing.Size(621, 484);
            this.fromListBox.TabIndex = 3;
            this.fromListBox.Click += new System.EventHandler(this.fromListBox_Click);
            this.fromListBox.SelectedIndexChanged += new System.EventHandler(this.fromListBox_SelectedIndexChanged);
            // 
            // To1TextBox
            // 
            this.To1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.To1TextBox.Location = new System.Drawing.Point(20, 116);
            this.To1TextBox.Name = "To1TextBox";
            this.To1TextBox.Size = new System.Drawing.Size(300, 35);
            this.To1TextBox.TabIndex = 4;
            this.To1TextBox.Text = "Колонка 1";
            this.To1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.To1TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.To1TextBox_KeyDown);
            // 
            // To2TextBox
            // 
            this.To2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.To2TextBox.Location = new System.Drawing.Point(326, 116);
            this.To2TextBox.Name = "To2TextBox";
            this.To2TextBox.Size = new System.Drawing.Size(300, 35);
            this.To2TextBox.TabIndex = 5;
            this.To2TextBox.Text = "Колонка 2";
            this.To2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.To2TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.To2TextBox_KeyDown);
            // 
            // FromTextBox
            // 
            this.FromTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromTextBox.Location = new System.Drawing.Point(631, 116);
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.Size = new System.Drawing.Size(621, 35);
            this.FromTextBox.TabIndex = 6;
            this.FromTextBox.Text = "Примеры";
            this.FromTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TaskTextBox
            // 
            this.TaskTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskTextBox.Location = new System.Drawing.Point(20, 44);
            this.TaskTextBox.Multiline = true;
            this.TaskTextBox.Name = "TaskTextBox";
            this.TaskTextBox.Size = new System.Drawing.Size(1232, 66);
            this.TaskTextBox.TabIndex = 7;
            this.TaskTextBox.Text = "Задание";
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetButton.Location = new System.Drawing.Point(160, 638);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(123, 38);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "Сброс";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestartButton.Location = new System.Drawing.Point(21, 638);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(133, 38);
            this.RestartButton.TabIndex = 9;
            this.RestartButton.Text = "Рестарт";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // ResultButton
            // 
            this.ResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultButton.Location = new System.Drawing.Point(326, 638);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(151, 38);
            this.ResultButton.TabIndex = 10;
            this.ResultButton.Text = "Результат";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTextBox.Location = new System.Drawing.Point(483, 641);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(164, 35);
            this.ResultTextBox.TabIndex = 11;
            // 
            // KTextBox
            // 
            this.KTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KTextBox.Location = new System.Drawing.Point(1017, 638);
            this.KTextBox.Name = "KTextBox";
            this.KTextBox.Size = new System.Drawing.Size(49, 38);
            this.KTextBox.TabIndex = 12;
            this.KTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KTextBox_KeyDown);
            // 
            // KLabel
            // 
            this.KLabel.AutoSize = true;
            this.KLabel.Location = new System.Drawing.Point(669, 633);
            this.KLabel.Name = "KLabel";
            this.KLabel.Size = new System.Drawing.Size(325, 48);
            this.KLabel.TabIndex = 13;
            this.KLabel.Text = "Введите необходимое количество\r\nобъектов теста";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(1072, 641);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(162, 35);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "\"Text files(*.txt)|*.txt\"";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "\"Text files(*.txt)|*.txt\"";
            // 
            // test2kol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.KLabel);
            this.Controls.Add(this.KTextBox);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.TaskTextBox);
            this.Controls.Add(this.FromTextBox);
            this.Controls.Add(this.To2TextBox);
            this.Controls.Add(this.To1TextBox);
            this.Controls.Add(this.fromListBox);
            this.Controls.Add(this.To2listBox);
            this.Controls.Add(this.To1listBox);
            this.Controls.Add(this.TopicTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "test2kol";
            this.Text = "test2kol";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.test2kol_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TopicTextBox;
        private System.Windows.Forms.ListBox To1listBox;
        private System.Windows.Forms.ListBox To2listBox;
        private System.Windows.Forms.ListBox fromListBox;
        private System.Windows.Forms.TextBox To1TextBox;
        private System.Windows.Forms.TextBox To2TextBox;
        private System.Windows.Forms.TextBox FromTextBox;
        private System.Windows.Forms.TextBox TaskTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.TextBox KTextBox;
        private System.Windows.Forms.Label KLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}