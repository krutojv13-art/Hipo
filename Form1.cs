
using ReaLTaiizor.Controls;
using System.Diagnostics;
using System.IO;
using Hipo;
namespace Hipo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private List<FileInfo> _allFiles = new List<FileInfo>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Classes.Method.LoadList(this.listView1);
            ContextMenu();
            progressBar1.Visible = false;

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string drivePath = listView1.SelectedItems[0].Text;

                try
                {
                    listView2.Items.Clear();

                    string[] files = Directory.GetFiles(drivePath);

                    foreach (string file in files)
                    {
                        listView2.Items.Add(file);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при чтении диска: {ex.Message}", "Внимание",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
        }


        private System.Windows.Forms.Timer _animationTimer;
        private async void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            string drivePath = listView1.SelectedItems[0].Text;

            button3.Enabled = false;
            button1.Enabled = false;
            listView2.Items.Clear();

            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Marquee;



            try
            {
                await Task.Run(() =>
                {
                    var options = new EnumerationOptions
                    {
                        IgnoreInaccessible = true,
                        RecurseSubdirectories = true
                    };

                    DirectoryInfo di = new DirectoryInfo(drivePath);
                    var files = di.EnumerateFiles("*.*", options);

                    _allFiles.Clear();

                    foreach (var file in files)
                    {
                        _allFiles.Add(file);
                    }
                });

                ApplyFilters();

                label2.Text = $"Готово! Найдено: {_allFiles.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                progressBar1.Visible = false;
                button3.Enabled = true;
                button1.Enabled = true;
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }
        private ContextMenuStrip contextmenu;



        private void OpenFile(object sender, EventArgs e)
        {
            string path = Classes.Method.GetSelectedFile(this.listView2);
            if (path == null) return;
            Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
        }
        private void ShowFolder(object sender, EventArgs e)
        {
            string path = Classes.Method.GetSelectedFile(this.listView2);
            if (path == null) return;
            Process.Start("explorer.exe", $"/select,\"{path}\"");
        }
        private void DeleteFile(object sender, EventArgs e)
        {
            string path = Classes.Method.GetSelectedFile(this.listView2);
            if (path == null) return;
            if (MessageBox.Show("Вы уверены что хотите удалить этот файл?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try { File.Delete(path); listView2.SelectedItems[0].Remove(); }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void ContextMenu()
        {
            contextmenu = new ContextMenuStrip();

            var openFile = new ToolStripMenuItem("Открыть файл");
            var showFolderFile = new ToolStripMenuItem("Показать папку");
            var deleteFile = new ToolStripMenuItem("Удалить");

            openFile.Click += OpenFile;
            showFolderFile.Click += ShowFolder;
            deleteFile.Click += DeleteFile;

            contextmenu.Items.AddRange(new ToolStripItem[]
            {
                openFile,
                showFolderFile,
                deleteFile
            });

            listView2.ContextMenuStrip = contextmenu;
        }

        private void ApplyFilters()
        {
            string search = textBox1.Text.ToLower();
            string extension = textBox2.Text.ToLower().Trim();

            if (!string.IsNullOrEmpty(extension) && !extension.StartsWith("."))
            {
                extension = "." + extension;
            }

            listView2.Items.Clear();

            var filtered = _allFiles.Where(f =>
                (string.IsNullOrEmpty(search) || f.Name.ToLower().Contains(search)) &&
                (string.IsNullOrEmpty(extension) || f.Extension.ToLower() == extension)

            );

            listView2.BeginUpdate();

            foreach (var file in filtered)
            {
                var item = new ListViewItem(file.Name);
                item.SubItems.Add((file.Length / 1048576.0).ToString("0.00") + " МБ");
                item.SubItems.Add(file.FullName);

                listView2.Items.Add(item);
            }
            label2.Text = $"Найдено: {listView2.Items.Count}";
            listView2.EndUpdate();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void foxNotification1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_allFiles.Count == 0)
            {
                MessageBox.Show("Сначала просканируй диск (кнопка подсчета файлов)");
                return;
            }
            ApplyFilters();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }
    }
}



