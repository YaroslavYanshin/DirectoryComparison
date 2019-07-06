using System;
using System.IO;
using System.Windows.Forms;

namespace DirectoryComparison
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SizeColumns();
        }

        private void SizeColumns()
        {
            int wid = (int)((dgvFiles.Width - 50) / 2);
            if (wid < 10) wid = 10;
            dgvFiles.Columns[0].Width = wid;
            dgvFiles.Columns[1].Width = wid;
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            dgvFiles.Rows.Clear();

            string dir1 = tbDir1.Text;
            if (!dir1.EndsWith("\\")) dir1 += "\\";
            string[] file_names1 = Directory.GetFiles(dir1);
            for (int i = 0; i < file_names1.Length; i++)
            {
                file_names1[i] = file_names1[i].Replace(dir1, "");
            }
            Array.Sort(file_names1);

            string dir2 = tbDir2.Text;
            if (!dir2.EndsWith("\\")) dir2 += "\\";
            string[] file_names2 = Directory.GetFiles(dir2);
            for (int i = 0; i < file_names2.Length; i++)
            {
                file_names2[i] = file_names2[i].Replace(dir2, "");
            }
            Array.Sort(file_names2);

            int i1 = 0, i2 = 0;
            while ((i1 < file_names1.Length) && (i2 < file_names2.Length))
            {
                if (file_names1[i1] == file_names2[i2])
                {
                    dgvFiles.Rows.Add(new Object[] { file_names1[i1], file_names2[i2] });
                    i1++;
                    i2++;
                }
                else if (file_names1[i1].CompareTo(file_names2[i2]) < 0)
                {
                    dgvFiles.Rows.Add(new Object[] { file_names1[i1], null });
                    i1++;
                }
                else
                {
                    dgvFiles.Rows.Add(new Object[] { null, file_names2[i2] });
                    i2++;
                }
            }

            for (int i = i1; i < file_names1.Length; i++)
            {
                dgvFiles.Rows.Add(new Object[] { file_names1[i], null });
            }


            for (int i = i2; i < file_names2.Length; i++)
            {
                dgvFiles.Rows.Add(new Object[] { null, file_names2[i] });
            }



        }

        private void btnDir1_Click(object sender, EventArgs e)
        {
            FBD.ShowNewFolderButton = false;
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                tbDir1.Text =  FBD.SelectedPath;
            }
        }

        private void btnDir2_Click(object sender, EventArgs e)
        {
            FBD.ShowNewFolderButton = false;
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                tbDir2.Text = FBD.SelectedPath;
            }

        }
    }
}
