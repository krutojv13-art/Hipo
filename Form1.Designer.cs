namespace Hipo
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            FULL = new ColumnHeader();
            label1 = new Label();
            button1 = new Button();
            listView1 = new ListView();
            NameDisk = new ColumnHeader();
            AllGB = new ColumnHeader();
            FreeGB = new ColumnHeader();
            textBox1 = new TextBox();
            button3 = new Button();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            открытьФайлToolStripMenuItem = new ToolStripMenuItem();
            показатьПапкуToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            spaceLabel1 = new ReaLTaiizor.Controls.SpaceLabel();
            progressBar1 = new ProgressBar();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // FULL
            // 
            FULL.Text = "Заполнено %";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(14, 26);
            label1.Name = "label1";
            label1.Size = new Size(231, 17);
            label1.TabIndex = 0;
            label1.Text = "Введите название файла/программы";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(14, 88);
            button1.Name = "button1";
            button1.Size = new Size(363, 23);
            button1.TabIndex = 1;
            button1.Text = "Найти";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(39, 51, 63);
            listView1.Columns.AddRange(new ColumnHeader[] { NameDisk, AllGB, FreeGB, FULL });
            listView1.ForeColor = Color.White;
            listView1.Location = new Point(437, 20);
            listView1.Name = "listView1";
            listView1.Size = new Size(351, 109);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // NameDisk
            // 
            NameDisk.Text = "Имя Диска";
            // 
            // AllGB
            // 
            AllGB.Text = "Всего (ГБ)";
            // 
            // FreeGB
            // 
            FreeGB.Text = "Свободно (ГБ)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 23);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(437, 132);
            button3.Name = "button3";
            button3.Size = new Size(351, 23);
            button3.TabIndex = 7;
            button3.Text = "Подсчитать Файлы";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // listView2
            // 
            listView2.BackColor = Color.FromArgb(39, 51, 63);
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView2.ContextMenuStrip = contextMenuStrip1;
            listView2.ForeColor = SystemColors.Window;
            listView2.Location = new Point(12, 161);
            listView2.Name = "listView2";
            listView2.Size = new Size(1129, 277);
            listView2.TabIndex = 8;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Имя";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Размер";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Путь";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { открытьФайлToolStripMenuItem, показатьПапкуToolStripMenuItem, удалитьToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(162, 70);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // открытьФайлToolStripMenuItem
            // 
            открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            открытьФайлToolStripMenuItem.Size = new Size(161, 22);
            открытьФайлToolStripMenuItem.Text = "Открыть Файл";
            // 
            // показатьПапкуToolStripMenuItem
            // 
            показатьПапкуToolStripMenuItem.Name = "показатьПапкуToolStripMenuItem";
            показатьПапкуToolStripMenuItem.Size = new Size(161, 22);
            показатьПапкуToolStripMenuItem.Text = "Показать Папку";
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(161, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 114);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 9;
            label2.Click += label2_Click;
            // 
            // spaceLabel1
            // 
            spaceLabel1.Customization = "/v7+/yoqKv8=";
            spaceLabel1.Font = new Font("Verdana", 35F);
            spaceLabel1.Image = null;
            spaceLabel1.Location = new Point(794, 20);
            spaceLabel1.Name = "spaceLabel1";
            spaceLabel1.NoRounding = false;
            spaceLabel1.Size = new Size(347, 135);
            spaceLabel1.TabIndex = 10;
            spaceLabel1.Text = "HIPO demo";
            spaceLabel1.TextAlignment = HorizontalAlignment.Center;
            spaceLabel1.Transparent = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(14, 117);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(361, 38);
            progressBar1.TabIndex = 11;
            progressBar1.Click += progressBar1_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(259, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(116, 23);
            textBox2.TabIndex = 12;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(259, 26);
            label3.Name = "label3";
            label3.Size = new Size(114, 17);
            label3.TabIndex = 13;
            label3.Text = "Введите формат";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(437, -2);
            label4.Name = "label4";
            label4.Size = new Size(56, 19);
            label4.TabIndex = 14;
            label4.Text = "ДИСКИ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.System;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(14, 4);
            label5.Name = "label5";
            label5.Size = new Size(57, 19);
            label5.TabIndex = 15;
            label5.Text = "ПОИСК";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 450);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(progressBar1);
            Controls.Add(spaceLabel1);
            Controls.Add(label2);
            Controls.Add(listView2);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label4);
            Name = "Form1";
            Text = "Hipo";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private ListView listView1;
        private ColumnHeader NameDisk;
        private ColumnHeader AllGB;
        private ColumnHeader FreeGB;
        private ColumnHeader FULL;
        private TextBox textBox1;
        private Button button3;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem открытьФайлToolStripMenuItem;
        private ToolStripMenuItem показатьПапкуToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ReaLTaiizor.Controls.SpaceLabel spaceLabel1;
        private ProgressBar progressBar1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
