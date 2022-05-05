using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace TotalCommander
{
    public partial class Form1 : Form
    {
        private string path1, path2;
        private ImageList icons1 = new ImageList(), icons2 = new ImageList();
        public Form1()
        {
            InitializeComponent();
        }
        public DriveInfo[] LoadDrives()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                drivesCB1.Items.Add(drive);
                drivesCB2.Items.Add(drive);
            }
            return drives;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] drives = LoadDrives();
            drives.OrderBy(s => s.TotalSize);
            drivesCB1.SelectedItem = drives[0];
            drivesCB2.SelectedItem = drives[0];

            explorer1.Scrollable = true;
            explorer1.View = View.Details;
            explorer2.Scrollable = true;
            explorer2.View = View.Details;
            explorer1.SmallImageList = icons1;
            explorer2.SmallImageList = icons2;

            path1 = drives[0].Name;
            path2 = drives[0].Name;
            pathTextBox1.Text = path1;
            pathTextBox2.Text = path2;
            LoadFiles(explorer1, path1);
            LoadFiles(explorer2, path2);
        }

        private void explorer1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < explorer1.Items.Count; i++)
            {
                var rectangle = explorer1.GetItemRect(i);
                if (rectangle.Contains(e.Location))
                {
                    string selectedFilePath = path1 + explorer1.Items[i].Text + "\\";
                    FileAttributes fileAttr = File.GetAttributes(selectedFilePath);
                    if (fileAttr.HasFlag(FileAttributes.Directory))
                    {
                        path1 = selectedFilePath;
                        pathTextBox1.Text = path1;
                        LoadFiles(explorer1, selectedFilePath);
                    }
                    else
                    {
                        try
                        {
                            Process.Start(selectedFilePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    return;
                }
            }
        }
        private void explorer2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < explorer2.Items.Count; i++)
            {
                var rectangle = explorer2.GetItemRect(i);
                if (rectangle.Contains(e.Location))
                {
                    string selectedFilePath = path2 + explorer2.Items[i].Text + "\\";
                    FileAttributes fileAttr = File.GetAttributes(selectedFilePath);
                    if (fileAttr.HasFlag(FileAttributes.Directory))
                    {
                        path2 = selectedFilePath;
                        pathTextBox2.Text = path2;
                        LoadFiles(explorer2, selectedFilePath);
                    }
                    else
                    {
                        try
                        {
                            Process.Start(selectedFilePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    return;
                }
            }
        }
        private bool ItemsFilter(string path)
        {
            FileAttributes fileAttr = File.GetAttributes(path);
            if (fileAttr.HasFlag(FileAttributes.Hidden))
            {
                return false;
            }
            return true;
        }

        private void pathTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                path1 = pathTextBox1.Text;
                if (File.Exists(path1))
                {
                    Process.Start(path1);
                    path1 = Directory.GetParent(path1).FullName + "\\";
                    pathTextBox1.Text = path1;
                }
                LoadFiles(explorer1, path1);
            }
        }

        private void pathTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                path2 = pathTextBox2.Text;
                if (File.Exists(path2))
                {
                    Process.Start(path2);
                    path2 = Directory.GetParent(path2).FullName + "\\";
                    pathTextBox2.Text = path2;
                }
                LoadFiles(explorer2, path2);
            }
        }

        private void upbtn1_Click(object sender, EventArgs e)
        {
            if (Directory.GetParent(path1) != null)
            {
                while (path1[path1.Length - 1].Equals('\\') || path1[path1.Length - 1].Equals('/'))
                {
                    path1 = path1.Remove(path1.Length - 1);
                }
                path1 = Directory.GetParent(path1).FullName + "\\";
                pathTextBox1.Text = path1;
                LoadFiles(explorer1, path1);
            }
        }

        private void upbtn2_Click(object sender, EventArgs e)
        {
            if (Directory.GetParent(path2) != null)
            {
                while (path2[path2.Length - 1].Equals('\\') || path2[path2.Length - 1].Equals('/'))
                {
                    path2 = path2.Remove(path2.Length - 1);
                }
                path2 = Directory.GetParent(path2).FullName + "\\";
                pathTextBox2.Text = path2;
                LoadFiles(explorer2, path2);
            }
        }

        async public void LoadFiles(ListView explorer, string path)
        {
            if (Directory.Exists(path))
            {
                string[] directories = Directory.GetDirectories(path);
                directories = directories.Where(ItemsFilter).ToArray();

                ImageList icons = explorer.SmallImageList;
                explorer.Items.Clear();
                if (icons != null) icons.Images.Clear();
                string[] files = Directory.GetFiles(path);
                for (int i = 0; i < files.Length; i++)
                {
                    icons.Images.Add(Icon.ExtractAssociatedIcon(files[i]));
                    explorer.Items.Add(files[i].Replace(path, ""), i);
                }
                icons.Images.Add(Properties.Resources.Folder_icon);
                foreach (string directory in directories)
                {
                    explorer.Items.Add(directory.Replace(path, ""), icons.Images.Count - 1);
                }
            }
            else
            {
                MessageBox.Show("Файл не найден");
            }
        }
    }
}
